using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace ValayaVedan
{
    public partial class changeDefault : Form
    {
        String defLang, defFont;

        String[] Me = new String[2000];
        String[] Unicode = new String[2000];
        public changeDefault()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            defLang = languageList.Text;
            defFont = fontList.Text;

            try
            {
                TextWriter tsw = new StreamWriter(Application.StartupPath + "\\Languages\\" + "config.txt");
                tsw.WriteLine("Default Language=\"" + defLang + "\"");
                tsw.WriteLine("Default Font=\"" + defFont + "\"");
                tsw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                String temp;
                int eqIndex;
                TextReader trs = new StreamReader(Application.StartupPath + "\\Languages\\" + "config.txt");
                temp=trs.ReadLine();
                eqIndex = temp.IndexOf("=");
                defLang = temp.Substring(eqIndex+2 ,temp.Length-eqIndex- 3);
                temp = trs.ReadLine();
                eqIndex = temp.IndexOf("=");
                defFont = temp.Substring(eqIndex+2, temp.Length-eqIndex- 3);
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

        private void languageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFonts();
            fontList.SelectedIndex = 0;
        }
    }
}