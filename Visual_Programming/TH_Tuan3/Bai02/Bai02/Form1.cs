using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            string s = "Paint Event";
            Font verdana14 = new Font("Verdana", 14);
            SizeF sz = g.MeasureString(s, verdana14);
            Random rd = new Random();
            float x = rd.Next(0, 300);
            float y = rd.Next(0, 400);
            g.DrawString(s, verdana14, Brushes.Black, new PointF(x, y));
            g.DrawRectangle(new Pen(Color.Red, 3), x, y, sz.Width, sz.Height);
            g.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
