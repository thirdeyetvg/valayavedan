using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ValayaVedan;

namespace valaya_vedan
{
    public partial class RootForm : Form
    {
        public RootForm()
        {
            InitializeComponent();
        }

        private void RootForm_Load(object sender, EventArgs e)
        {
            
        }

        private void readImagePDFBtn_Click(object sender, EventArgs e)
        {
            PDFImageExtractor_Form window = new PDFImageExtractor_Form();
            window.Show();
        }

        private void readTextPDFBtn_Click(object sender, EventArgs e)
        {
            ValayaVedanv window = new ValayaVedanv();
            window.Show();
        }

        private void RootForm_Load_1(object sender, EventArgs e)
        {
            frmSplash SplashScreen = new frmSplash();
            SplashScreen.Show();
            Application.DoEvents();
            System.Threading.Thread.Sleep(2000);
            SplashScreen.Hide();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs obj = new AboutUs();
            obj.ShowDialog();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help obj = new Help();
            obj.Show();
        }

        private void openHelpFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory(Application.StartupPath);
            System.Diagnostics.Process.Start(@"Help.rtf");
        }

        private void RootForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Help obj = new Help();
            obj.Show();
        }

        private void readImagePDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PDFImageExtractor_Form window = new PDFImageExtractor_Form();
            window.Show();
        }

        private void readTextPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ValayaVedanv window = new ValayaVedanv();
            window.Show();
        }
    }
}
