namespace TiffViewerLib
{
	partial class TiffViewer
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
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.thumbnailsControl = new TiffViewerLib.ThumbnailsControl();
			this.pageControl = new TiffViewerLib.PageControl();
			this.toolbarControl = new TiffViewerLib.ToolbarControl();
			// ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer.Location = new System.Drawing.Point(0, 0);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.thumbnailsControl);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.pageControl);
			this.splitContainer.Panel2.Controls.Add(this.toolbarControl);
			this.splitContainer.Size = new System.Drawing.Size(575, 399);
			this.splitContainer.SplitterDistance = 160;
			this.splitContainer.TabIndex = 0;
			// 
			// thumbnailsControl
			// 
			this.thumbnailsControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.thumbnailsControl.Location = new System.Drawing.Point(0, 0);
			this.thumbnailsControl.Name = "thumbnailsControl";
			this.thumbnailsControl.Size = new System.Drawing.Size(160, 399);
			this.thumbnailsControl.TabIndex = 0;
			// 
			// viewControl
			// 
			this.pageControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pageControl.Location = new System.Drawing.Point(0, 0);
			this.pageControl.Name = "viewControl";
			this.pageControl.Size = new System.Drawing.Size(411, 364);
			this.pageControl.TabIndex = 2;
			// 
			// toolbarControl
			// 
			this.toolbarControl.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolbarControl.Location = new System.Drawing.Point(0, 364);
			this.toolbarControl.Name = "toolbarControl";
			this.toolbarControl.Size = new System.Drawing.Size(411, 35);
			this.toolbarControl.TabIndex = 1;
			// 
			// TiffViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer);
			this.Name = "TiffViewer";
			this.Size = new System.Drawing.Size(575, 399);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			// ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer;
		private PageControl pageControl;
		private ToolbarControl toolbarControl;
		private ThumbnailsControl thumbnailsControl;
	}
}
