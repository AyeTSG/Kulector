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
            this.SuspendLayout();
            // 
            // LblSubtitle
            // 
            this.LblSubtitle.AutoSize = true;
            this.LblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSubtitle.Location = new System.Drawing.Point(58, 55);
            this.LblSubtitle.Name = "LblSubtitle";
            this.LblSubtitle.Size = new System.Drawing.Size(174, 69);
            this.LblSubtitle.TabIndex = 5;
            this.LblSubtitle.Text = "Kulector is made with\r\n     by AyeTSG\r\n\r\n";
            this.LblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.Location = new System.Drawing.Point(89, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(113, 46);
            this.LblTitle.TabIndex = 4;
            this.LblTitle.Text = "About";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 260);
            this.Controls.Add(this.LblSubtitle);
            this.Controls.Add(this.LblTitle);
            this.Icon = global::KulectorUI.Properties.Resources.MainIcon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Text = "Kulector - About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblSubtitle;
        private Label LblTitle;
    }
}