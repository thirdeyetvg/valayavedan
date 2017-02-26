using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;
using ValayaVedan;
using System.Diagnostics;
using java.util;
using org.apache.pdfbox.pdmodel.graphics.xobject;

namespace valaya_vedan
{
    public partial class ValayaVedanv : Form
    {
        // Refactor these
        String[] Me=new String[2000];
        String[] Unicode = new String[2000];
        String[] UnicodeEquv = new String[2000];
        String defLang, defFont,args;
        int strCnt = 0;
        public ValayaVedanv(String args)
        {
            this.args = args;
            InitializeComponent();
        }

        public ValayaVedanv()
        {
            this.args = null;
            InitializeComponent();
        }     

        private void convert_Click(object sender, EventArgs e)
        {
            int index = 0, prevIndex = 0, maxLen = 0, strIndex = 0, newIndex = 0, tempIndexcnt=0;
            
            String content = inputText.Text;
            String derivedStr;
            StringBuilder output = new StringBuilder();
            String[] hexValues = new String[content.Length];
            outputText.Text = "";
            /*
            //First Create the instance of Stopwatch Class
            Stopwatch sw = new Stopwatch();

            // Start The StopWatch ...From 000
            sw.Start();
              */  
            for (int i = 0; i < content.Length; i++)
            {
                hexValues[i] = Convert.ToInt32(content[i]).ToString("x");
                hexValues[i] = hexValues[i].PadLeft(4, '0').ToUpper();
            }

            progressBar1.Minimum = 0;
            if(content.Length>0)
            progressBar1.Maximum = content.Length-1;
            progressBar1.Enabled = true;
            progressBar1.Focus();
            int[] tempIndex = new int[2000];
            String temp = "";
            loadingMsg.Text="Please wait.. Converting Text...";
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            try
            {           

                while (strIndex < content.Length)
                {
                    progressBar1.Value = strIndex;
                    index = 0; prevIndex = 0; maxLen = 0; newIndex = 0; tempIndexcnt = 0;
                    if (content[strIndex] == ' ' || content[strIndex] == '\n')
                    {
                        output.Append(content[strIndex]);
                        strIndex++;
                    }
                    else
                    {
                        temp = hexValues[strIndex];
                        index = FindMe(temp, -1);
                        while (index != -1 && temp.Length > 0)
                        {
                            prevIndex = index;
                            tempIndex[tempIndexcnt++] = index;
                            if (maxLen < Me[index].Length)
                                maxLen = Me[index].Length;
                            index = FindMe(temp, index);
                        }
                        if (maxLen == 0)
                        {
                            output.Append( content[strIndex]);
                            strIndex++;
                        }
                        else
                            if (maxLen > 0 && tempIndexcnt == 1)
                            {
                                output.Append(UnicodeEquv[tempIndex[0]]);
                                strIndex++;
                            }
                            else
                            {
                                int maxChars = maxLen / 4;
                                StringBuilder sBuffer = new StringBuilder();
                                for (int i = 0; i < maxChars; i++)
                                {
                                    if ((i + strIndex) >= content.Length)
                                        break;                                    
                                    sBuffer.Append(hexValues[i+strIndex]);
                                }
                                derivedStr = sBuffer.ToString();
                                newIndex = -1;
                                for (int j = 0; j < tempIndexcnt; j++)
                                {
                                    if (derivedStr.CompareTo(Me[tempIndex[j]]) == 0)
                                        newIndex = j;
                                }
                                if (newIndex == (-1) && derivedStr.Length > 4)
                                {
                                    while (maxChars > 1)
                                    {
                                        derivedStr = derivedStr.Substring(0, derivedStr.Length - 4);
                                        for (int j = 0; j < tempIndexcnt; j++)
                                        {
                                                if (derivedStr.CompareTo(Me[tempIndex[j]]) == 0)
                                                    newIndex = j;
                                        }
                                        maxChars--;
                                        if (newIndex != (-1))
                                            break;
                                    }
                                }
                                if (newIndex == (-1))
                                {
                                    strIndex++;
                                    newIndex = 0;
                                }
                                else
                                {                                   
                                    output.Append(UnicodeEquv[tempIndex[newIndex]]);
                                    strIndex += maxChars;
                                }
                            }
                    }
                }
                outputText.Text = output.ToString();
                loadingMsg.Text = "Text Converted!!";
                Cursor = Cursors.Default;
                /*
                sw.Stop();

                //Writing Execution Time in label

                string ExecutionTimeTaken = string.Format("Minutes :{0}\nSeconds :{1}\n Mili seconds :{2}", sw.Elapsed.Minutes, sw.Elapsed.Seconds, sw.Elapsed.TotalMilliseconds);
                MessageBox.Show(ExecutionTimeTaken);*/
                
                MessageBox.Show("Text conversion successful.", "Converted");
                progressBar1.Value = 0;
                outputText.Focus();        
            }
            catch (Exception ex)
            {

                outputText.Text = output.ToString();
                Cursor = Cursors.Default;
                outputText.Focus();
                MessageBox.Show("Exception: " + ex.Message, "Error");
                progressBar1.Value = 0;
                loadingMsg.Text = "";
            }        
        }

