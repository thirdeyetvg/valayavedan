namespace TiffViewerLib
{
	partial class ToolbarControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolbarControl));
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.prevPageButton = new System.Windows.Forms.ToolStripButton();
			this.pageNoComboBox = new System.Windows.Forms.ToolStripComboBox();
			this.nextPageButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.fitImageButton = new System.Windows.Forms.ToolStripButton();
			this.fitWidthButton = new System.Windows.Forms.ToolStripButton();
			this.zoomButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.zoomInButton = new System.Windows.Forms.ToolStripButton();
			this.zoomOutButton = new System.Windows.Forms.ToolStripButton();
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip
			// 
			this.toolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prevPageButton,
            this.pageNoComboBox,
            this.nextPageButton,
            this.toolStripSeparator2,
            this.fitImageButton,
            this.fitWidthButton,
            this.zoomButton,
            this.toolStripSeparator1,
            this.zoomInButton,
            this.zoomOutButton});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(326, 25);
			this.toolStrip.TabIndex = 0;
			this.toolStrip.Text = "toolStrip1";
			// 
			// prevPageButton
			// 
			this.prevPageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.prevPageButton.Image = ((System.Drawing.Image)(resources.GetObject("prevPageButton.Image")));
			this.prevPageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.prevPageButton.Name = "prevPageButton";
			this.prevPageButton.Size = new System.Drawing.Size(23, 22);
			this.prevPageButton.Click += new System.EventHandler(this.prevPageButton_Click);
			// 
			// pageNoComboBox
			// 
			this.pageNoComboBox.AutoSize = false;
			this.pageNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.pageNoComboBox.DropDownWidth = 40;
			this.pageNoComboBox.Name = "pageNoComboBox";
			this.pageNoComboBox.Size = new System.Drawing.Size(48, 23);
			this.pageNoComboBox.SelectedIndexChanged += new System.EventHandler(this.pageNoComboBox_SelectedIndexChanged);
			// 
			// nextPageButton
			// 
			this.nextPageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.nextPageButton.Image = ((System.Drawing.Image)(resources.GetObject("nextPageButton.Image")));
			this.nextPageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.nextPageButton.Name = "nextPageButton";
			this.nextPageButton.Size = new System.Drawing.Size(23, 22);
			this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// fitImageButton
			// 
			this.fitImageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.fitImageButton.Image = ((System.Drawing.Image)(resources.GetObject("fitImageButton.Image")));
			this.fitImageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.fitImageButton.Name = "fitImageButton";
			this.fitImageButton.Size = new System.Drawing.Size(23, 22);
			this.fitImageButton.Click += new System.EventHandler(this.fitImageButton_Click);
			// 
			// fitWidthButton
			// 
			this.fitWidthButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.fitWidthButton.Image = ((System.Drawing.Image)(resources.GetObject("fitWidthButton.Image")));
			this.fitWidthButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.fitWidthButton.Name = "fitWidthButton";
			this.fitWidthButton.Size = new System.Drawing.Size(23, 22);
			this.fitWidthButton.Click += new System.EventHandler(this.fitWidthButton_Click);
			// 
			// zoomButton
			// 
			this.zoomButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.zoomButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomButton.Image")));
			this.zoomButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.zoomButton.Name = "zoomButton";
			this.zoomButton.Size = new System.Drawing.Size(23, 22);
			this.zoomButton.Click += new System.EventHandler(this.zoomButton_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// zoomInButton
			// 
			this.zoomInButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.zoomInButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomInButton.Image")));
			this.zoomInButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.zoomInButton.Name = "zoomInButton";
			this.zoomInButton.Size = new System.Drawing.Size(23, 22);
			this.zoomInButton.Click += new System.EventHandler(this.zoomInButton_Click);
			// 
			// zoomOutButton
			// 
			this.zoomOutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.zoomOutButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomOutButton.Image")));
			this.zoomOutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.zoomOutButton.Name = "zoomOutButton";
			this.zoomOutButton.Size = new System.Drawing.Size(23, 22);
			this.zoomOutButton.Click += new System.EventHandler(this.zoomOutButton_Click);
			// 
			// ToolbarControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.toolStrip);
			this.Name = "ToolbarControl";
			this.Size = new System.Drawing.Size(326, 25);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton prevPageButton;
		private System.Windows.Forms.ToolStripButton nextPageButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripComboBox pageNoComboBox;
		private System.Windows.Forms.ToolStripButton zoomInButton;
		private System.Windows.Forms.ToolStripButton zoomOutButton;
		private System.Windows.Forms.ToolStripButton fitWidthButton;
		private System.Windows.Forms.ToolStripButton fitImageButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton zoomButton;
	}
}
