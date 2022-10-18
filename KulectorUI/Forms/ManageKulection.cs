// Copyright AyeTSG 2022.

// Handles the UI for managing
// the items and data within
// a Kulection

using KulectorDB;

namespace KulectorUI.Forms
{
    public partial class ManageKulection : Form
    {
        // hold the kulection in memory
        private Kulection WorkingKulection;

        public ManageKulection(Kulection InCollection)
        {
            // set the working kulection
            WorkingKulection = InCollection;

            // setup components
            InitializeComponent();

            // set the ui title to the kulection title
            LBLTitle.Text = WorkingKulection.KulectionName;

            // populate the item list
            PopulateItems();
        }

        // populate list items
        private void PopulateItems()
        {
            // loop over each kulection item
            foreach (KulectionItem Item in WorkingKulection.KulectionItems)
            {
                // add entry to list (name, desc, guid, quantity)
                DGVItems.Rows.Add(Item.ItemName, Item.ItemDescription, Item.ItemQuantity, Item.ItemImage);
            }
        }

        // save list items
        private void SaveToWorking()
        {
            // delete old working
            Kulection NewWorkingKulection = new Kulection(WorkingKulection.KulectionName);
            WorkingKulection = NewWorkingKulection;

            // loop over each row
            foreach (DataGridViewRow Row in DGVItems.Rows)
            {
                // add item
                WorkingKulection.AddItem((string)Row.Cells[0].Value, (string)Row.Cells[1].Value, (int)Row.Cells[2].Value, (Bitmap)Row.Cells[3].Value);
            }

            // set the title
            WorkingKulection.KulectionName = LBLTitle.Text;
        }

        // save kulection out to file
        private void BTNSave_Click(object sender, EventArgs e)
        {
            // save the ui data to the kulection
            SaveToWorking();

            // Show the dialog
            SfdCreateKul.ShowDialog();

            // Create a Kulection file
            KulectionSerialization.WriteKulectionFile(SfdCreateKul.FileName, WorkingKulection);
        }

        // on add item...
        private void BTNAdd_Click(object sender, EventArgs e)
        {
            // create a temp 256x256 image
            Bitmap tmpImage = new Bitmap(256, 256);

            // add the new item to the UI
            DGVItems.Rows.Add("New Item", "Item Description", 1, tmpImage);
        }

        // on remove item...
        private void BTNRemove_Click(object sender, EventArgs e)
        {
            // prevent anything but first column from being selected
            foreach (DataGridViewCell Cell in DGVItems.SelectedCells)
            {
                if (DGVItems.Columns[Cell.ColumnIndex].Name != ClmName.Name)
                {
                    Cell.Selected = false;
                }
            }

            // for each selected column...
            foreach (DataGridViewCell Cell in DGVItems.SelectedCells)
            {
                // remove it from the ui
                DGVItems.Rows.RemoveAt(Cell.RowIndex);
            }
        }

        // on cell double click...
        private void DGVItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // get the item
            DataGridViewRow Row = DGVItems.Rows[e.RowIndex];

            // create and open a new item editor
            var NewKulForm = new EditItem(this, e.RowIndex, (string)Row.Cells[0].Value, (string)Row.Cells[1].Value, (int)Row.Cells[2].Value, (Bitmap)Row.Cells[3].Value);
            NewKulForm.Show();
        }

        // on kulection rename...
        private void BtnRenameKul_Click(object sender, EventArgs e)
        {
            // create and open a new rename window
            var RenameForm = new RenameKul(this);
            RenameForm.Show();
        }

        // on kulection export...
        private void BTNExport_Click(object sender, EventArgs e)
        {
            // save the ui to working
            SaveToWorking();

            // show the export dialog
            var NewExportForm = new Export(WorkingKulection);
            NewExportForm.Show();
        }
    }
}
