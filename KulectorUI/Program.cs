using KulectorDB;
using KulectorUI.Forms;
using Newtonsoft.Json;

namespace KulectorUI
{
    internal static class Program
    {
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
                Kulection tmpKul;

                // Get the Kulection
                try
                {
                    tmpKul = KulectionSerialization.LoadKulectionFileV2(args[0]);
                }
                catch (JsonReaderException)
                {
                    tmpKul = KulectionSerialization.LoadKulectionFile(args[0]);
                }

                // Check the version
                if (tmpKul.KulectionVersion != KulectorDB.VersionInfo.VERSION)
                {
                    // Show the warning dialog!
                    Application.Run(new VerWarning(tmpKul));
                }
                else
                {

                    // Open a Kulection
                    Application.Run(new ManageKulection(tmpKul));
                }
            }
            else
            {
                Application.Run(new Forms.Greeting());
            }
        }
    }
}