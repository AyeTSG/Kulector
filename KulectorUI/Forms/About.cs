// Copyright AyeTSG 2022.

// Handles the UI for the
// about Kulector dialog

namespace KulectorUI.Forms
{
    public partial class About : Form
    {
        public About()
        {
            // setup components
            InitializeComponent();

            // set versions
            LblDbVer.Text = "KulectorDB " + KulectorDB.VersionInfo.VERSION;
            LblExporterVer.Text = "KulectorExporter " + KulectorExporter.VersionInfo.VERSION;
            LblExternalApiVer.Text = "KulectorExternalApis " + KulectorExternalApis.VersionInfo.VERSION;
            LblUiVer.Text = "KulectorUI " + KulectorUI.VersionInfo.VERSION;
        }
    }
}
