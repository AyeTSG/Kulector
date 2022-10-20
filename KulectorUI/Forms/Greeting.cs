// Copyright AyeTSG 2022.

// Handles the ui for welcoming
// the user to the Kulector app

using KulectorDB;
using KulectorExternalApis;

namespace KulectorUI.Forms
{
    public partial class Greeting : Form
    {
        public Greeting()
        {
            // setup components
            InitializeComponent();
        }

        // Create Kulection
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            // show new kullection window
            this.Hide();
            var NewKulForm = new NewKul();
            NewKulForm.FormClosed += (s, args) => this.Close();
            NewKulForm.Show();
        }

        // Open Kulection
        private void BtnOpen_Click(object sender, EventArgs e)
        {
            // Show the dialog
            OfdOpenKul.ShowDialog();

            // Get the Kulection
            Kulection openedKul = KulectionSerialization.LoadKulectionFileV2(OfdOpenKul.FileName);

            // Check the version
            if (openedKul.KulectionVersion != KulectorDB.VersionInfo.VERSION)
            {
                // Show the warning dialog!
                this.Hide();
                var WarningForm = new VerWarning(openedKul);
                WarningForm.FormClosed += (s, args) => this.Close();
                WarningForm.Show();
            }
            else
            {

                // Open a Kulection
                this.Hide();
                var NewManageForm = new ManageKulection(openedKul);
                NewManageForm.FormClosed += (s, args) => this.Close();
                NewManageForm.Show();
            }
        }

        // on advance import...
        private void BtnAdvanceImport_Click(object sender, EventArgs e)
        {
            // Open a Kulection
            this.Hide();
            var NewManageForm = new AdvancedImport();
            NewManageForm.FormClosed += (s, args) => this.Close();
            NewManageForm.Show();
        }

        // on about...
        private void button1_Click(object sender, EventArgs e)
        {
            // Open the about window
            var NewAboutForm = new About();
            NewAboutForm.Show();
        }
    }
}
