// Copyright AyeTSG 2022.

// Handles the UI for
// data exports from Kulector

using KulectorDB;
using KulectorExporter;

namespace KulectorUI.Forms
{
    public partial class Export : Form
    {
        private Kulection KulToExport;

        public Export(Kulection InKul)
        {
            this.KulToExport = InKul;

            InitializeComponent();
        }

        private void BtnTextFile_Click(object sender, EventArgs e)
        {
            // show the save dialog
            SfdExportTxt.ShowDialog();

            // export the kulection to a txt
            TxtFileExport txtExport = new TxtFileExport();
            txtExport.Export(KulToExport, SfdExportTxt.FileName);
        }
    }
}
