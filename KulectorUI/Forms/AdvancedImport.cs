using System;
using System.Collections.Generic;
using System.ComponentModel;
using KulectorDB;
// Copyright AyeTSG 2022.

// Handles the UI for advanced
// data imports into Kulector

using KulectorExternalApis;

namespace KulectorUI.Forms
{
    public partial class AdvancedImport : Form
    {
        public AdvancedImport()
        {
            InitializeComponent();
        }

        // On discogs csv...
        private void BtnDiscogsCsv_Click(object sender, EventArgs e)
        {
            // Show the Discogs open dialog
            OfdDiscogs.ShowDialog();

            // Create an instance of the discogs API
            DiscogsApi Discogs = new DiscogsApi();

            // Create the Kulection
            Kulection DiscogsKul = Discogs.FromCollectionCsv(OfdDiscogs.FileName);

            // Open it
            this.Hide();
            var NewManageForm = new ManageKulection(DiscogsKul);
            NewManageForm.FormClosed += (s, args) => this.Close();
            NewManageForm.Show();
        }
    }
}
