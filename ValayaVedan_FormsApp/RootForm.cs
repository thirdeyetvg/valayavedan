﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            ImagePDF window = new ImagePDF();
            window.Show();
        }

        private void readTextPDFBtn_Click(object sender, EventArgs e)
        {
            ValayaVedanv window = new ValayaVedanv();
            window.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}