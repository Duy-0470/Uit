using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            tb_Answer.Text = "";
            double Num1 = Double.Parse(tb_Num1.Text);
            double Num2 = Double.Parse(tb_Num2.Text);
            double Ans = Num1 + Num2;
            tb_Answer.Text = tb_Answer.Text + Ans;
        }

        private void btn_Sub_Click(object sender, EventArgs e)
        {
            tb_Answer.Text = "";
            double Num1 = Double.Parse(tb_Num1.Text);
            double Num2 = Double.Parse(tb_Num2.Text);
            double Ans = Num1 - Num2;
            tb_Answer.Text = tb_Answer.Text + Ans;
        }

        private void btn_Dup_Click(object sender, EventArgs e)
        {
            tb_Answer.Text = "";
            double Num1 = Double.Parse(tb_Num1.Text);
            double Num2 = Double.Parse(tb_Num2.Text);
            double Ans = Num1 * Num2;
            tb_Answer.Text = tb_Answer.Text + Ans;
        }

        private void btn_Div_Click(object sender, EventArgs e)
        {
            tb_Answer.Text = "";
            double Num1 = Double.Parse(tb_Num1.Text);
            double Num2 = Double.Parse(tb_Num2.Text);
            double Ans = Num1 / Num2;
            tb_Answer.Text = tb_Answer.Text + Ans;
        }
    }
}
