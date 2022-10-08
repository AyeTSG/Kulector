// Copyright AyeTSG 2022.

// Handles the UI for editing
// or otherwise manipulating a single
// Kulection item.

namespace KulectorUI.Forms
{
    public partial class EditItem : Form
    {
        // hold the item name
        public string StoredItemName;

        // hold the item description
        public string StoredItemDescription;

        // hold the item quantity
        public int StoredItemCount;

        // hold the item image
        public Bitmap StoredItemImage;

        // hold a reference to the data
        // within the kulection manager
        private ManageKulection _kulmanWin;
        private int WorkingInt;

        public EditItem(ManageKulection kulmanWin, int RowIndex, string ItemName, string ItemDescription, int ItemCount, Bitmap ItemImage)
        {
            // setup the components
            InitializeComponent();

            // set default values
            _kulmanWin = kulmanWin;
            WorkingInt = RowIndex;

            StoredItemName = ItemName;
            StoredItemDescription = ItemDescription;
            StoredItemCount = ItemCount;
            StoredItemImage = ItemImage;

            // set the ui values to what's currently stored
            TbItemName.Text = StoredItemName;
            RtbItemDesc.Text = StoredItemDescription;
            NudItemQuantity.Value = StoredItemCount;
            pictureBox1.Image = StoredItemImage;
        }

        // on save...
        private void BtnSaveItem_Click(object sender, EventArgs e)
        {
            // set the stored data to
            // what's currently on the ui
            StoredItemName = TbItemName.Text;
            StoredItemDescription = RtbItemDesc.Text;
            StoredItemCount = (int)NudItemQuantity.Value;
            StoredItemImage = (Bitmap)pictureBox1.Image;

            // set the data in the kulection manager
            _kulmanWin.DGVItems.Rows[WorkingInt].Cells[0].Value = StoredItemName;
            _kulmanWin.DGVItems.Rows[WorkingInt].Cells[1].Value = StoredItemDescription;
            _kulmanWin.DGVItems.Rows[WorkingInt].Cells[2].Value = StoredItemCount;
            _kulmanWin.DGVItems.Rows[WorkingInt].Cells[3].Value = StoredItemImage;

            // close this window
            this.Close();
        }

        // on cancel...
        private void BtnCancelEditing_Click(object sender, EventArgs e)
        {
            // close this window
            this.Close();
        }

        // on image change...
        private void BtnImageChange_Click(object sender, EventArgs e)
        {
            // show the file open dialog
            openFileDialog1.ShowDialog();

            // create an image from the
            // selected file
            Bitmap tmpBit = new Bitmap(openFileDialog1.FileName);

            // set the ui to the
            // created image
            pictureBox1.Image = tmpBit;
        }
    }
}
