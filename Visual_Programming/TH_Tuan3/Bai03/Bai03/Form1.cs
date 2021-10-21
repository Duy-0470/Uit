using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Red, Green, Blue;
            Random rd = new Random();
            Red = rd.Next(0, 255);
            Green = rd.Next(0, 255);
            Blue = rd.Next(0, 255);
            this.BackColor = Color.FromArgb(Red, Green, Blue);
        }
    }
}
