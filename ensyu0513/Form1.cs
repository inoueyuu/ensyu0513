using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ensyu0513
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button1.Visible = true;
            button3.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
        }
    }
}
