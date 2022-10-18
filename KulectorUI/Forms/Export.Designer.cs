namespace KulectorUI.Forms
{
    partial class Export
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
            this.LblSubtitle = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnTextFile = new System.Windows.Forms.Button();
            this.SfdExportTxt = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblSubtitle
            // 
            this.LblSubtitle.AutoSize = true;
            this.LblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSubtitle.Location = new System.Drawing.Point(38, 55);
            this.LblSubtitle.Name = "LblSubtitle";
            this.LblSubtitle.Size = new System.Drawing.Size(219, 115);
            this.LblSubtitle.TabIndex = 7;
            this.LblSubtitle.Text = "Want to export your\r\nKulection elsewhere?\r\n\r\nNOTE: Window may appear\r\nto freeze u" +
    "pon data export\r\n";
            this.LblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.Location = new System.Drawing.Point(87, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(117, 46);
            this.LblTitle.TabIndex = 6;
            this.LblTitle.Text = "Export";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BtnTextFile, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 200);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(279, 64);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // BtnTextFile
            // 
            this.BtnTextFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnTextFile.Location = new System.Drawing.Point(3, 3);
            this.BtnTextFile.Name = "BtnTextFile";
            this.BtnTextFile.Size = new System.Drawing.Size(273, 58);
            this.BtnTextFile.TabIndex = 0;
            this.BtnTextFile.Text = "Text File (.txt)";
            this.BtnTextFile.UseVisualStyleBackColor = true;
            this.BtnTextFile.Click += new System.EventHandler(this.BtnTextFile_Click);
            // 
            // SfdExportTxt
            // 
            this.SfdExportTxt.DefaultExt = "kul";
            this.SfdExportTxt.Filter = "Text Files|*.txt";
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 275);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.LblSubtitle);
            this.Controls.Add(this.LblTitle);
            this.Icon = global::KulectorUI.Properties.Resources.MainIcon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Export";
            this.Text = "Kulector - Export";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblSubtitle;
        private Label LblTitle;
        private TableLayoutPanel tableLayoutPanel1;
        private Button BtnTextFile;
        private SaveFileDialog SfdExportTxt;
    }
}