using System.IO;
using Microsoft.Extensions.Configuration;

namespace MEnU
{
    public static class AppConfig
    {
        public static string? FirebaseApiKey {  get; set; }
        public static string? FirebaseAuthDomain { get; set; }

        static AppConfig()
        {
            var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

            var config2 = new ConfigurationBuilder();

            FirebaseApiKey = config["Firebase:ApiKey"];
            FirebaseAuthDomain = config["Firebase.AuthDomain"];
        }
    }
}
