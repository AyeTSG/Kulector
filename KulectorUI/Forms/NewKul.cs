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
    public partial class NewKul : Form
    {
        public NewKul()
        {
            InitializeComponent();
        }

        // Create the actual collection
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Kulection tmpKul = new Kulection(TbCollectionName.Text);

            // show new kullection window
            this.Hide();
            var NewKulForm = new ManageKulection(tmpKul);
            NewKulForm.FormClosed += (s, args) => this.Close();
            NewKulForm.Show();
        }
    }
}
