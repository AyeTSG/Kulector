namespace KulectorUI.Forms
{
    partial class Greeting
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
            this.Icon = KulectorUI.Properties.Resources.MainIcon;

            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblSubtitle = new System.Windows.Forms.Label();
            this.LblDbVer = new System.Windows.Forms.Label();
            this.LblUiVer = new System.Windows.Forms.Label();
            this.SfdCreateKul = new System.Windows.Forms.SaveFileDialog();
            this.OfdOpenKul = new System.Windows.Forms.OpenFileDialog();
            this.BtnAdvanceImport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(79, 121);
            this.BtnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(150, 31);
            this.BtnCreate.TabIndex = 0;
            this.BtnCreate.Text = "Create a Kulection";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(79, 160);
            this.BtnOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(150, 31);
            this.BtnOpen.TabIndex = 1;
            this.BtnOpen.Text = "Open a Kulection";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.Location = new System.Drawing.Point(84, 21);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(145, 46);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "Kulector";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSubtitle
            // 
            this.LblSubtitle.AutoSize = true;
            this.LblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSubtitle.Location = new System.Drawing.Point(87, 64);
            this.LblSubtitle.Name = "LblSubtitle";
            this.LblSubtitle.Size = new System.Drawing.Size(137, 46);
            this.LblSubtitle.TabIndex = 3;
            this.LblSubtitle.Text = "Collect what you\r\ncare about";
            this.LblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblDbVer
            // 
            this.LblDbVer.AutoSize = true;
            this.LblDbVer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDbVer.Location = new System.Drawing.Point(14, 272);
            this.LblDbVer.Name = "LblDbVer";
            this.LblDbVer.Size = new System.Drawing.Size(113, 19);
            this.LblDbVer.TabIndex = 4;
            this.LblDbVer.Text = "KulectionDB vX,X";
            // 
            // LblUiVer
            // 
            this.LblUiVer.AutoSize = true;
            this.LblUiVer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblUiVer.Location = new System.Drawing.Point(14, 255);
            this.LblUiVer.Name = "LblUiVer";
            this.LblUiVer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblUiVer.Size = new System.Drawing.Size(109, 19);
            this.LblUiVer.TabIndex = 5;
            this.LblUiVer.Text = "KulectionUI vX,X";
            // 
            // SfdCreateKul
            // 
            this.SfdCreateKul.DefaultExt = "kul";
            this.SfdCreateKul.Filter = "Kulections|*.kul";
            // 
            // OfdOpenKul
            // 
            this.OfdOpenKul.DefaultExt = "kul";
            this.OfdOpenKul.Filter = "Kulections|*.kul";
            // 
            // BtnAdvanceImport
            // 
            this.BtnAdvanceImport.Location = new System.Drawing.Point(79, 199);
            this.BtnAdvanceImport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAdvanceImport.Name = "BtnAdvanceImport";
            this.BtnAdvanceImport.Size = new System.Drawing.Size(150, 31);
            this.BtnAdvanceImport.TabIndex = 6;
            this.BtnAdvanceImport.Text = "Advanced Import";
            this.BtnAdvanceImport.UseVisualStyleBackColor = true;
            this.BtnAdvanceImport.Click += new System.EventHandler(this.BtnAdvanceImport_Click);
            // 
            // Greeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 301);
            this.Controls.Add(this.BtnAdvanceImport);
            this.Controls.Add(this.LblUiVer);
            this.Controls.Add(this.LblDbVer);
            this.Controls.Add(this.LblSubtitle);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.BtnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Greeting";
            this.Text = "Kulector - Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnCreate;
        private Button BtnOpen;
        private Label LblTitle;
        private Label LblSubtitle;
        private Label LblDbVer;
        private Label LblUiVer;
        private SaveFileDialog SfdCreateKul;
        private OpenFileDialog OfdOpenKul;
        private Button BtnAdvanceImport;
    }
}