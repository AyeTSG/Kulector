// Copyright AyeTSG 2022.

// Handles the UI for renaming
// an existing Kulection

namespace KulectorUI.Forms
{
    public partial class RenameKul : Form
    {
        // hold the current kulection data ui
        private ManageKulection _kulmanWin;

        public RenameKul(ManageKulection kulmanWin)
        {
            // setup components
            InitializeComponent();

            // hold the current kulection data ui
            _kulmanWin = kulmanWin;

            // set the ui text to the current text
            TbCollectionName.Text = _kulmanWin.LBLTitle.Text;
        }

        // on rename...
        private void BtnRename_Click(object sender, EventArgs e)
        {
            // set the main ui text
            _kulmanWin.LBLTitle.Text = TbCollectionName.Text;

            // close this window
            this.Close();
        }
    }
}
