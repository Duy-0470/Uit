using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            g.TranslateTransform(Size.Width / 2, Size.Height / 2);
        }

        private void DrawClock(Graphics g)
        {
            Point[] pt = new Point[2];
            for (int iAngle = 0; iAngle < 360; iAngle += 6)
            {
                pt[0].X = 0;
                pt[0].Y = 150;
                RotatePoint(pt, 1, iAngle);
                pt[1].X = pt[1].Y = (iAngle % 5 == 0 ? 10 : 5);
                pt[0].X -= pt[1].X / 2;
                pt[0].Y -= pt[1].Y / 2;
                g.DrawEllipse(new Pen(Color.White), pt[0].X, pt[0].Y, pt[1].X, pt[1].Y);
                g.FillEllipse(new SolidBrush(Color.White), pt[0].X, pt[0].Y, pt[1].X, pt[1].Y);
            }    
        }

        private void RotatePoint(Point[] pt, int iRotate, int iAngle)
        {   
            Point temp = new Point(0, 0);
            for (int i = 0; i < iRotate; i++)
            {
                temp.X = (int)(pt[i].X * Math.Cos(2 * Math.PI * iAngle / 360) - pt[i].Y * Math.Sin(2 * Math.PI * iAngle / 360));
                temp.Y = (int)(pt[i].Y * Math.Cos(2 * Math.PI * iAngle / 360) + pt[i].X * Math.Sin(2 * Math.PI * iAngle / 360));
                pt[i] = temp;
            }    
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawClock(g);
        }
    }
}
