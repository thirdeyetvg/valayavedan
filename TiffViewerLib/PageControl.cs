using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TiffViewerLib
{
	partial class PageControl : UserControl
	{
		private TiffImage tiffImage = null;
		private Bitmap workingBitmap = null;

		public PageControl()
		{
			InitializeComponent();
		}

		public delegate void PageChangedDelegate(object sender, int pageNo);
		public PageChangedDelegate PageChanged = null;

		public void Open(TiffImage image)
		{
			this.tiffImage = image;
		}

		public Size GetViewSize()
		{
			return this.pictureBox.Size;
		}

		public void SetPage()
		{
			Refresh_();
		}

		public void SetZoomMode(ZoomMode zoomMode)
		{
			Refresh_();
		}

		public void SetZoom(double zoom)
		{
			Refresh_();
		}

		public void Refresh_()
		{
			if (this.tiffImage == null)
				return;

			this.workingBitmap = this.tiffImage.GetWorkingImage(GetViewSize());
			this.pictureBox.Image = workingBitmap;

			this.origin = new Point(0, 0);
			this.start = new Point(0, 0);
		}

		private void pictureBox_SizeChanged(object sender, EventArgs e)
		{
			Refresh_();
		}

		private bool dragging = false;
		private Point origin = new Point(0, 0);
		private Point start = new Point(0, 0);

		private void pictureBox_MouseDown(object sender, MouseEventArgs e)
		{
			this.dragging = true;
			this.start = e.Location;
		}

		private void pictureBox_MouseUp(object sender, MouseEventArgs e)
		{
			if (!this.dragging)
				return;

			this.dragging = false;
			int dx = e.Location.X - this.start.X;
			int dy = e.Location.Y - this.start.Y;
			this.origin = new Point(this.origin.X + dx, this.origin.Y + dy);
		}

		private void pictureBox_MouseMove(object sender, MouseEventArgs e)
		{
			if (!this.dragging)
				return;

			int dx = e.Location.X - this.start.X;
			int dy = e.Location.Y - this.start.Y;

			Bitmap view = new Bitmap(this.pictureBox.Width, this.pictureBox.Height);
			using (Graphics graphics = Graphics.FromImage(view))
			{
				graphics.DrawImage(this.workingBitmap, this.origin.X + dx, this.origin.Y + dy);
			}
			this.pictureBox.Image = view;
		}
	}
}
