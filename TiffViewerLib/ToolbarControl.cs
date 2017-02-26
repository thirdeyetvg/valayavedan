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
	partial class ToolbarControl : UserControl
	{
		private TiffImage image = null;

		public ToolbarControl()
		{
			InitializeComponent();
			if (this.DesignMode) return;

			foreach (ToolStripItem item in this.toolStrip.Items)
				item.Enabled = false;
		}

		public delegate double GetZoomDelegate();
		public delegate ZoomMode GetZoomModeDelegate();
		public delegate void PageChangedDelegate(object sender, int pageNo);
		public delegate void ZoomChangedDelegate(object sender, double zoom);
		public delegate void ZoomModeChangedDelegate(object sender, ZoomMode mode);

		public GetZoomDelegate GetZoom = null;
		public GetZoomModeDelegate GetZoomMode = null;
		public PageChangedDelegate PageChanged = null;
		public ZoomChangedDelegate ZoomChanged = null;
		public ZoomModeChangedDelegate ZoomModeChanged = null;

		public void Open(TiffImage image)
		{
			this.image = image;

			int pageCount = image.PageCount;
			this.pageNoComboBox.Items.Clear();
			for (int i = 0; i < pageCount; i++)
				this.pageNoComboBox.Items.Add((i + 1));

			foreach (ToolStripItem item in this.toolStrip.Items)
				item.Enabled = true;
		}

		private bool suppressEvent = false;

		public void SetPage()
		{
			this.suppressEvent = true;
			this.pageNoComboBox.SelectedIndex = this.image.PageNo;
			if (this.image.PageNo > 0)
				this.prevPageButton.Enabled = true;
			else
				this.prevPageButton.Enabled = false;
			if (this.image.PageNo < this.image.PageCount - 1)
				this.nextPageButton.Enabled = true;
			else
				this.nextPageButton.Enabled = false;
			this.suppressEvent = false;
		}

		public void SetZoomMode(ZoomMode zoomMode)
		{
			this.fitImageButton.Checked = false;
			this.fitWidthButton.Checked = false;
			this.zoomButton.Checked = false;

			if (zoomMode == ZoomMode.FitImage)
				this.fitImageButton.Checked = true;

			if (zoomMode == ZoomMode.FitWidth)
				this.fitWidthButton.Checked = true;

			if (zoomMode == ZoomMode.Zoom)
				this.zoomButton.Checked = true;
		}

		private void pageNoComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.suppressEvent) return;

			if (this.PageChanged != null)
			{
				int pageNo = this.pageNoComboBox.SelectedIndex;
				this.PageChanged(this, pageNo);
			}
		}

		private void prevPageButton_Click(object sender, EventArgs e)
		{
			this.PageChanged(this, this.image.PageNo - 1);
		}

		private void nextPageButton_Click(object sender, EventArgs e)
		{
			this.PageChanged(this, this.image.PageNo + 1);
		}

		private void zoomInButton_Click(object sender, EventArgs e)
		{
			double zoom = GetZoom();
			zoom *= 1.1;
			this.ZoomModeChanged(sender, ZoomMode.Zoom);
			this.ZoomChanged(sender, zoom);
		}

		private void zoomOutButton_Click(object sender, EventArgs e)
		{
			double zoom = GetZoom();
			zoom /= 1.1;
			this.ZoomModeChanged(sender, ZoomMode.Zoom);
			this.ZoomChanged(sender, zoom);
		}

		private void fitWidthButton_Click(object sender, EventArgs e)
		{
			this.ZoomModeChanged(this, ZoomMode.FitWidth);
		}

		private void fitImageButton_Click(object sender, EventArgs e)
		{
			this.ZoomModeChanged(this, ZoomMode.FitImage);
		}

		private void zoomButton_Click(object sender, EventArgs e)
		{
			this.ZoomModeChanged(this, ZoomMode.Zoom);
		}
	}
}
