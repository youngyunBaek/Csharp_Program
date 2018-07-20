using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelChange1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPage1Next_Click_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnPage2Pre_Click_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnPage2Next_Click_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void btnPage3Pre_Click_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void btnPage3Next_Click_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }
    }
}
