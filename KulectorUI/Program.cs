using KulectorDB;

namespace KulectorUI
{
    internal static class Program
    {
        // KulectorUI version
        public static string VERSION = "v0.3";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //MessageBox.Show(args.Length.ToString());

            ApplicationConfiguration.Initialize();

            if (args.Length >= 1)
            {
                // grab file path
                Kulection tmpKul = KulectionSerialization.LoadKulectionFile(args[0]);

                // run the app
                Application.Run(new Forms.ManageKulection(tmpKul));
            }
            else
            {
                Application.Run(new Forms.Greeting());
            }
        }
    }
}