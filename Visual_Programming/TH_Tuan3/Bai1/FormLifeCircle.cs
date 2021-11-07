using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class FormLifeCircle : Form
    {
        public FormLifeCircle()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.SystemColors.Window;
        }
        private void FormInfo()
        {
            Form temp = new Form();
            temp.Load += Temp_Load;
            temp.Activated += Temp_Activated;
            temp.VisibleChanged += Temp_VisibleChanged;
            temp.FormClosing += Temp_FormClosing;
            temp.FormClosed += Temp_FormClosed;
            temp.Deactivate += Temp_Deactivate;
            temp.Show();
        }
        private void CreateNewFrmBtn_Click(object sender, EventArgs e)
        {
            this.RtbFormEvent.Text += "\n---------------------------------------\n";
            this.RtbFormEvent.Text += DateTime.Now + "\n";
            this.RtbFormEvent.Focus();
            FormInfo();
        }
        private void DeleteEventHistoryLlb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.RtbFormEvent.Clear();
        }

        private void Temp_Load(object sender, EventArgs e)
        {
            this.RtbFormEvent.AppendText("Form đã hiện lên màn hình.\n");
        }

        private void Temp_VisibleChanged(object sender, EventArgs e)
        {
            this.RtbFormEvent.AppendText("Form đã chuyển sang trạng thái hoạt động.\n");
        }

        private void Temp_Activated(object sender, EventArgs e)
        {
            this.RtbFormEvent.AppendText("Form đã được kích hoạt.\n");
        }
        private void Temp_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.RtbFormEvent.AppendText("Form đang được đóng.\n");
        }

        private void Temp_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.RtbFormEvent.AppendText("Form đã đóng.\n");
        }

        private void Temp_Deactivate(object sender, EventArgs e)
        {
            this.RtbFormEvent.AppendText("Form đã hủy kích hoạt\n");
        }
    }
}
