namespace valaya_vedan
{
    partial class RootForm
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
            this.readImagePDFBtn = new System.Windows.Forms.Button();
            this.readTextPDFBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readImagePDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readTextPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openHelpFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readImageBtn = new System.Windows.Forms.Button();
            this.readImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // readImagePDFBtn
            // 
            this.readImagePDFBtn.Location = new System.Drawing.Point(67, 115);
            this.readImagePDFBtn.Name = "readImagePDFBtn";
            this.readImagePDFBtn.Size = new System.Drawing.Size(143, 49);
            this.readImagePDFBtn.TabIndex = 1;
            this.readImagePDFBtn.Text = "Read Image PDF";
            this.readImagePDFBtn.UseVisualStyleBackColor = true;
            this.readImagePDFBtn.Click += new System.EventHandler(this.readImagePDFBtn_Click);
            // 
            // readTextPDFBtn
            // 
            this.readTextPDFBtn.Location = new System.Drawing.Point(67, 188);
            this.readTextPDFBtn.Name = "readTextPDFBtn";
            this.readTextPDFBtn.Size = new System.Drawing.Size(143, 48);
            this.readTextPDFBtn.TabIndex = 2;
            this.readTextPDFBtn.Text = "Read Text PDF";
            this.readTextPDFBtn.UseVisualStyleBackColor = true;
            this.readTextPDFBtn.Click += new System.EventHandler(this.readTextPDFBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readImageToolStripMenuItem,
            this.readImagePDFToolStripMenuItem,
            this.readTextPDFToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // readImagePDFToolStripMenuItem
            // 
            this.readImagePDFToolStripMenuItem.Name = "readImagePDFToolStripMenuItem";
            this.readImagePDFToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.readImagePDFToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.readImagePDFToolStripMenuItem.Text = "Read Image PDF";
            this.readImagePDFToolStripMenuItem.Click += new System.EventHandler(this.readImagePDFToolStripMenuItem_Click);
            // 
            // readTextPDFToolStripMenuItem
            // 
            this.readTextPDFToolStripMenuItem.Name = "readTextPDFToolStripMenuItem";
            this.readTextPDFToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.readTextPDFToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.readTextPDFToolStripMenuItem.Text = "Read Text PDF";
            this.readTextPDFToolStripMenuItem.Click += new System.EventHandler(this.readTextPDFToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openHelpFileToolStripMenuItem,
            this.helpToolStripMenuItem1,
            this.aboutUsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // openHelpFileToolStripMenuItem
            // 
            this.openHelpFileToolStripMenuItem.Name = "openHelpFileToolStripMenuItem";
            this.openHelpFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.openHelpFileToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.openHelpFileToolStripMenuItem.Text = "Open Help File";
            this.openHelpFileToolStripMenuItem.Click += new System.EventHandler(this.openHelpFileToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // readImageBtn
            // 
            this.readImageBtn.Location = new System.Drawing.Point(67, 38);
            this.readImageBtn.Name = "readImageBtn";
            this.readImageBtn.Size = new System.Drawing.Size(143, 49);
            this.readImageBtn.TabIndex = 0;
            this.readImageBtn.Text = "Read from Image";
            this.readImageBtn.UseVisualStyleBackColor = true;
            this.readImageBtn.Click += new System.EventHandler(this.readImageBtn_Click);
            // 
            // readImageToolStripMenuItem
            // 
            this.readImageToolStripMenuItem.Name = "readImageToolStripMenuItem";
            this.readImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.readImageToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.readImageToolStripMenuItem.Text = "Read Image";
            this.readImageToolStripMenuItem.Click += new System.EventHandler(this.readImageToolStripMenuItem_Click);
            // 
            // RootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.readImageBtn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.readTextPDFBtn);
            this.Controls.Add(this.readImagePDFBtn);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RootForm";
            this.Text = "Valaya Vedan";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.RootForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.RootForm_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readImagePDFBtn;
        private System.Windows.Forms.Button readTextPDFBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openHelpFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readImagePDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readTextPDFToolStripMenuItem;
        private System.Windows.Forms.Button readImageBtn;
        private System.Windows.Forms.ToolStripMenuItem readImageToolStripMenuItem;
    }
}