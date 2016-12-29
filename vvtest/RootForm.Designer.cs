namespace vvtest
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
            this.SuspendLayout();
            // 
            // readImagePDFBtn
            // 
            this.readImagePDFBtn.Location = new System.Drawing.Point(67, 60);
            this.readImagePDFBtn.Name = "readImagePDFBtn";
            this.readImagePDFBtn.Size = new System.Drawing.Size(143, 49);
            this.readImagePDFBtn.TabIndex = 0;
            this.readImagePDFBtn.Text = "Read Image PDF";
            this.readImagePDFBtn.UseVisualStyleBackColor = true;
            this.readImagePDFBtn.Click += new System.EventHandler(this.readImagePDFBtn_Click);
            // 
            // readTextPDFBtn
            // 
            this.readTextPDFBtn.Location = new System.Drawing.Point(67, 137);
            this.readTextPDFBtn.Name = "readTextPDFBtn";
            this.readTextPDFBtn.Size = new System.Drawing.Size(143, 48);
            this.readTextPDFBtn.TabIndex = 1;
            this.readTextPDFBtn.Text = "Read Text PDF";
            this.readTextPDFBtn.UseVisualStyleBackColor = true;
            this.readTextPDFBtn.Click += new System.EventHandler(this.readTextPDFBtn_Click);
            // 
            // RootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.readTextPDFBtn);
            this.Controls.Add(this.readImagePDFBtn);
            this.Name = "RootForm";
            this.Text = "Valaya Vedan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button readImagePDFBtn;
        private System.Windows.Forms.Button readTextPDFBtn;
    }
}