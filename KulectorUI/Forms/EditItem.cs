// Copyright AyeTSG 2022.

using KulectorDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KulectorUI.Forms
{
    public partial class EditItem : Form
    {
        public string StoredItemName;
        public string StoredItemDescription;
        public int StoredItemCount;
        public Bitmap StoredItemImage;

        private ManageKulection _kulmanWin;
        private int WorkingInt;

        public EditItem(ManageKulection kulmanWin, int RowIndex, string ItemName, string ItemDescription, int ItemCount, Bitmap ItemImage)
        {
            InitializeComponent();

            _kulmanWin = kulmanWin;
            WorkingInt = RowIndex;

            StoredItemName = ItemName;
            StoredItemDescription = ItemDescription;
            StoredItemCount = ItemCount;
            StoredItemImage = ItemImage;

            TbItemName.Text = StoredItemName;
            RtbItemDesc.Text = StoredItemDescription;
            NudItemQuantity.Value = StoredItemCount;
            pictureBox1.Image = StoredItemImage;
        }

        private void BtnSaveItem_Click(object sender, EventArgs e)
        {
            StoredItemName = TbItemName.Text;
            StoredItemDescription = RtbItemDesc.Text;
            StoredItemCount = (int)NudItemQuantity.Value;
            StoredItemImage = (Bitmap)pictureBox1.Image;

            _kulmanWin.DGVItems.Rows[WorkingInt].Cells[0].Value = StoredItemName;
            _kulmanWin.DGVItems.Rows[WorkingInt].Cells[1].Value = StoredItemDescription;
            _kulmanWin.DGVItems.Rows[WorkingInt].Cells[2].Value = StoredItemCount;
            _kulmanWin.DGVItems.Rows[WorkingInt].Cells[3].Value = StoredItemImage;

            this.Close();
        }

        private void BtnCancelEditing_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnImageChange_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            // create image
            Bitmap tmpBit = new Bitmap(openFileDialog1.FileName);

            pictureBox1.Image = tmpBit;
        }
    }
}
