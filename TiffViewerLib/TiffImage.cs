using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TiffViewerLib
{
	class TiffImage
	{
		private string path = "";

		private Bitmap actualBitmap = null;
		private Bitmap workingBitmap = null;

		public TiffImage(string path)
		{
			this.path = path;
			this.actualBitmap = (Bitmap)Image.FromFile(path);
		}

		public int PageCount
		{
			get
			{
				return this.actualBitmap.GetFrameCount(System.Drawing.Imaging.FrameDimension.Page);
			}
		}

		public Bitmap GetActualImage()
		{
			return this.actualBitmap;
		}

		private int pageNo = 0;
		private double zoom = 1;
		private ZoomMode zoomMode = ZoomMode.FitImage;

		public int PageNo
		{
			get
			{
				return this.pageNo;
			}
		}

		public ZoomMode ZoomMode
		{
			get
			{
				return this.zoomMode;
			}
		}

		public double Zoom
		{
			get
			{
				return this.zoom;
			}
		}

		public Bitmap GetWorkingImage(Size viewSize)
		{
			if (this.workingBitmap != null)
				return this.workingBitmap;

			if (this.zoomMode == ZoomMode.FitWidth)
			{
				Size imageSize = GetActualImage().Size;
				this.zoom = (double)viewSize.Width / imageSize.Width;
			}
			else if (this.zoomMode == ZoomMode.FitImage)
			{
				Size imageSize = GetActualImage().Size;
				double hZoom = (double)viewSize.Width / imageSize.Width;
				double vZoom = (double)viewSize.Height / imageSize.Height;
				if (vZoom > hZoom)
					this.zoom = hZoom;
				else
					this.zoom = vZoom;
			}

			this.workingBitmap = new Bitmap(this.actualBitmap,
				new Size((int)(this.actualBitmap.Width * zoom), (int)(this.actualBitmap.Height * zoom)));
			return this.workingBitmap;
		}

		public void SetPage(int pageNo)
		{
			this.pageNo = pageNo;
			this.actualBitmap.SelectActiveFrame(System.Drawing.Imaging.FrameDimension.Page, pageNo);
			this.workingBitmap = null;
		}

		public void SetZoomMode(ZoomMode zoomMode)
		{
			this.zoomMode = zoomMode;
			this.workingBitmap = null;
		}

		public void SetZoom(Size viewSize, double zoom)
		{
			this.zoom = zoom;
			this.workingBitmap = null;
		}

		public Bitmap GetThumbnail(int pageNo, Size viewport)
		{
			Image image = Image.FromFile(path);
			image.SelectActiveFrame(System.Drawing.Imaging.FrameDimension.Page, pageNo);

			Size imageSize = image.Size;

			double dw = ((double)imageSize.Width / viewport.Width);
			double dh = ((double)imageSize.Height / viewport.Height);

			double scale = dw;
			if (dh > dw) scale = dh;

			int scaledWidth = (int)(imageSize.Width / scale);
			int scaledHeight = (int)(imageSize.Height / scale);
			int xShift = (viewport.Width - scaledWidth) / 2;
			int yShift = (viewport.Height - scaledHeight) / 2;

			Bitmap viewportBitmap = new Bitmap(viewport.Width, viewport.Height);
			Bitmap bitmap = new Bitmap(image, scaledWidth, scaledHeight);
			using (Graphics graphics = Graphics.FromImage(viewportBitmap))
			{
				graphics.DrawImage(bitmap, xShift, yShift);
			}
			return viewportBitmap;
		}
	}
}
