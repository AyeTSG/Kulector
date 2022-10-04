namespace KulectorUI
{
    internal static class Program
    {
        // KulectorUI version
        public static string VERSION = "v0.2";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Forms.Greeting());
        }
    }
}