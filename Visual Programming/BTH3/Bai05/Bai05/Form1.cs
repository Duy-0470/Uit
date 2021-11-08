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
        double Num1, Num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool Get_Value(string txtNum1, string txtNum2)
        {
            if (!Double.TryParse(tb_Num1.Text, out Num1))
            {
                MessageBox.Show("Number 1 is invalid!", "Error");
                return false;
            }
            if (!Double.TryParse(tb_Num2.Text, out Num2))
            {
                MessageBox.Show("Number 2 is invalid!", "Error");
                return false;
            }
            return true;
        }
        private void btn_Plus_Click(object sender, EventArgs e)
        {
            tb_Answer.Text = "";
            if (Get_Value(tb_Num1.Text, tb_Num2.Text))
            {
                double Ans = Num1 + Num2;
                tb_Answer.Text = tb_Answer.Text + Ans;
            }
        }

        private void btn_Sub_Click(object sender, EventArgs e)
        {
            tb_Answer.Text = "";
            if (Get_Value(tb_Num1.Text, tb_Num2.Text))
            {
                double Ans = Num1 - Num2;
                tb_Answer.Text = tb_Answer.Text + Ans;
            }
        }

        private void btn_Dup_Click(object sender, EventArgs e)
        {
            tb_Answer.Text = "";
            if (Get_Value(tb_Num1.Text, tb_Num2.Text))
            {
                double Ans = Num1 * Num2;
                tb_Answer.Text = tb_Answer.Text + Ans;
            }
        }

        private void btn_Div_Click(object sender, EventArgs e)
        {
            tb_Answer.Text = "";
            if (Get_Value(tb_Num1.Text, tb_Num2.Text)) 
            {
                double Ans = 0;
                if (Num2 == 0)
                {
                    MessageBox.Show("Can't divide by zero!", "Error");
                    return;
                }
                Ans = Num1 / Num2;
                tb_Answer.Text = tb_Answer.Text + Ans;
            }
        }
    }
}
