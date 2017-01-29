namespace valaya_vedan
{
    partial class PDFImageExtractor_Form
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
            this.pageNumberUpDown = new System.Windows.Forms.NumericUpDown();
            this.firstPageNavBtn = new System.Windows.Forms.Button();
            this.lastPageNavBtn = new System.Windows.Forms.Button();
            this.pdfSourceText = new System.Windows.Forms.RichTextBox();
            this.pdfOutput = new System.Windows.Forms.RichTextBox();
            this.pdfSourceImage = new System.Windows.Forms.PictureBox();
            this.openFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.languageList = new System.Windows.Forms.ComboBox();
            this.extarctingMsg = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.meanConfidenceLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openHelpFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupJavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pageNumberUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfSourceImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageNumberUpDown
            // 
            this.pageNumberUpDown.Location = new System.Drawing.Point(531, 51);
            this.pageNumberUpDown.Name = "pageNumberUpDown";
            this.pageNumberUpDown.Size = new System.Drawing.Size(43, 20);
            this.pageNumberUpDown.TabIndex = 0;
            this.pageNumberUpDown.ValueChanged += new System.EventHandler(this.pageNumberUpDown1_ValueChanged);
            // 
            // firstPageNavBtn
            // 
            this.firstPageNavBtn.Location = new System.Drawing.Point(436, 43);
            this.firstPageNavBtn.Name = "firstPageNavBtn";
            this.firstPageNavBtn.Size = new System.Drawing.Size(78, 36);
            this.firstPageNavBtn.TabIndex = 1;
            this.firstPageNavBtn.Text = "First Page";
            this.firstPageNavBtn.UseVisualStyleBackColor = true;
            this.firstPageNavBtn.Click += new System.EventHandler(this.firstPageNavBtn_Click);
            // 
            // lastPageNavBtn
            // 
            this.lastPageNavBtn.Location = new System.Drawing.Point(602, 43);
            this.lastPageNavBtn.Name = "lastPageNavBtn";
            this.lastPageNavBtn.Size = new System.Drawing.Size(78, 36);
            this.lastPageNavBtn.TabIndex = 2;
            this.lastPageNavBtn.Text = "Last Page";
            this.lastPageNavBtn.UseVisualStyleBackColor = true;
            this.lastPageNavBtn.Click += new System.EventHandler(this.lastPageNavBtn_Click);
            // 
            // pdfSourceText
            // 
            this.pdfSourceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdfSourceText.Location = new System.Drawing.Point(11, 103);
            this.pdfSourceText.Margin = new System.Windows.Forms.Padding(2);
            this.pdfSourceText.Name = "pdfSourceText";
            this.pdfSourceText.Size = new System.Drawing.Size(358, 323);
            this.pdfSourceText.TabIndex = 3;
            this.pdfSourceText.Text = "";
            this.pdfSourceText.WordWrap = false;
            // 
            // pdfOutput
            // 
            this.pdfOutput.Font = new System.Drawing.Font("SaiIndira", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdfOutput.Location = new System.Drawing.Point(11, 103);
            this.pdfOutput.Margin = new System.Windows.Forms.Padding(2);
            this.pdfOutput.Name = "pdfOutput";
            this.pdfOutput.Size = new System.Drawing.Size(722, 323);
            this.pdfOutput.TabIndex = 4;
            this.pdfOutput.Text = "";
            this.pdfOutput.WordWrap = false;
            // 
            // pdfSourceImage
            // 
            this.pdfSourceImage.Location = new System.Drawing.Point(12, 103);
            this.pdfSourceImage.Name = "pdfSourceImage";
            this.pdfSourceImage.Size = new System.Drawing.Size(358, 167);
            this.pdfSourceImage.TabIndex = 5;
            this.pdfSourceImage.TabStop = false;
            this.pdfSourceImage.Visible = false;
            // 
            // openFile
            // 
            this.openFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.openFile.Location = new System.Drawing.Point(16, 36);
            this.openFile.Margin = new System.Windows.Forms.Padding(2);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(175, 49);
            this.openFile.TabIndex = 6;
            this.openFile.Text = "Open File";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Language(s):";
            // 
            // languageList
            // 
            this.languageList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageList.FormattingEnabled = true;
            this.languageList.Location = new System.Drawing.Point(210, 56);
            this.languageList.Margin = new System.Windows.Forms.Padding(2);
            this.languageList.Name = "languageList";
            this.languageList.Size = new System.Drawing.Size(163, 21);
            this.languageList.TabIndex = 22;
            // 
            // extarctingMsg
            // 
            this.extarctingMsg.AutoSize = true;
            this.extarctingMsg.Location = new System.Drawing.Point(11, 432);
            this.extarctingMsg.Name = "extarctingMsg";
            this.extarctingMsg.Size = new System.Drawing.Size(0, 13);
            this.extarctingMsg.TabIndex = 24;
            // 
            // meanConfidenceLabel
            // 
            this.meanConfidenceLabel.AutoSize = true;
            this.meanConfidenceLabel.Location = new System.Drawing.Point(644, 432);
            this.meanConfidenceLabel.Name = "meanConfidenceLabel";
            this.meanConfidenceLabel.Size = new System.Drawing.Size(0, 13);
            this.meanConfidenceLabel.TabIndex = 25;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(740, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openHelpFileToolStripMenuItem});
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
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            // 
            // setupJavaToolStripMenuItem
            // 
            this.setupJavaToolStripMenuItem.Name = "setupJavaToolStripMenuItem";
            this.setupJavaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.setupJavaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.setupJavaToolStripMenuItem.Text = "Setup Java";
            this.setupJavaToolStripMenuItem.Click += new System.EventHandler(this.setupJavaToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupJavaToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // ImagePDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 455);
            this.Controls.Add(this.meanConfidenceLabel);
            this.Controls.Add(this.extarctingMsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.languageList);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.pdfOutput);
            this.Controls.Add(this.pdfSourceText);
            this.Controls.Add(this.lastPageNavBtn);
            this.Controls.Add(this.firstPageNavBtn);
            this.Controls.Add(this.pageNumberUpDown);
            this.Controls.Add(this.pdfSourceImage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ImagePDF";
            this.Text = "Valaya Vedan - Image PDF reader";
            this.Load += new System.EventHandler(this.ImagePDF_Load);
            this.Shown += new System.EventHandler(this.ImagePDF_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pageNumberUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfSourceImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown pageNumberUpDown;
        private System.Windows.Forms.Button firstPageNavBtn;
        private System.Windows.Forms.Button lastPageNavBtn;
        private System.Windows.Forms.RichTextBox pdfSourceText;
        private System.Windows.Forms.RichTextBox pdfOutput;
        private System.Windows.Forms.PictureBox pdfSourceImage;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox languageList;
        private System.Windows.Forms.Label extarctingMsg;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label meanConfidenceLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openHelpFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupJavaToolStripMenuItem;
    }
}