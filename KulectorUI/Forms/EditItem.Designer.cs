namespace KulectorUI.Forms
{
    partial class EditItem
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
            this.TLPRight = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TLPBottomRight = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCancelEditing = new System.Windows.Forms.Button();
            this.BtnSaveItem = new System.Windows.Forms.Button();
            this.TLPMaster = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblGuid = new System.Windows.Forms.Label();
            this.TLPRight.SuspendLayout();
            this.TLPBottomRight.SuspendLayout();
            this.TLPMaster.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPRight
            // 
            this.TLPRight.ColumnCount = 1;
            this.TLPRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPRight.Controls.Add(this.TLPBottomRight, 0, 1);
            this.TLPRight.Controls.Add(this.richTextBox1, 0, 0);
            this.TLPRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPRight.Location = new System.Drawing.Point(483, 3);
            this.TLPRight.Name = "TLPRight";
            this.TLPRight.RowCount = 2;
            this.TLPRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TLPRight.Size = new System.Drawing.Size(317, 467);
            this.TLPRight.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(311, 401);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // TLPBottomRight
            // 
            this.TLPBottomRight.ColumnCount = 2;
            this.TLPBottomRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPBottomRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPBottomRight.Controls.Add(this.BtnSaveItem, 1, 0);
            this.TLPBottomRight.Controls.Add(this.BtnCancelEditing, 0, 0);
            this.TLPBottomRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPBottomRight.Location = new System.Drawing.Point(3, 410);
            this.TLPBottomRight.Name = "TLPBottomRight";
            this.TLPBottomRight.RowCount = 1;
            this.TLPBottomRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPBottomRight.Size = new System.Drawing.Size(311, 54);
            this.TLPBottomRight.TabIndex = 0;
            // 
            // BtnCancelEditing
            // 
            this.BtnCancelEditing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancelEditing.Location = new System.Drawing.Point(3, 3);
            this.BtnCancelEditing.Name = "BtnCancelEditing";
            this.BtnCancelEditing.Size = new System.Drawing.Size(149, 48);
            this.BtnCancelEditing.TabIndex = 1;
            this.BtnCancelEditing.Text = "Cancel";
            this.BtnCancelEditing.UseVisualStyleBackColor = true;
            // 
            // BtnSaveItem
            // 
            this.BtnSaveItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSaveItem.Location = new System.Drawing.Point(158, 3);
            this.BtnSaveItem.Name = "BtnSaveItem";
            this.BtnSaveItem.Size = new System.Drawing.Size(150, 48);
            this.BtnSaveItem.TabIndex = 0;
            this.BtnSaveItem.Text = "Save Item";
            this.BtnSaveItem.UseVisualStyleBackColor = true;
            // 
            // TLPMaster
            // 
            this.TLPMaster.ColumnCount = 2;
            this.TLPMaster.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.89651F));
            this.TLPMaster.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.10349F));
            this.TLPMaster.Controls.Add(this.TLPRight, 1, 0);
            this.TLPMaster.Controls.Add(this.panel1, 0, 0);
            this.TLPMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPMaster.Location = new System.Drawing.Point(0, 0);
            this.TLPMaster.Name = "TLPMaster";
            this.TLPMaster.RowCount = 1;
            this.TLPMaster.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPMaster.Size = new System.Drawing.Size(803, 473);
            this.TLPMaster.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblGuid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 467);
            this.panel1.TabIndex = 1;
            // 
            // LblGuid
            // 
            this.LblGuid.AutoSize = true;
            this.LblGuid.Location = new System.Drawing.Point(9, 39);
            this.LblGuid.Name = "LblGuid";
            this.LblGuid.Size = new System.Drawing.Size(191, 20);
            this.LblGuid.TabIndex = 0;
            this.LblGuid.Text = "GUID: [xxxx-xxxx-xxxx-xxxx]";
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 473);
            this.Controls.Add(this.TLPMaster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditItem";
            this.Text = "Kulector - Item Editor";
            this.TLPRight.ResumeLayout(false);
            this.TLPBottomRight.ResumeLayout(false);
            this.TLPMaster.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TLPRight;
        private TableLayoutPanel TLPBottomRight;
        private Button BtnSaveItem;
        private Button BtnCancelEditing;
        private RichTextBox richTextBox1;
        private TableLayoutPanel TLPMaster;
        private Panel panel1;
        private Label LblGuid;
    }
}