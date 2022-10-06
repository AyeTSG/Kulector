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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVItems = new System.Windows.Forms.DataGridView();
            this.ClmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmDescrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.BTNSave = new System.Windows.Forms.Button();
            this.BTNAdd = new System.Windows.Forms.Button();
            this.BTNRemove = new System.Windows.Forms.Button();
            this.TLPEditButtons = new System.Windows.Forms.TableLayoutPanel();
            this.BtnRenameKul = new System.Windows.Forms.Button();
            this.SfdCreateKul = new System.Windows.Forms.SaveFileDialog();
            this.PNLTitle = new System.Windows.Forms.Panel();
            this.LBLTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).BeginInit();
            this.TLPEditButtons.SuspendLayout();
            this.PNLTitle.SuspendLayout();
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
            this.ClmnQuantity,
            this.Image});
            this.DGVItems.Location = new System.Drawing.Point(14, 13);
            this.DGVItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGVItems.Name = "DGVItems";
            this.DGVItems.ReadOnly = true;
            this.DGVItems.RowHeadersVisible = false;
            this.DGVItems.RowHeadersWidth = 51;
            this.DGVItems.RowTemplate.Height = 25;
            this.DGVItems.Size = new System.Drawing.Size(886, 488);
            this.DGVItems.TabIndex = 0;
            this.DGVItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVItems_CellDoubleClick);
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
            // ClmnQuantity
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.ClmnQuantity.DefaultCellStyle = dataGridViewCellStyle1;
            this.ClmnQuantity.HeaderText = "Quantity";
            this.ClmnQuantity.MinimumWidth = 6;
            this.ClmnQuantity.Name = "ClmnQuantity";
            this.ClmnQuantity.ReadOnly = true;
            // 
            // Image
            // 
            this.Image.HeaderText = "Image";
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Visible = false;
            // 
            // BTNSave
            // 
            this.BTNSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNSave.Location = new System.Drawing.Point(666, 4);
            this.BTNSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTNSave.Name = "BTNSave";
            this.BTNSave.Size = new System.Drawing.Size(217, 44);
            this.BTNSave.TabIndex = 2;
            this.BTNSave.Text = "Save Kulection";
            this.BTNSave.UseVisualStyleBackColor = true;
            this.BTNSave.Click += new System.EventHandler(this.BTNSave_Click);
            // 
            // BTNAdd
            // 
            this.BTNAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNAdd.Location = new System.Drawing.Point(3, 4);
            this.BTNAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.Size = new System.Drawing.Size(215, 44);
            this.BTNAdd.TabIndex = 3;
            this.BTNAdd.Text = "Add Item";
            this.BTNAdd.UseVisualStyleBackColor = true;
            this.BTNAdd.Click += new System.EventHandler(this.BTNAdd_Click);
            // 
            // BTNRemove
            // 
            this.BTNRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNRemove.Location = new System.Drawing.Point(224, 4);
            this.BTNRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTNRemove.Name = "BTNRemove";
            this.BTNRemove.Size = new System.Drawing.Size(215, 44);
            this.BTNRemove.TabIndex = 4;
            this.BTNRemove.Text = "Remove Item";
            this.BTNRemove.UseVisualStyleBackColor = true;
            this.BTNRemove.Click += new System.EventHandler(this.BTNRemove_Click);
            // 
            // TLPEditButtons
            // 
            this.TLPEditButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TLPEditButtons.ColumnCount = 4;
            this.TLPEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLPEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLPEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLPEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLPEditButtons.Controls.Add(this.BtnRenameKul, 2, 0);
            this.TLPEditButtons.Controls.Add(this.BTNAdd, 0, 0);
            this.TLPEditButtons.Controls.Add(this.BTNSave, 3, 0);
            this.TLPEditButtons.Controls.Add(this.BTNRemove, 1, 0);
            this.TLPEditButtons.Location = new System.Drawing.Point(14, 544);
            this.TLPEditButtons.Name = "TLPEditButtons";
            this.TLPEditButtons.RowCount = 1;
            this.TLPEditButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPEditButtons.Size = new System.Drawing.Size(886, 52);
            this.TLPEditButtons.TabIndex = 5;
            // 
            // BtnRenameKul
            // 
            this.BtnRenameKul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRenameKul.Location = new System.Drawing.Point(445, 4);
            this.BtnRenameKul.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnRenameKul.Name = "BtnRenameKul";
            this.BtnRenameKul.Size = new System.Drawing.Size(215, 44);
            this.BtnRenameKul.TabIndex = 7;
            this.BtnRenameKul.Text = "Rename Kulection";
            this.BtnRenameKul.UseVisualStyleBackColor = true;
            this.BtnRenameKul.Click += new System.EventHandler(this.BtnRenameKul_Click);
            // 
            // SfdCreateKul
            // 
            this.SfdCreateKul.DefaultExt = "kul";
            this.SfdCreateKul.Filter = "Kulections|*.kul";
            // 
            // PNLTitle
            // 
            this.PNLTitle.Controls.Add(this.LBLTitle);
            this.PNLTitle.Location = new System.Drawing.Point(14, 504);
            this.PNLTitle.Name = "PNLTitle";
            this.PNLTitle.Size = new System.Drawing.Size(883, 37);
            this.PNLTitle.TabIndex = 6;
            // 
            // LBLTitle
            // 
            this.LBLTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBLTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLTitle.Location = new System.Drawing.Point(0, 0);
            this.LBLTitle.Name = "LBLTitle";
            this.LBLTitle.Size = new System.Drawing.Size(883, 37);
            this.LBLTitle.TabIndex = 0;
            this.LBLTitle.Text = "[ KUL TITLE ]";
            this.LBLTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageKulection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 605);
            this.Controls.Add(this.PNLTitle);
            this.Controls.Add(this.TLPEditButtons);
            this.Controls.Add(this.DGVItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageKulection";
            this.Text = "Kulector - Kulection Manager";
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).EndInit();
            this.TLPEditButtons.ResumeLayout(false);
            this.PNLTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DataGridView DGVItems;
        private Button BTNSave;
        private Button BTNAdd;
        private Button BTNRemove;
        private TableLayoutPanel TLPEditButtons;
        private SaveFileDialog SfdCreateKul;
        private Panel PNLTitle;
        public Label LBLTitle;
        private DataGridViewTextBoxColumn ClmName;
        private DataGridViewTextBoxColumn ClmDescrip;
        private DataGridViewTextBoxColumn ClmnQuantity;
        private DataGridViewImageColumn Image;
        private Button BtnRenameKul;
    }
}