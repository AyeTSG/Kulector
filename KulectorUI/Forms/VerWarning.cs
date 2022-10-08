// Copyright AyeTSG 2022.

// Handles the UI for the
// version warning

using KulectorDB;

namespace KulectorUI.Forms
{
    public partial class VerWarning : Form
    {
        // hold a reference to the incoming kulection
        private Kulection incoming;

        public VerWarning(Kulection inKul)
        {
            // hold the incoming kulection
            incoming = inKul;

            // setup components
            InitializeComponent();
        }

        // on cancel...
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // close the window
            this.Close();
        }

        // on accept.
        private void BtnContinue_Click(object sender, EventArgs e)
        {
            // Open the
            this.Hide();
            var NewManageForm = new ManageKulection(incoming);
            NewManageForm.FormClosed += (s, args) => this.Close();
            NewManageForm.Show();
        }
    }
}
