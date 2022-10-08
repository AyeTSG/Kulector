// Copyright AyeTSG 2022.

// Handles the ui for welcoming
// the user to the Kulector app

using KulectorDB;

namespace KulectorUI.Forms
{
    public partial class Greeting : Form
    {
        public Greeting()
        {
            // setup components
            InitializeComponent();

            // set version info
            LblUiVer.Text = "KulectionUI " + Program.VERSION;
            LblDbVer.Text = "KulectionDB " + KulectionConstants.VERSION;
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
            Kulection openedKul = KulectionSerialization.LoadKulectionFile(OfdOpenKul.FileName);

            // Open a Kulection
            this.Hide();
            var NewManageForm = new ManageKulection(openedKul);
            NewManageForm.FormClosed += (s, args) => this.Close();
            NewManageForm.Show();
        }
    }
}
