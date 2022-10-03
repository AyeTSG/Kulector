namespace KulectorUI.Forms
{
    partial class ManageKulection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGVItems = new System.Windows.Forms.DataGridView();
            this.ClmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RTBDesc = new System.Windows.Forms.RichTextBox();
            this.BTNSave = new System.Windows.Forms.Button();
            this.BTNAdd = new System.Windows.Forms.Button();
            this.BTNRemove = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBLItemName = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVItems
            // 
            this.DGVItems.AllowUserToAddRows = false;
            this.DGVItems.AllowUserToDeleteRows = false;
            this.DGVItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmName,
            this.ClmnQuantity});
            this.DGVItems.Location = new System.Drawing.Point(12, 12);
            this.DGVItems.Name = "DGVItems";
            this.DGVItems.ReadOnly = true;
            this.DGVItems.RowHeadersVisible = false;
            this.DGVItems.RowTemplate.Height = 25;
            this.DGVItems.Size = new System.Drawing.Size(454, 391);
            this.DGVItems.TabIndex = 0;
            // 
            // ClmName
            // 
            this.ClmName.HeaderText = "Name";
            this.ClmName.Name = "ClmName";
            this.ClmName.ReadOnly = true;
            // 
            // ClmnQuantity
            // 
            this.ClmnQuantity.HeaderText = "Quantity";
            this.ClmnQuantity.Name = "ClmnQuantity";
            this.ClmnQuantity.ReadOnly = true;
            // 
            // RTBDesc
            // 
            this.RTBDesc.Location = new System.Drawing.Point(472, 86);
            this.RTBDesc.Name = "RTBDesc";
            this.RTBDesc.Size = new System.Drawing.Size(316, 284);
            this.RTBDesc.TabIndex = 1;
            this.RTBDesc.Text = "";
            // 
            // BTNSave
            // 
            this.BTNSave.Location = new System.Drawing.Point(472, 409);
            this.BTNSave.Name = "BTNSave";
            this.BTNSave.Size = new System.Drawing.Size(316, 29);
            this.BTNSave.TabIndex = 2;
            this.BTNSave.Text = "Save";
            this.BTNSave.UseVisualStyleBackColor = true;
            // 
            // BTNAdd
            // 
            this.BTNAdd.Location = new System.Drawing.Point(12, 409);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.Size = new System.Drawing.Size(219, 29);
            this.BTNAdd.TabIndex = 3;
            this.BTNAdd.Text = "Add Item";
            this.BTNAdd.UseVisualStyleBackColor = true;
            // 
            // BTNRemove
            // 
            this.BTNRemove.Location = new System.Drawing.Point(246, 409);
            this.BTNRemove.Name = "BTNRemove";
            this.BTNRemove.Size = new System.Drawing.Size(220, 29);
            this.BTNRemove.TabIndex = 4;
            this.BTNRemove.Text = "Remove Item";
            this.BTNRemove.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LBLItemName);
            this.panel1.Location = new System.Drawing.Point(472, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 68);
            this.panel1.TabIndex = 6;
            // 
            // LBLItemName
            // 
            this.LBLItemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBLItemName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LBLItemName.Location = new System.Drawing.Point(0, 0);
            this.LBLItemName.Name = "LBLItemName";
            this.LBLItemName.Size = new System.Drawing.Size(316, 68);
            this.LBLItemName.TabIndex = 5;
            this.LBLItemName.Text = "[ Item Name ]";
            this.LBLItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(472, 376);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(316, 23);
            this.numericUpDown1.TabIndex = 7;
            // 
            // ManageKulection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTNRemove);
            this.Controls.Add(this.BTNAdd);
            this.Controls.Add(this.BTNSave);
            this.Controls.Add(this.RTBDesc);
            this.Controls.Add(this.DGVItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageKulection";
            this.Text = "ManageKulection";
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DGVItems;
        private DataGridViewTextBoxColumn ClmName;
        private DataGridViewTextBoxColumn ClmnQuantity;
        private RichTextBox RTBDesc;
        private Button BTNSave;
        private Button BTNAdd;
        private Button BTNRemove;
        private Panel panel1;
        private Label LBLItemName;
        private NumericUpDown numericUpDown1;
    }
}