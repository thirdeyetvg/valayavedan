using org.apache.pdfbox.pdmodel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tesseract;

namespace valaya_vedan
{
    public partial class ImagePDF : Form
    {
        public string filePath { get; private set; }

        string outputFileFolder = "C:\\temp\\";
        string outputFileName = "sample.jpg";
        string javaExePath = "java.exe";
        string jarPath = "C:\\temp\\PDFImageExtractor.jar";

        public ImagePDF()
        {
            InitializeComponent();
        }

        private void ImagePDF_Load(object sender, EventArgs e)
        {
            pageNumberUpDown.Visible = false;
            lastPageNavBtn.Visible = false;
            firstPageNavBtn.Visible = false;

            languageList.Items.Add("Tamil");
            languageList.SelectedItem = "Tamil";
        }

        private void pageNumberUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Application.DoEvents();
            extarctingMsg.Text = "Processing Image..";
            Console.WriteLine("Changing pagenumber to: " + pageNumberUpDown.Value);
            Console.WriteLine("-jar " + jarPath + " " + filePath + " " + pageNumberUpDown.Value + " " + outputFileFolder + " " + outputFileName);
            var processInfo = new ProcessStartInfo(javaExePath, "-jar " + jarPath + " \""+ filePath + "\" " + pageNumberUpDown.Value + " " + outputFileFolder + " " + outputFileName)
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };
            Process proc;
            proc = Process.Start(processInfo);
            if (proc == null)
            {
                throw new InvalidOperationException("??");
            }

            proc.WaitForExit();
            int exitCode = proc.ExitCode;
            
            proc.Close();
            // pdfSourceImage.Image = Image.FromFile(outputFileFolder + outputFileName);
            try
            {
                convertImageToText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not convert image to text: " + ex.Message);
            }
            extarctingMsg.Text = "Image Processed!!";
        }

        private void convertImageToText()
        {
            using (var engine = new TesseractEngine(Application.StartupPath + "\\tessdata", "tam", EngineMode.Default))
            {
                // have to load Pix via a bitmap since Pix doesn't support loading a stream.
                using (var image = new System.Drawing.Bitmap(outputFileFolder + outputFileName))
                {
                    using (var pix = PixConverter.ToPix(image))
                    {
                        using (var page = engine.Process(pix))
                        {
                            meanConfidenceLabel.Text = String.Format("Confidence {0:P}", page.GetMeanConfidence());
                            Console.WriteLine(page.GetText());
                            pdfOutput.Text = page.GetText();
                        }
                    }
                }
            }
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory(Application.StartupPath);

            {
                extarctingMsg.Text = "";
                openFileDialog.FileName = "";
                openFileDialog.Filter = "PDF Files|*.pdf|Text Files|*.txt|RTF Files|*.rtf";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Clear results
                    pdfSourceText.Text = "";
                    //Get the filename and extension
                    string strFileName = openFileDialog.FileName;
                    filePath = strFileName;
                    string strExtension = strFileName.Substring(strFileName.LastIndexOf(".") + 1);
                    //Validate filetype
                    if (strExtension.ToUpper() == "PDF")
                    {
                        //User interface status updates
                        Cursor = Cursors.WaitCursor;
                        extarctingMsg.Text = "Please wait... Extracting Text from pdf...";
                        Application.DoEvents();
                        try
                        {
                            //Extract text from PDF file
                            PDDocument objDocument = PDDocument.load(strFileName);
                            Application.DoEvents();
                            int totalPages = objDocument.getDocumentCatalog().getAllPages().size();
                            pageNumberUpDown.Maximum = totalPages;
                            pageNumberUpDown.Visible = true;
                            lastPageNavBtn.Visible = true;
                            firstPageNavBtn.Visible = true;
                            pageNumberUpDown.Value = 1;
                            extarctingMsg.Text = "File Loaded!!";
                            // MessageBox.Show("Loading file successful.", "Loaded");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Exception: " + ex.Message, "Error");
                        }
                        //Restore cursor
                        Cursor = Cursors.Default;
                    }
                    else
                    {
                        MessageBox.Show("Please select a PDF or Text file", "Sorry");
                    }
                }
            }
        }

        private void firstPageNavBtn_Click(object sender, EventArgs e)
        {
            pageNumberUpDown.Value = 1;
        }

        private void lastPageNavBtn_Click(object sender, EventArgs e)
        {
            pageNumberUpDown.Value = pageNumberUpDown.Maximum;
        }

        private void setupJavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showSetJavaPathForm();
        }

        private void showSetJavaPathForm()
        {
            if(new SetJavaPath().ShowDialog() == DialogResult.OK)
            {
                if (javaPathExists())
                {
                    Console.Write("Java path set");
                }
            }
        }

        private void openHelpFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory(Application.StartupPath);
            Process.Start(@"Help.rtf");
        }

        private void ImagePDF_Shown(object sender, EventArgs e)
        {
            if (!javaPathExists())
            {
                MessageBox.Show("JAVA path is not set. For proper functioning of the application, JAVA path has to be explicitly set. Click 'OK' to set the JAVA path.\n" +
                    "If you want to set it later, use Settings in Menu options.");
                showSetJavaPathForm();
            }
        }

        private bool javaPathExists()
        {
            // Check if Java path is set
            string javaPath = Properties.Settings.Default.JavaPath;
            if (javaPath != null && !javaPath.Equals(""))
            {
                setupJavaToolStripMenuItem.Checked = true;
                javaExePath = javaPath;
                return true;
            }
            return false;
        }
    }
}
