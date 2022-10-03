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
            this.RTBDesc = new System.Windows.Forms.RichTextBox();
            this.BTNSave = new System.Windows.Forms.Button();
            this.BTNAdd = new System.Windows.Forms.Button();
            this.BTNRemove = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBLItemName = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ClmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmDescrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ClmDescrip,
            this.ClmGuid,
            this.ClmnQuantity});
            this.DGVItems.Location = new System.Drawing.Point(14, 16);
            this.DGVItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGVItems.Name = "DGVItems";
            this.DGVItems.ReadOnly = true;
            this.DGVItems.RowHeadersVisible = false;
            this.DGVItems.RowHeadersWidth = 51;
            this.DGVItems.RowTemplate.Height = 25;
            this.DGVItems.Size = new System.Drawing.Size(519, 521);
            this.DGVItems.TabIndex = 0;
            // 
            // RTBDesc
            // 
            this.RTBDesc.DetectUrls = false;
            this.RTBDesc.Enabled = false;
            this.RTBDesc.Location = new System.Drawing.Point(539, 115);
            this.RTBDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RTBDesc.Name = "RTBDesc";
            this.RTBDesc.Size = new System.Drawing.Size(361, 377);
            this.RTBDesc.TabIndex = 1;
            this.RTBDesc.Text = "";
            // 
            // BTNSave
            // 
            this.BTNSave.Location = new System.Drawing.Point(539, 545);
            this.BTNSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTNSave.Name = "BTNSave";
            this.BTNSave.Size = new System.Drawing.Size(361, 39);
            this.BTNSave.TabIndex = 2;
            this.BTNSave.Text = "Save";
            this.BTNSave.UseVisualStyleBackColor = true;
            // 
            // BTNAdd
            // 
            this.BTNAdd.Location = new System.Drawing.Point(14, 545);
            this.BTNAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.Size = new System.Drawing.Size(250, 39);
            this.BTNAdd.TabIndex = 3;
            this.BTNAdd.Text = "Add Item";
            this.BTNAdd.UseVisualStyleBackColor = true;
            // 
            // BTNRemove
            // 
            this.BTNRemove.Location = new System.Drawing.Point(281, 545);
            this.BTNRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTNRemove.Name = "BTNRemove";
            this.BTNRemove.Size = new System.Drawing.Size(251, 39);
            this.BTNRemove.TabIndex = 4;
            this.BTNRemove.Text = "Remove Item";
            this.BTNRemove.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LBLItemName);
            this.panel1.Location = new System.Drawing.Point(539, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 91);
            this.panel1.TabIndex = 6;
            // 
            // LBLItemName
            // 
            this.LBLItemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBLItemName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LBLItemName.Location = new System.Drawing.Point(0, 0);
            this.LBLItemName.Name = "LBLItemName";
            this.LBLItemName.Size = new System.Drawing.Size(361, 91);
            this.LBLItemName.TabIndex = 5;
            this.LBLItemName.Text = "No Item Selected";
            this.LBLItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(539, 504);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(361, 27);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ClmName
            // 
            this.ClmName.HeaderText = "Name";
            this.ClmName.MinimumWidth = 6;
            this.ClmName.Name = "ClmName";
            this.ClmName.ReadOnly = true;
            // 
            // ClmDescrip
            // 
            this.ClmDescrip.HeaderText = "Description";
            this.ClmDescrip.MinimumWidth = 6;
            this.ClmDescrip.Name = "ClmDescrip";
            this.ClmDescrip.ReadOnly = true;
            this.ClmDescrip.Visible = false;
            // 
            // ClmGuid
            // 
            this.ClmGuid.HeaderText = "GUID";
            this.ClmGuid.MinimumWidth = 6;
            this.ClmGuid.Name = "ClmGuid";
            this.ClmGuid.ReadOnly = true;
            this.ClmGuid.Visible = false;
            // 
            // ClmnQuantity
            // 
            this.ClmnQuantity.HeaderText = "Quantity";
            this.ClmnQuantity.MinimumWidth = 6;
            this.ClmnQuantity.Name = "ClmnQuantity";
            this.ClmnQuantity.ReadOnly = true;
            // 
            // ManageKulection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTNRemove);
            this.Controls.Add(this.BTNAdd);
            this.Controls.Add(this.BTNSave);
            this.Controls.Add(this.RTBDesc);
            this.Controls.Add(this.DGVItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageKulection";
            this.Text = "Kulector - Manage Kulection";
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DGVItems;
        private RichTextBox RTBDesc;
        private Button BTNSave;
        private Button BTNAdd;
        private Button BTNRemove;
        private Panel panel1;
        private Label LBLItemName;
        private NumericUpDown numericUpDown1;
        private DataGridViewTextBoxColumn ClmName;
        private DataGridViewTextBoxColumn ClmDescrip;
        private DataGridViewTextBoxColumn ClmGuid;
        private DataGridViewTextBoxColumn ClmnQuantity;
    }
}