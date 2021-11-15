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
    public partial class CinemaTicket : Form
    {
        public CinemaTicket()
        {
            InitializeComponent();
        }

        private bool[] AlreadyChoose = new bool[16];
        private bool[] Choose = new bool[16];
        int money = 0;

        private void ChooseThisChair_Click(object sender, EventArgs e)
        {
            Button thisChair = (Button)sender;
            int i = int.Parse(thisChair.Text);

            if (AlreadyChoose[i])
            {
                MessageBox.Show("Ghế này đã được chọn");
            }
            else
            {
                if (!Choose[i])
                {
                    Choose[i] = true;
                    thisChair.BackColor = Color.Blue;
                    if (i <= 5) money += 5000;
                    else if (i <= 10) money += 6500;
                    else money += 8000;
                }
                else
                {
                    Choose[i] = false;
                    thisChair.BackColor = Color.White;
                    if (i <= 5) money -= 5000;
                    else if (i <= 10) money -= 6500;
                    else money -= 8000;
                }
            }
            ThTienTbx.Text = money.ToString();
        }

        private void EndBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChooseBtn_Click(object sender, EventArgs e)
        {
            foreach (Button btn in ChairBtnPnl.Controls)
            {
                int i = int.Parse(btn.Text);
                if (Choose[i])
                {
                    btn.BackColor = Color.Yellow;
                    AlreadyChoose[i] = true;
                    Choose[i] = false;
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            foreach (Button btn in ChairBtnPnl.Controls)
            {
                int i = int.Parse(btn.Text);
                if (Choose[i])
                {
                    btn.BackColor = Color.White;
                    Choose[i] = false;
                }
            }
            this.ThTienTbx.Text = "0";
        }
    }
}
