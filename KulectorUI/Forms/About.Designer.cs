namespace KulectorUI.Forms
{
    partial class About
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblUiVer = new System.Windows.Forms.Label();
            this.LblExternalApiVer = new System.Windows.Forms.Label();
            this.LblExporterVer = new System.Windows.Forms.Label();
            this.LblDbVer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblSubtitle
            // 
            this.LblSubtitle.AutoSize = true;
            this.LblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSubtitle.Location = new System.Drawing.Point(47, 55);
            this.LblSubtitle.Name = "LblSubtitle";
            this.LblSubtitle.Size = new System.Drawing.Size(216, 276);
            this.LblSubtitle.TabIndex = 5;
            this.LblSubtitle.Text = "Kulector is made with\r\n     by AyeTSG\r\n\r\n\r\nThis project utilizes other\r\nopen sour" +
    "ce software.\r\nThis list can be seen below.\r\n\r\nDiscogs API\r\nNewtonsoft.JSON\r\nTwem" +
    "oji\r\n\r\n";
            this.LblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.Location = new System.Drawing.Point(96, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(113, 46);
            this.LblTitle.TabIndex = 4;
            this.LblTitle.Text = "About";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KulectorUI.Properties.Resources.Heart;
            this.pictureBox1.Location = new System.Drawing.Point(95, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LblUiVer
            // 
            this.LblUiVer.AutoSize = true;
            this.LblUiVer.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblUiVer.Location = new System.Drawing.Point(12, 392);
            this.LblUiVer.Name = "LblUiVer";
            this.LblUiVer.Size = new System.Drawing.Size(97, 17);
            this.LblUiVer.TabIndex = 7;
            this.LblUiVer.Text = "KulectorUI vX.X";
            // 
            // LblExternalApiVer
            // 
            this.LblExternalApiVer.AutoSize = true;
            this.LblExternalApiVer.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblExternalApiVer.Location = new System.Drawing.Point(12, 375);
            this.LblExternalApiVer.Name = "LblExternalApiVer";
            this.LblExternalApiVer.Size = new System.Drawing.Size(156, 17);
            this.LblExternalApiVer.TabIndex = 8;
            this.LblExternalApiVer.Text = "KulectorExternalApis vX.X";
            // 
            // LblExporterVer
            // 
            this.LblExporterVer.AutoSize = true;
            this.LblExporterVer.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblExporterVer.Location = new System.Drawing.Point(12, 358);
            this.LblExporterVer.Name = "LblExporterVer";
            this.LblExporterVer.Size = new System.Drawing.Size(135, 17);
            this.LblExporterVer.TabIndex = 9;
            this.LblExporterVer.Text = "KulectorExporter vX.X";
            // 
            // LblDbVer
            // 
            this.LblDbVer.AutoSize = true;
            this.LblDbVer.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDbVer.Location = new System.Drawing.Point(12, 341);
            this.LblDbVer.Name = "LblDbVer";
            this.LblDbVer.Size = new System.Drawing.Size(101, 17);
            this.LblDbVer.TabIndex = 10;
            this.LblDbVer.Text = "KulectorDB vX.X";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 418);
            this.Controls.Add(this.LblDbVer);
            this.Controls.Add(this.LblExporterVer);
            this.Controls.Add(this.LblExternalApiVer);
            this.Controls.Add(this.LblUiVer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblSubtitle);
            this.Controls.Add(this.LblTitle);
            this.Icon = global::KulectorUI.Properties.Resources.MainIcon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Text = "Kulector - About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblSubtitle;
        private Label LblTitle;
        private PictureBox pictureBox1;
        private Label LblUiVer;
        private Label LblExternalApiVer;
        private Label LblExporterVer;
        private Label LblDbVer;
    }
}