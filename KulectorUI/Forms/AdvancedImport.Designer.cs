namespace KulectorUI.Forms
{
    partial class AdvancedImport
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
            this.BtnDiscogsCsv = new System.Windows.Forms.Button();
            this.OfdDiscogs = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblSubtitle
            // 
            this.LblSubtitle.AutoSize = true;
            this.LblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSubtitle.Location = new System.Drawing.Point(64, 55);
            this.LblSubtitle.Name = "LblSubtitle";
            this.LblSubtitle.Size = new System.Drawing.Size(180, 46);
            this.LblSubtitle.TabIndex = 7;
            this.LblSubtitle.Text = "Want to import data\r\nfrom somewhere else?\r\n";
            this.LblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.Location = new System.Drawing.Point(13, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(279, 46);
            this.LblTitle.TabIndex = 6;
            this.LblTitle.Text = "Advanced Import";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BtnDiscogsCsv, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 146);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(279, 64);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // BtnDiscogsCsv
            // 
            this.BtnDiscogsCsv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDiscogsCsv.Location = new System.Drawing.Point(3, 3);
            this.BtnDiscogsCsv.Name = "BtnDiscogsCsv";
            this.BtnDiscogsCsv.Size = new System.Drawing.Size(273, 58);
            this.BtnDiscogsCsv.TabIndex = 0;
            this.BtnDiscogsCsv.Text = "Discogs Collection (.csv)";
            this.BtnDiscogsCsv.UseVisualStyleBackColor = true;
            this.BtnDiscogsCsv.Click += new System.EventHandler(this.BtnDiscogsCsv_Click);
            // 
            // OfdDiscogs
            // 
            this.OfdDiscogs.DefaultExt = "csv";
            this.OfdDiscogs.FileName = "Discogs CSV";
            this.OfdDiscogs.Filter = "Discogs Collections|*.csv";
            // 
            // AdvancedImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 259);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.LblSubtitle);
            this.Controls.Add(this.LblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdvancedImport";
            this.Text = "Kulector - Advanced Import";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblSubtitle;
        private Label LblTitle;
        private TableLayoutPanel tableLayoutPanel1;
        private Button BtnDiscogsCsv;
        private OpenFileDialog OfdDiscogs;
    }
}