using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace valaya_vedan
{
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            label1.Text=" We are glad to introduce ourselves as a social organisation,\naiming to help visually challenged persons through Information Technology and other media.\n\n Our one line mission statement is \"SEEING THROUGH SOUND\".\n\n We work closely with visually challenged persons and open source communities \nwho develop software and others for the visually challenged people.";
            label1.Text += "\n\nFeel free to contact us:\n\n              Website:    http://thirdeyetvg.com/\n\n              Email:         thirdeyetvg@gmail.com";
        }
    }
}