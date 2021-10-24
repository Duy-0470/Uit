using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai07
{
    public partial class Form1 : Form
    {
        List<Button> list_btn;
        int Fee = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void lb_Monitor_Click(object sender, EventArgs e)
        {

        }
        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Blue;
            }
            else if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.White;
            }
            else if (btn.BackColor == Color.Yellow)
            {
                MessageBox.Show("The seat is occupied!", "Inform");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list_btn = new List<Button>();
            list_btn.Add(button1);
            list_btn.Add(button2);
            list_btn.Add(button3);
            list_btn.Add(button4);
            list_btn.Add(button5);
            list_btn.Add(button6);
            list_btn.Add(button7);
            list_btn.Add(button8);
            list_btn.Add(button9);
            list_btn.Add(button10);
            list_btn.Add(button11);
            list_btn.Add(button12);
            list_btn.Add(button13);
            list_btn.Add(button14);
            list_btn.Add(button15);
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < list_btn.Count; i++)
            {
                if (list_btn[i].BackColor == Color.Blue)
                {
                    if (i < 5)
                    {
                        Fee += 5000;
                    }
                    else if (i < 10)
                    {
                        Fee += 6500;
                    }
                    else
                    {
                        Fee += 8000;
                    }
                    list_btn[i].BackColor = Color.Yellow;
                }
            }
            tb_Total.Text = Fee.ToString();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < list_btn.Count; i++)
            {
                if (list_btn[i].BackColor == Color.Blue)
                {
                    list_btn[i].BackColor = Color.White;
                }
            }
            Fee = 0;
            tb_Total.Text = Fee.ToString();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
