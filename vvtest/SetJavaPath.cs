using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace vvtest
{
    public partial class SetJavaPath : Form
    {
        private string javaPath;

        public SetJavaPath()
        {
            InitializeComponent();
        }

        private void SetJavaPath_Load(object sender, EventArgs e)
        {
            javaPath = Properties.Settings.Default.JavaPath;
            javaPathTextBox.Text = javaPath;
        }

        private void setJavaPathBtn_Click(object sender, EventArgs e)
        {
            javaOpenFileDialog.Title = "Open Java File";
            javaOpenFileDialog.Filter = "Java.exe | java.exe";
            javaOpenFileDialog.InitialDirectory = @"C:\";
            if (javaOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                javaPathTextBox.Text = javaOpenFileDialog.FileName;
            }
        }

        private void linkForJavaDownload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.oracle.com/technetwork/java/javase/downloads/index.html");
        }

        private void setJavaPathOkBtn_Click(object sender, EventArgs e)
        {
            javaPath = javaOpenFileDialog.FileName;
            Properties.Settings.Default.JavaPath = javaPath;
            Properties.Settings.Default.Save();
        }
    }
}
