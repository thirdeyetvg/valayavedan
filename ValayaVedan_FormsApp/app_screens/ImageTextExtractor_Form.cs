using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Tesseract;
using valaya_vedan.constants;

namespace valaya_vedan.app_screens
{
    public partial class ImageTextExtractor_Form : Form
    {
        public ImageTextExtractor_Form()
        {
            InitializeComponent();
        }

        private void ImageTextExtractor_Form_Load(object sender, EventArgs e)
        {
            loadConfig();
        }

        private void loadConfig()
        {
            languageList.Items.Add(AppConstants.LANGUAGE_TAMIL);
            // languageList.Items.Add(AppConstants.LANGUAGE_HINDI);
            languageList.Items.Add(AppConstants.LANGUAGE_ENGLISH);
            string savedDefault = Properties.Settings.Default.DefaultLanguage_ImgTE;
            if (savedDefault != null && !savedDefault.Equals(""))
            {
                languageList.SelectedItem = savedDefault;
            } else
            {
                languageList.SelectedItem = AppConstants.LANGUAGE_TAMIL;
            }
        }

        private void loadImagesInList(List<string> imageFiles)
        {
            imageListView.Items.Clear();
            imageList.Images.Clear();
            int i = 0;
            foreach (String imageFile in imageFiles)
            {
                imageList.Images.Add("I" + i++, Image.FromFile(imageFile));
            }

            imageListView.LargeImageList = imageList;

            i = 0;
            foreach (String imageFile in imageFiles)
            {
                var listViewItem = imageListView.Items.Add(Path.GetFileName(imageFile));
                listViewItem.ImageKey = "I" + i++;
                listViewItem.Tag = imageFile;
            }
            if (imageListView.Items.Count > 0)
            {
                imageListView.Items[0].Selected = true;
                imageListView.Select();
            }

        }

        private string getFilePathFromListView()
        {
            return imageListView.Items[imageListView.SelectedIndices[0]].Tag + "";
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] fileNames = openFileDialog.FileNames;
                List<string> fileNamesList = new List<string>(fileNames);
                loadImagesInList(fileNamesList);
            }
        }

        private void openFolderBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;
                String selectedPath = folderBrowserDialog.SelectedPath;
                System.Collections.Generic.List<String> files = Directory.GetFiles(selectedPath, "*.*", SearchOption.AllDirectories)
                            .ToList();
                List<string> imageFiles = new List<string>();
                foreach (string filename in files)
                {
                    if (Regex.IsMatch(filename, @".jpg|.jpeg|.png|.bmp|.gif$"))
                    {
                        imageFiles.Add(filename);
                    }
                }

                if (imageFiles.Count < 1)
                {
                    MessageBox.Show("No Image found");
                }
                else
                {
                    MessageBox.Show(imageFiles.Count + " Images found");
                    loadImagesInList(imageFiles);
                }
                Cursor = Cursors.Default;
            }
        }

        private void imageListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imageListView.SelectedIndices.Count == 0)
            {
                return;
            }
            sourcePictureBox.Image = Image.FromFile(getFilePathFromListView());
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            if (imageListView.SelectedIndices.Count > 0)
            {
                convertImageToText();
            }
        }

        private void convertImageToText()
        {
            Cursor = Cursors.WaitCursor;
            string tessDataExtension = getTessDataExtension(languageList.Text);
            using (var engine = new TesseractEngine(Application.StartupPath + "\\tessdata", tessDataExtension, EngineMode.Default))
            {
                // have to load Pix via a bitmap since Pix doesn't support loading a stream.
                using (var image = new System.Drawing.Bitmap(getFilePathFromListView()))
                {
                    using (var pix = PixConverter.ToPix(image))
                    {
                        using (var page = engine.Process(pix))
                        {
                            meanConfidenceLabel.Text = String.Format("Confidence {0:P}", page.GetMeanConfidence());
                            Console.WriteLine(page.GetText());
                            convertedTextBox.Text = page.GetText();
                        }
                    }
                }
            }
            Cursor = Cursors.Default;
            convertedTextBox.Focus();
        }

        private string getTessDataExtension(string text)
        {
            switch (text)
            {
                case AppConstants.LANGUAGE_TAMIL:
                    return "tam";
                case AppConstants.LANGUAGE_ENGLISH:
                    return "eng";
                case AppConstants.LANGUAGE_HINDI:
                    return "hin";
                default:
                    return "eng";
            }
        }

        private void languageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DefaultLanguage_ImgTE = languageList.Text;
            Properties.Settings.Default.Save();
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
            Process.Start(@"Help.rtf");
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileBtn_Click(null, null);
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFolderBtn_Click(null, null);
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            convertBtn_Click(null, null);
        }
    }
}
