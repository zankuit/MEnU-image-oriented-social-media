using MEnU.Models;
using Newtonsoft.Json.Linq;
using System.Net.Http.Json;
using System.Net.WebSockets;
using System.Text;

namespace MEnU.Services
{
    class RealtimeService
    {
        private ClientWebSocket _ws;
        private CancellationTokenSource _cts;
        private readonly string _baseWsUrl =
            "wss://unvulgarly-unfueled-mozella.ngrok-free.dev/ws";

        private bool _isRunning;

        // ===== Events cho UI =====
        public event Action<Notification> OnFriendReceived;
        public event Action<Notification> OnReactionReceived;
        public event Action<string> OnRawMessage;
        public event Action<RealtimeMessageDto> OnChatReceived;
        public event Action OnConnected;
        public event Action OnDisconnected;

        // ===== Public API =====
        public Task StartAsync(string accessToken)
        {
            if (_isRunning) return Task.CompletedTask;

            _isRunning = true;
            _cts = new CancellationTokenSource();

            _ = Task.Run(RunAsync);
            return Task.CompletedTask;
        }

        public async Task StopAsync()
        {
            _isRunning = false;

            try
            {
                _cts.Cancel();

                if (_ws?.State == WebSocketState.Open)
                {
                    await _ws.CloseAsync(
                        WebSocketCloseStatus.NormalClosure,
                        "Client closed",
                        CancellationToken.None
                    );
                }
            }
            catch { }
        }

        // ===== Core Loop =====
        private async Task RunAsync()
        {
            while (_isRunning)
            {
                try
                {
                    LoadToken(out string accessToken, out string _);

                    await ConnectAsync(accessToken);
                    OnConnected?.Invoke();

                    await ReceiveLoopAsync();
                }
                //catch (TokenExpiredException)
                //{
                //    await Refresh();
                //}
                catch (Exception ex)
                {
                    OnRawMessage?.Invoke("Socket error: " + ex.Message);
                }

                OnDisconnected?.Invoke();

                // delay trước khi reconnect
                await Task.Delay(3000);
            }
        }

        private async Task ConnectAsync(string accessToken)
        {
            _ws = new ClientWebSocket();

            var uri = new Uri($"{_baseWsUrl}?token={accessToken}");

            try
            {
                await _ws.ConnectAsync(uri, _cts.Token);
            }
            catch (Exception ex)
            {
                OnRawMessage?.Invoke("Connect exception: " + ex);
                throw;
            }
        }

        private async Task ReceiveLoopAsync()
        {
            byte[] buffer = new byte[4096];

            while (_ws.State == WebSocketState.Open && !_cts.IsCancellationRequested)
            {
                var result = await _ws.ReceiveAsync(
                    new ArraySegment<byte>(buffer),
                    _cts.Token
                );

                OnRawMessage?.Invoke(
                    $"WS: Type={result.MessageType}, CloseStatus={_ws.CloseStatus}, Reason={_ws.CloseStatusDescription}"
                );

                if (result.MessageType == WebSocketMessageType.Close)
                    break;

                string json = Encoding.UTF8.GetString(buffer, 0, result.Count);
                DispatchMessage(json);
            }
        }

        // ===== Dispatcher =====
        private void DispatchMessage(string json)
        {
            OnRawMessage?.Invoke(json);

            JObject obj;
            try
            {
                obj = JObject.Parse(json);
            }
            catch
            {
                return;
            }

            var type = obj["type"]?.ToString();

            switch (type)
            {
                case "friend":
                    var notification = obj.ToObject<Notification>();
                    OnFriendReceived?.Invoke(notification);
                    break;

                case "chat":
                    var msg = obj.ToObject<RealtimeMessageDto>();
                    OnChatReceived?.Invoke(msg);
                    break;

                case "reacion":
                    var reactNoti = obj.ToObject<Notification>();
                    OnReactionReceived?.Invoke(reactNoti);
                    break;
            }
        }

        // ===== Token Handler =====
        private void LoadToken(out string accessToken, out string refreshToken)
        {
            accessToken = refreshToken = "";

            string appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string folderPath = Path.Combine(appData, "MEnU");
            string filePath = Path.Combine(folderPath, "token.txt");

            var jwtToken = File.ReadAllText(filePath);

            string[] parts = jwtToken.Split(';');

            accessToken = parts[0];
            refreshToken = parts[1];
        }
        private void SaveToken(string accessToken, string refreshToken)
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string folderPath = Path.Combine(appData, "MEnU");

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            string filePath = Path.Combine(folderPath, "token.txt");

            string token = $"{accessToken};{refreshToken}";

            File.WriteAllText(filePath, token);
        }

        private async Task<bool> Refresh()
        {
            LoadToken(out string AccessToken, out string RefreshToken);

            using var client = new HttpClient();
            var body = new
            {
                refreshToken = RefreshToken
            };

            var response = await client.PostAsJsonAsync(@"https://unvulgarly-unfueled-mozella.ngrok-free.dev/api/auth/refresh", body);

            bool success = (bool)JObject.Parse(await response.Content.ReadAsStringAsync())["success"];

            if (!success) return false;

            var json = JObject.Parse(await response.Content.ReadAsStringAsync());
            var data = json["data"];
            //AccessToken = json["accessToken"]!.ToString();
            //RefreshToken = json["refreshToken"]!.ToString();

            SaveToken(data["accessToken"]!.ToString(), data["refreshToken"]!.ToString());

            return true;
        }
    }
}
