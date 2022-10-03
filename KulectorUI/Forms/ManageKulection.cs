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
    public partial class ManageKulection : Form
    {
        private Kulection WorkingKulection;

        public ManageKulection(Kulection InCollection)
        {
            WorkingKulection = InCollection;

            InitializeComponent();

            LBLTitle.Text = WorkingKulection.KulectionName;
            PopulateItems();
        }

        // populate list items
        private void PopulateItems()
        {
            // loop over each kulection item
            foreach (KulectionItem Item in WorkingKulection.KulectionItems)
            {
                // add entry to list (name, desc, guid, quantity)
                DGVItems.Rows.Add(Item.ItemName, Item.ItemDescription, Item.ItemId.ToString(), Item.ItemQuantity);
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
                WorkingKulection.AddItem((string)Row.Cells[0].Value, (string)Row.Cells[1].Value, (int)Row.Cells[3].Value, new Guid((string)Row.Cells[2].Value));
            }
        }

        // save kulection out to file
        private void BTNSave_Click(object sender, EventArgs e)
        {
            // KulectionSerialization.WriteKulectionFile("./TEST.kul", WorkingKulection);

            SaveToWorking();

            // Show the dialog
            SfdCreateKul.ShowDialog();

            // Create a Kulection
            KulectionSerialization.WriteKulectionFile(SfdCreateKul.FileName, WorkingKulection);
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            DGVItems.Rows.Add("Temp Name", "Temp Desc", new Guid().ToString(), 16);
        }

        private void BTNRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in DGVItems.Rows)
            {
                foreach (DataGridViewCell Cell in Row.Cells)
                {
                    if (Cell.Selected)
                    {
                        DGVItems.Rows.RemoveAt(Cell.RowIndex);
                    }
                }
            }
        }
    }
}
