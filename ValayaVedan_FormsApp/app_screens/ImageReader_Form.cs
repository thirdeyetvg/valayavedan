using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TiffViewer
{
	public partial class ImageReaderForm : Form
	{
		public ImageReaderForm()
		{
			InitializeComponent();
		}

		private void openMenuItem_Click(object sender, EventArgs e)
		{
			if (this.openFileDialog.ShowDialog() != DialogResult.OK)
				return;

			string path = this.openFileDialog.FileName;
			this.tiffViewer1.Path = path;
			//this.tiffViewer.Open(path);
		}
	}
}
