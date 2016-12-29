namespace vvtest
{
    partial class ValayaVedanv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValayaVedanv));
            this.convert = new System.Windows.Forms.Button();
            this.inputText = new System.Windows.Forms.RichTextBox();
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.loadingMsg = new System.Windows.Forms.Label();
            this.languageList = new System.Windows.Forms.ComboBox();
            this.fontList = new System.Windows.Forms.ComboBox();
            this.extractText = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.extarctingMsg = new System.Windows.Forms.Label();
            this.saveOutput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractTextFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOutputTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveExtractedTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openHelpFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Input = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // convert
            // 
            this.convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.convert.Location = new System.Drawing.Point(370, 36);
            this.convert.Margin = new System.Windows.Forms.Padding(2);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(175, 49);
            this.convert.TabIndex = 3;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // inputText
            // 
            this.inputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputText.Location = new System.Drawing.Point(7, 103);
            this.inputText.Margin = new System.Windows.Forms.Padding(2);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(358, 323);
            this.inputText.TabIndex = 2;
            this.inputText.Text = "";
            this.inputText.WordWrap = false;
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(370, 103);
            this.outputText.Margin = new System.Windows.Forms.Padding(2);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(358, 323);
            this.outputText.TabIndex = 4;
            this.outputText.Text = "";
            this.outputText.WordWrap = false;
            // 
            // loadingMsg
            // 
            this.loadingMsg.AutoSize = true;
            this.loadingMsg.Location = new System.Drawing.Point(368, 430);
            this.loadingMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loadingMsg.Name = "loadingMsg";
            this.loadingMsg.Size = new System.Drawing.Size(61, 13);
            this.loadingMsg.TabIndex = 16;
            this.loadingMsg.Text = "loadingMsg";
            // 
            // languageList
            // 
            this.languageList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageList.FormattingEnabled = true;
            this.languageList.Location = new System.Drawing.Point(195, 56);
            this.languageList.Margin = new System.Windows.Forms.Padding(2);
            this.languageList.Name = "languageList";
            this.languageList.Size = new System.Drawing.Size(80, 21);
            this.languageList.TabIndex = 7;
            this.languageList.SelectedIndexChanged += new System.EventHandler(this.languageList_SelectedIndexChanged);
            // 
            // fontList
            // 
            this.fontList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontList.FormattingEnabled = true;
            this.fontList.Location = new System.Drawing.Point(277, 56);
            this.fontList.Margin = new System.Windows.Forms.Padding(2);
            this.fontList.Name = "fontList";
            this.fontList.Size = new System.Drawing.Size(80, 21);
            this.fontList.TabIndex = 6;
            this.fontList.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // extractText
            // 
            this.extractText.Location = new System.Drawing.Point(7, 36);
            this.extractText.Margin = new System.Windows.Forms.Padding(2);
            this.extractText.Name = "extractText";
            this.extractText.Size = new System.Drawing.Size(182, 49);
            this.extractText.TabIndex = 1;
            this.extractText.Text = "Extract text from file";
            this.extractText.UseVisualStyleBackColor = true;
            this.extractText.Click += new System.EventHandler(this.extract_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // extarctingMsg
            // 
            this.extarctingMsg.AutoSize = true;
            this.extarctingMsg.Location = new System.Drawing.Point(4, 430);
            this.extarctingMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.extarctingMsg.Name = "extarctingMsg";
            this.extarctingMsg.Size = new System.Drawing.Size(73, 13);
            this.extarctingMsg.TabIndex = 19;
            this.extarctingMsg.Text = "extarctingMsg";
            // 
            // saveOutput
            // 
            this.saveOutput.Location = new System.Drawing.Point(553, 35);
            this.saveOutput.Margin = new System.Windows.Forms.Padding(2);
            this.saveOutput.Name = "saveOutput";
            this.saveOutput.Size = new System.Drawing.Size(175, 49);
            this.saveOutput.TabIndex = 5;
            this.saveOutput.Text = "Save output text";
            this.saveOutput.UseVisualStyleBackColor = true;
            this.saveOutput.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Language(s):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Font(s):";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(736, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractTextFromFileToolStripMenuItem,
            this.convertToolStripMenuItem,
            this.saveOutputTextToolStripMenuItem,
            this.saveExtractedTextToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // extractTextFromFileToolStripMenuItem
            // 
            this.extractTextFromFileToolStripMenuItem.Name = "extractTextFromFileToolStripMenuItem";
            this.extractTextFromFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.extractTextFromFileToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.extractTextFromFileToolStripMenuItem.Text = "Extract text from file";
            this.extractTextFromFileToolStripMenuItem.Click += new System.EventHandler(this.extract_Click);
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.convertToolStripMenuItem.Text = "Convert";
            this.convertToolStripMenuItem.Click += new System.EventHandler(this.convert_Click);
            // 
            // saveOutputTextToolStripMenuItem
            // 
            this.saveOutputTextToolStripMenuItem.Name = "saveOutputTextToolStripMenuItem";
            this.saveOutputTextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.saveOutputTextToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.saveOutputTextToolStripMenuItem.Text = "Save output text";
            this.saveOutputTextToolStripMenuItem.Click += new System.EventHandler(this.button3_Click);
            // 
            // saveExtractedTextToolStripMenuItem
            // 
            this.saveExtractedTextToolStripMenuItem.Name = "saveExtractedTextToolStripMenuItem";
            this.saveExtractedTextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.saveExtractedTextToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.saveExtractedTextToolStripMenuItem.Text = "Save extracted text";
            this.saveExtractedTextToolStripMenuItem.Click += new System.EventHandler(this.saveExtractedTextToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeLanguageToolStripMenuItem,
            this.changeFontToolStripMenuItem,
            this.changeDefaultToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // changeLanguageToolStripMenuItem
            // 
            this.changeLanguageToolStripMenuItem.Name = "changeLanguageToolStripMenuItem";
            this.changeLanguageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.changeLanguageToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.changeLanguageToolStripMenuItem.Text = "Change language";
            this.changeLanguageToolStripMenuItem.Click += new System.EventHandler(this.changeLanguageToolStripMenuItem_Click);
            // 
            // changeFontToolStripMenuItem
            // 
            this.changeFontToolStripMenuItem.Name = "changeFontToolStripMenuItem";
            this.changeFontToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.changeFontToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.changeFontToolStripMenuItem.Text = "Change font";
            this.changeFontToolStripMenuItem.Click += new System.EventHandler(this.changeFontToolStripMenuItem_Click);
            // 
            // changeDefaultToolStripMenuItem
            // 
            this.changeDefaultToolStripMenuItem.Name = "changeDefaultToolStripMenuItem";
            this.changeDefaultToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.changeDefaultToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.changeDefaultToolStripMenuItem.Text = "Change default";
            this.changeDefaultToolStripMenuItem.Click += new System.EventHandler(this.changeDefaultToolStripMenuItem_Click);
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
            // Input
            // 
            this.Input.AutoSize = true;
            this.Input.Location = new System.Drawing.Point(4, 87);
            this.Input.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(54, 13);
            this.Input.TabIndex = 24;
            this.Input.Text = "Input text:";
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(368, 87);
            this.output.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(62, 13);
            this.output.TabIndex = 25;
            this.output.Text = "Output text:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(585, 431);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(142, 13);
            this.progressBar1.TabIndex = 26;
            // 
            // ValayaVedanv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 451);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveOutput);
            this.Controls.Add(this.extarctingMsg);
            this.Controls.Add(this.extractText);
            this.Controls.Add(this.fontList);
            this.Controls.Add(this.languageList);
            this.Controls.Add(this.loadingMsg);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ValayaVedanv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valaya Vedan v1.1 (Beta Version)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.RichTextBox inputText;
        private System.Windows.Forms.RichTextBox outputText;
        private System.Windows.Forms.Label loadingMsg;
        private System.Windows.Forms.ComboBox languageList;
        private System.Windows.Forms.ComboBox fontList;
        private System.Windows.Forms.Button extractText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label extarctingMsg;
        private System.Windows.Forms.Button saveOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractTextFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveOutputTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveExtractedTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeLanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFontToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label Input;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem changeDefaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openHelpFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
    }
}

