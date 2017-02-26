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
	public partial class TiffViewer : UserControl
	{
		private string path = "";
		private TiffImage image = null;

		public TiffViewer()
		{
			InitializeComponent();
			if (this.DesignMode) return;

			this.pageControl.PageChanged += PageChanged;
			this.thumbnailsControl.PageChanged += PageChanged;
			this.toolbarControl.PageChanged += PageChanged;

			this.toolbarControl.GetZoomMode += GetZoomMode;
			this.toolbarControl.GetZoom += GetZoom;
			this.toolbarControl.ZoomChanged += ZoomChanged;
			this.toolbarControl.ZoomModeChanged += ZoomModeChanged;
		}

		public void Open(string path)
		{
			this.path = path;
			if (this.DesignMode) return;

			this.image = new TiffImage(path);

			this.pageControl.Open(this.image);
			this.thumbnailsControl.Open(this.image);
			this.toolbarControl.Open(this.image);

			this.pageControl.SetPage();
			this.thumbnailsControl.SetPage();
			this.toolbarControl.SetPage();

			this.toolbarControl.SetZoomMode(this.image.ZoomMode);
		}

		public ZoomMode GetZoomMode()
		{
			return this.image.ZoomMode;
		}

		public double GetZoom()
		{
			return this.image.Zoom;
		}

		public void PageChanged(object sender, int pageNo)
		{
			this.image.SetPage(pageNo);

			this.pageControl.SetPage();
			this.thumbnailsControl.SetPage();
			this.toolbarControl.SetPage();
		}

		public void ZoomModeChanged(object sender, ZoomMode zoomMode)
		{
			this.image.SetZoomMode(zoomMode);

			this.pageControl.SetZoomMode(zoomMode);
			this.toolbarControl.SetZoomMode(zoomMode);
		}

		public void ZoomChanged(object sender, double zoom)
		{
			this.image.SetZoom(this.pageControl.GetViewSize(), zoom);

			this.pageControl.SetZoom(zoom);
		}

		[Description("Gets or sets the path to the TIFF file"), Category("Viewer")]
		public string Path
		{
			get
			{
				return this.path;
			}
			set
			{
				if (value == "")
					return;

				Open(value);
			}
		}
	}
}
