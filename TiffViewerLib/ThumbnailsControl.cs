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
	partial class ThumbnailsControl : UserControl
	{
		private TiffImage image = null;
		private Dictionary<int, int> pageNoToImageListIndex = new Dictionary<int, int>();

		public ThumbnailsControl()
		{
			InitializeComponent();

			this.imageList.ImageSize = new Size(100, 100);

			this.listView.BackColor = Color.LightGray;
			this.listView.HideSelection = false;
			this.listView.LargeImageList = this.imageList;
			this.listView.MultiSelect = false;
			this.listView.View = View.LargeIcon;
			this.listView.VirtualMode = true;
		}

		public delegate void PageChangedDelegate(object sender, int pageNo);
		public PageChangedDelegate PageChanged = null;

		public void Open(TiffImage image)
		{
			this.image = image;

			this.listView.Items.Clear();
			this.imageList.Images.Clear();

			this.listView.VirtualListSize = image.PageCount;
		}

		private void listView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
		{
			int pageNo = e.ItemIndex;

			if (!this.pageNoToImageListIndex.ContainsKey(pageNo))
			{
				Bitmap bitmap = image.GetThumbnail(pageNo, new Size(100, 100));
				int imageListIndex = this.imageList.Images.Count;
				this.imageList.Images.Add(bitmap);
				this.pageNoToImageListIndex[pageNo] = imageListIndex;
			}
			e.Item = new ListViewItem("Page " + (pageNo + 1).ToString(), this.pageNoToImageListIndex[pageNo]);
		}

		private bool suppressEvent = false;

		public void SetPage()
		{
			this.suppressEvent = true;
			this.listView.Items[this.image.PageNo].Selected = true;
			this.listView.EnsureVisible(this.image.PageNo);
			this.suppressEvent = false;
		}

		private void listView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.suppressEvent) return;

			if (this.listView.SelectedIndices.Count < 1)
				return;

			int pageNo = this.listView.SelectedIndices[0];
			if (this.PageChanged != null)
				this.PageChanged(this, pageNo);
		}
	}
}
