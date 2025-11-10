namespace MEnU
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            FirebaseAuthService.Initialize();
            if (FirebaseAuthService.GetCurrentUser() != null)
            {
                Application.Run(new frmHome()); // remember user token
            }
            else
            {
                Application.Run(new frmLogin()); // forget user token
            }
        }
    }
}