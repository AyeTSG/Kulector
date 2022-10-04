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

        private ManageKulection _kulmanWin;
        private int WorkingInt;

        public EditItem(ManageKulection kulmanWin, int RowIndex, string ItemName, string ItemDescription, int ItemCount)
        {
            InitializeComponent();

            _kulmanWin = kulmanWin;
            WorkingInt = RowIndex;

            StoredItemName = ItemName;
            StoredItemDescription = ItemDescription;
            StoredItemCount = ItemCount;

            TbItemName.Text = StoredItemName;
            RtbItemDesc.Text = StoredItemDescription;
            NudItemQuantity.Value = StoredItemCount;
        }

        private void BtnSaveItem_Click(object sender, EventArgs e)
        {
            StoredItemName = TbItemName.Text;
            StoredItemDescription = RtbItemDesc.Text;
            StoredItemCount = (int)NudItemQuantity.Value;

            _kulmanWin.DGVItems.Rows[WorkingInt].Cells[0].Value = StoredItemName;
            _kulmanWin.DGVItems.Rows[WorkingInt].Cells[1].Value = StoredItemDescription;
            _kulmanWin.DGVItems.Rows[WorkingInt].Cells[2].Value = StoredItemCount;
        }
    }
}
