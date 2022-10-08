// Copyright AyeTSG 2022.

// Handles the UI for
// creating a new Kulection

using KulectorDB;

namespace KulectorUI.Forms
{
    public partial class NewKul : Form
    {
        public NewKul()
        {
            // setup components
            InitializeComponent();
        }

        // Create the actual collection
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            // create a new kulection
            Kulection tmpKul = new Kulection(TbCollectionName.Text);

            // show new kullection window
            this.Hide();
            var NewKulForm = new ManageKulection(tmpKul);
            NewKulForm.FormClosed += (s, args) => this.Close();
            NewKulForm.Show();
        }
    }
}
