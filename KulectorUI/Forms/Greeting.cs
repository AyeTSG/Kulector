// Copyright AyeTSG 2022.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KulectorDB;

namespace KulectorUI.Forms
{
    public partial class Greeting : Form
    {
        public Greeting()
        {
            InitializeComponent();

            // set version info
            LblUiVer.Text = "KulectionUI " + Program.VERSION;
            LblDbVer.Text = "KulectionDB " + KulectionConstants.VERSION;
        }

        // Create Kulection
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            /* == old ==
            // Show the dialog
            SfdCreateKul.ShowDialog();

            // Create a Kulection
            Kulection createdKul = new Kulection("New Kulection");
            KulectionSerialization.WriteKulectionFile(SfdCreateKul.FileName, createdKul);
            */

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