        private int FindMe(string Text, int index)
        {
            for (int i = index + 1; i < strCnt; i++)
            {
                if (Me[i][2] == Text[2] && Me[i][3] == Text[3])
                    if (Me[i].StartsWith(Text))
                        return i;
            }
            return -1;
        }       

        private string HexString2Ascii(string hexString)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= hexString.Length - 4; i += 4)
            {
                sb.Append(Convert.ToString(Convert.ToChar(Int32.Parse(hexString.Substring(i, 4), System.Globalization.NumberStyles.HexNumber))));
            }
            return sb.ToString();
        }

        private void Extract()
        {
            {
                {
                    {
                        Directory.SetCurrentDirectory(Application.StartupPath);
                        //Clear results
                        inputText.Text = "";
                        //Get the filename and extension
                        string strFileName = args;
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
                                PDFTextStripper objTextStripper = new PDFTextStripper();
                                inputText.Text = objTextStripper.getText(objDocument);
                                extarctingMsg.Text = "Text Extracted!!";
                                DialogResult rslt = MessageBox.Show("Text extraction successful.\nDo you want to save the extracted file?", "Extracted", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                                if (rslt == DialogResult.Yes)
                                {
                                    saveExtractedText();
                                }

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
                            if (strExtension.ToUpper() == "TXT")
                            {
                                extarctingMsg.Text = "Please wait... Extracting Text from file...";
                                inputText.LoadFile(strFileName, RichTextBoxStreamType.PlainText);
                                extarctingMsg.Text = "Text Extracted!!...";
                                MessageBox.Show("Text extraction successful.", "Extracted");
                            }
                            else
                                MessageBox.Show("Please select a PDF or Text file", "Sorry");

                        }

                        convert.Focus();
                    }
                }
            }
        }

        private void saveExtractedText()
        {

            {
                System.IO.Stream myStream1;
                String filePath;
                saveTextFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveTextFileDialog.FilterIndex = 1;
                try
                {
                    if (saveTextFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        if ((myStream1 = saveTextFileDialog.OpenFile()) != null)
                        {
                            filePath = saveTextFileDialog.FileName;
                            inputText.SaveFile(myStream1, RichTextBoxStreamType.PlainText);
                            DialogResult rslt = MessageBox.Show("Do you want to open output file?", "Open file", MessageBoxButtons.YesNo);
                            if (rslt == DialogResult.Yes)
                            {
                                Process.Start(filePath);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message, "Error");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadingOperations();
            if (this.args != null)
                Extract();
        }

        private void loadingOperations()
        {
            loadingMsg.Text = "";
            extarctingMsg.Text = "";
            this.Show();
            loadConfig();
            extractText.Focus();
        }

        private void loadConfig()
        {
            languageList.Items.Clear();
            fontList.Items.Clear();
            {
                try
                {
                    String temp;
                    int eqIndex;
                    TextReader trs = new StreamReader(Application.StartupPath + "\\Languages\\" + "config.txt");
                    temp = trs.ReadLine();
                    eqIndex = temp.IndexOf("=");
                    defLang = temp.Substring(eqIndex + 2, temp.Length - eqIndex - 3);
                    temp = trs.ReadLine();
                    eqIndex = temp.IndexOf("=");
                    defFont = temp.Substring(eqIndex + 2, temp.Length - eqIndex - 3);
                    //MessageBox.Show(defFont + " " + defLang);
                    trs.Close();

                    try
                    {
                        foreach (String str in System.IO.Directory.GetFiles(Application.StartupPath + "\\Languages\\", "*.xml"))
                        {
                            FileInfo file = new FileInfo(str);
                            languageList.Items.Add(file.Name.Substring(0, file.Name.IndexOf('.')));

                        }
                        if (languageList.Items.Count == 0)
                        {
                            MessageBox.Show("Error no Language file found!!", "Error");
                            Application.Exit();
                        }
                        else
                        {
                            if (defLang != "")
                            {
                                languageList.SelectedIndex = languageList.Items.IndexOf(defLang);
                            }
                            else
                            {
                                languageList.SelectedIndex = 0;
                            }


                            LoadFonts();
                            if (defFont != "")
                            {
                                fontList.SelectedIndex = fontList.Items.IndexOf(defFont);
                            }
                            else
                            {
                                fontList.SelectedIndex = 0;
                            }
                            LoadMapping();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exception: " + ex.Message, "Error");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message, "Error");
                }
            }
        }

        private void LoadLanguage()
        {
            foreach (String str in System.IO.Directory.GetFiles(Application.StartupPath + "\\Languages\\", "*.xml"))
            {
                FileInfo file = new FileInfo(str);
                languageList.Items.Add(file.Name);

            }
        }

        private void LoadFonts()
        {
            fontList.Items.Clear();
            XmlTextReader objXmlTextReader = new XmlTextReader(Application.StartupPath+"\\Languages\\" + languageList.Text + ".xml");
            try
            {
                objXmlTextReader.Read();
                while (objXmlTextReader.Read())
                {
                    switch (objXmlTextReader.NodeType)
                    {

                        case XmlNodeType.Element:
                            if (objXmlTextReader.Name != "Me" && objXmlTextReader.Name != "Unicode" && objXmlTextReader.Name != "Fonts" && objXmlTextReader.Name != "Match")
                                fontList.Items.Add(objXmlTextReader.Name);
                            break;
                        case XmlNodeType.Text:
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Error");
            }
        }

        private void LoadMapping()
        {
            strCnt = 0;
            bool end = false;
            String sName, value, sName1 = "";
            try
            {
                XmlTextReader objXmlTextReader1 = new XmlTextReader(Application.StartupPath+"\\Languages\\"+languageList.Text + ".xml");
                while (objXmlTextReader1.Read())
                {
                    switch (objXmlTextReader1.NodeType)
                    {

                        case XmlNodeType.Element:
                            sName = objXmlTextReader1.Name;
                            if (sName == fontList.Text)
                            {
                                while (objXmlTextReader1.Read())
                                {
                                    switch (objXmlTextReader1.NodeType)
                                    {
                                        case XmlNodeType.Element:
                                            sName1 = objXmlTextReader1.Name;
                                            if (sName1 != "Unicode" && sName1 != "Me" && sName1 != "Match")
                                            {
                                                end = true;
                                            }
                                            break;
                                        case XmlNodeType.Text:
                                            switch (sName1)
                                            {
                                                case "Unicode":
                                                    value = objXmlTextReader1.Value;
                                                    Unicode[strCnt] = value;
                                                    break;
                                                case "Me":
                                                    value = objXmlTextReader1.Value;
                                                    Me[strCnt++] = value;
                                                    break;
                                            }
                                            break;
                                    }
                                    if (end == true)
                                        goto loopend;

                                }
                            }
                            break;
                        case XmlNodeType.Text:
                            break;
                    }
                }
            loopend: ;
                objXmlTextReader1.Close();

                for (int i = 0; i < strCnt; i++)
                {
                    UnicodeEquv[i] = HexString2Ascii(Unicode[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Error");
            }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadMapping();
        }

        private void extract_Click(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory(Application.StartupPath);

            {
                extarctingMsg.Text = "";
                openPDFFileDialog.FileName = "";
                openPDFFileDialog.Filter = "PDF Files|*.pdf|Text Files|*.txt|RTF Files|*.rtf";
                if (openPDFFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Clear results
                    inputText.Text = "";
                    //Get the filename and extension
                    string strFileName = openPDFFileDialog.FileName;
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
                            PDFTextStripper objTextStripper = new PDFTextStripper();
                            inputText.Text = objTextStripper.getText(objDocument);
                            extarctingMsg.Text = "Text Extracted!!";
                            MessageBox.Show("Text extraction successful.", "Extracted");

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
                        if (strExtension.ToUpper() == "TXT")
                        {
                            extarctingMsg.Text = "Please wait... Extracting Text from file...";
                            inputText.LoadFile(strFileName, RichTextBoxStreamType.PlainText);
                            extarctingMsg.Text = "Text Extracted!!...";
                            MessageBox.Show("Text extraction successful.", "Extracted");
                        }
                        else
                            MessageBox.Show("Please select a PDF or Text file", "Sorry");

                    }

                    convert.Focus();
                }
            }
        }

        private void saveExtractedTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.Stream myStream1;
            saveTextFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveTextFileDialog.FilterIndex = 1;        
            try
            {
                if (saveTextFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream1 = saveTextFileDialog.OpenFile()) != null)
                    {
                        inputText.SaveFile(myStream1, RichTextBoxStreamType.PlainText);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Error");
            }
        }        

        private void button3_Click(object sender, EventArgs e)
        {
            System.IO.Stream myStream1;
            String filePath;
            saveTextFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveTextFileDialog.FilterIndex = 1;
            try
            {
                if (saveTextFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream1 = saveTextFileDialog.OpenFile()) != null)
                    {
                        filePath = saveTextFileDialog.FileName;
                        outputText.SaveFile(myStream1, RichTextBoxStreamType.UnicodePlainText);
                        myStream1.Close();
                        DialogResult rslt = MessageBox.Show("Do you want to open output file?", "Open file", MessageBoxButtons.YesNo);
                        if (rslt == DialogResult.Yes)
                        {
                            Process.Start(filePath);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Error");
            }
        }

        private void changeLanguageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use arrows to change Language" , "Option");
            languageList.Focus();
        }

        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use arrows to change Font", "Option");
            fontList.Focus();
        }

        private void languageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFonts();
            fontList.SelectedIndex = 0;

            LoadMapping();
            extractText.Focus();
        }

        private void changeDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeDefault obj = new changeDefault();
            DialogResult rslt=obj.ShowDialog();
            loadConfig();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs obj = new AboutUs();
            obj.ShowDialog();
        }

        private void demo()
        {
            Directory.SetCurrentDirectory(Application.StartupPath);

            {
                extarctingMsg.Text = "";
                openPDFFileDialog.FileName = "";
                openPDFFileDialog.Filter = "PDF Files|*.pdf|Text Files|*.txt|RTF Files|*.rtf";
                if (openPDFFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Clear results
                    inputText.Text = "";
                    //Get the filename and extension
                    string strFileName = openPDFFileDialog.FileName;
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
                            Iterator iterator = objDocument.getDocumentCatalog().getAllPages().iterator();
                            while (iterator.hasNext())
                            {
                                PDPage page = (PDPage)iterator.next();
                                PDResources resources = page.getResources();
                                Map images = resources.getImages();
                                Iterator imageIterator = images.keySet().iterator();
                                while (imageIterator.hasNext())
                                {
                                    // imageIterator.next();
                                    String key = (String)imageIterator.next();
                                    PDXObjectImage image = (PDXObjectImage)images.get(key);
                                    String filePath = "C:\\temp\\" + key + "." + image.getSuffix();
                                    image.write2file(filePath);
                                    MessageBox.Show(filePath);
                                }
                            }
                            PDFTextStripper objTextStripper = new PDFTextStripper();
                            inputText.Text = objTextStripper.getText(objDocument);
                            extarctingMsg.Text = "Text Extracted!!";
                            MessageBox.Show("Text extraction successful.", "Extracted");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("**Exception: " + ex.Message, "Error");
                        }
                        //Restore cursor
                        Cursor = Cursors.Default;
                    }
                    else
                    {
                        if (strExtension.ToUpper() == "TXT")
                        {
                            extarctingMsg.Text = "Please wait... Extracting Text from file...";
                            inputText.LoadFile(strFileName, RichTextBoxStreamType.PlainText);
                            extarctingMsg.Text = "Text Extracted!!...";
                            MessageBox.Show("Text extraction successful.", "Extracted");
                        }
                        else
                            MessageBox.Show("Please select a PDF or Text file", "Sorry");

                    }

                    convert.Focus();
                }
            }
        }

        private void openHelpFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory(Application.StartupPath);
            Process.Start(@"Help.rtf");
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help obj = new Help();
            obj.Show();
        } 
        
    }
}