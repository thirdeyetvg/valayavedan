namespace valaya_vedan
{
    partial class SetJavaPath
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
            this.javaPathTextBox = new System.Windows.Forms.TextBox();
            this.setJavaPathBtn = new System.Windows.Forms.Button();
            this.linkForJavaDownload = new System.Windows.Forms.LinkLabel();
            this.javaOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.setJavaPathOkBtn = new System.Windows.Forms.Button();
            this.setJavaPathCancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // javaPathTextBox
            // 
            this.javaPathTextBox.AccessibleDescription = "Text box for Java path";
            this.javaPathTextBox.AccessibleName = "Java path text box";
            this.javaPathTextBox.Location = new System.Drawing.Point(25, 41);
            this.javaPathTextBox.Name = "javaPathTextBox";
            this.javaPathTextBox.Size = new System.Drawing.Size(290, 20);
            this.javaPathTextBox.TabIndex = 1;
            // 
            // setJavaPathBtn
            // 
            this.setJavaPathBtn.Location = new System.Drawing.Point(333, 29);
            this.setJavaPathBtn.Name = "setJavaPathBtn";
            this.setJavaPathBtn.Size = new System.Drawing.Size(75, 42);
            this.setJavaPathBtn.TabIndex = 0;
            this.setJavaPathBtn.Text = "Setup Java path";
            this.setJavaPathBtn.UseVisualStyleBackColor = true;
            this.setJavaPathBtn.Click += new System.EventHandler(this.setJavaPathBtn_Click);
            // 
            // linkForJavaDownload
            // 
            this.linkForJavaDownload.AutoSize = true;
            this.linkForJavaDownload.Location = new System.Drawing.Point(154, 124);
            this.linkForJavaDownload.Name = "linkForJavaDownload";
            this.linkForJavaDownload.Size = new System.Drawing.Size(141, 13);
            this.linkForJavaDownload.TabIndex = 4;
            this.linkForJavaDownload.TabStop = true;
            this.linkForJavaDownload.Text = "Click here to download Java";
            this.linkForJavaDownload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForJavaDownload_LinkClicked);
            // 
            // setJavaPathOkBtn
            // 
            this.setJavaPathOkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.setJavaPathOkBtn.Location = new System.Drawing.Point(126, 85);
            this.setJavaPathOkBtn.Name = "setJavaPathOkBtn";
            this.setJavaPathOkBtn.Size = new System.Drawing.Size(75, 23);
            this.setJavaPathOkBtn.TabIndex = 2;
            this.setJavaPathOkBtn.Text = "OK";
            this.setJavaPathOkBtn.UseVisualStyleBackColor = true;
            this.setJavaPathOkBtn.Click += new System.EventHandler(this.setJavaPathOkBtn_Click);
            // 
            // setJavaPathCancelBtn
            // 
            this.setJavaPathCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.setJavaPathCancelBtn.Location = new System.Drawing.Point(240, 85);
            this.setJavaPathCancelBtn.Name = "setJavaPathCancelBtn";
            this.setJavaPathCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.setJavaPathCancelBtn.TabIndex = 3;
            this.setJavaPathCancelBtn.Text = "Cancel";
            this.setJavaPathCancelBtn.UseVisualStyleBackColor = true;
            // 
            // SetJavaPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 163);
            this.Controls.Add(this.setJavaPathCancelBtn);
            this.Controls.Add(this.setJavaPathOkBtn);
            this.Controls.Add(this.linkForJavaDownload);
            this.Controls.Add(this.setJavaPathBtn);
            this.Controls.Add(this.javaPathTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetJavaPath";
            this.Text = "Set Java Path";
            this.Load += new System.EventHandler(this.SetJavaPath_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox javaPathTextBox;
        private System.Windows.Forms.Button setJavaPathBtn;
        private System.Windows.Forms.LinkLabel linkForJavaDownload;
        private System.Windows.Forms.OpenFileDialog javaOpenFileDialog;
        private System.Windows.Forms.Button setJavaPathOkBtn;
        private System.Windows.Forms.Button setJavaPathCancelBtn;
    }
}