namespace KulectorUI.Forms
{
    partial class RenameKul
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

            this.LblTitle = new System.Windows.Forms.Label();
            this.LblSubtitle = new System.Windows.Forms.Label();
            this.TbCollectionName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRename = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.Location = new System.Drawing.Point(12, 18);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(289, 46);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "Rename Kulection";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSubtitle
            // 
            this.LblSubtitle.AutoSize = true;
            this.LblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSubtitle.Location = new System.Drawing.Point(55, 64);
            this.LblSubtitle.Name = "LblSubtitle";
            this.LblSubtitle.Size = new System.Drawing.Size(196, 46);
            this.LblSubtitle.TabIndex = 3;
            this.LblSubtitle.Text = "Not happy with the\r\nname of your Kulection?\r\n";
            this.LblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbCollectionName
            // 
            this.TbCollectionName.Location = new System.Drawing.Point(69, 167);
            this.TbCollectionName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbCollectionName.Name = "TbCollectionName";
            this.TbCollectionName.Size = new System.Drawing.Size(230, 27);
            this.TbCollectionName.TabIndex = 4;
            this.TbCollectionName.Text = "New Collection";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // BtnRename
            // 
            this.BtnRename.Location = new System.Drawing.Point(81, 218);
            this.BtnRename.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnRename.Name = "BtnRename";
            this.BtnRename.Size = new System.Drawing.Size(150, 30);
            this.BtnRename.TabIndex = 6;
            this.BtnRename.Text = "Rename Kulection";
            this.BtnRename.UseVisualStyleBackColor = true;
            this.BtnRename.Click += new System.EventHandler(this.BtnRename_Click);
            // 
            // RenameKul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 272);
            this.Controls.Add(this.BtnRename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbCollectionName);
            this.Controls.Add(this.LblSubtitle);
            this.Controls.Add(this.LblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RenameKul";
            this.Text = "Kulector - Rename Kulection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label LblTitle;
        private Label LblSubtitle;
        private TextBox TbCollectionName;
        private Label label1;
        private Button BtnRename;
    }
}