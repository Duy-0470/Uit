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
    public partial class AccountManagementForm : Form
    {
        public AccountManagementForm()
        {
            InitializeComponent();
        }

        bool IsValid(string text1, string text2, string text3, string text4)
        {
            if (string.IsNullOrEmpty(text1) || string.IsNullOrEmpty(text2) || string.IsNullOrEmpty(text3) || string.IsNullOrEmpty(text4)) return false;
            else return true;
        }
        private void button_Add_Update_Click(object sender, EventArgs e)
        {
            if (!IsValid(textBox_AccountID.Text, textBox_ClientName.Text, textBox_ClientAddress.Text, textBox_AccountBalance.Text)) {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            else
            {
                for (int i = 0; i < listView_Info.Items.Count; i++)
                {
                    if (textBox_AccountID.Text == listView_Info.Items[i].SubItems[1].Text)
                    {
                        listView_Info.Items[i].SubItems[2].Text = textBox_ClientName.Text;
                        listView_Info.Items[i].SubItems[3].Text = textBox_ClientAddress.Text;
                        listView_Info.Items[i].SubItems[4].Text = textBox_AccountBalance.Text;
                        MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                        textBox_AccountID.Clear();
                        textBox_ClientName.Clear();
                        textBox_ClientAddress.Clear();
                        textBox_AccountBalance.Clear();
                        return;
                    }
                }
            }
            string[] info = { textBox_AccountID.Text, textBox_ClientName.Text, textBox_ClientAddress.Text, textBox_AccountBalance.Text };
            listView_Info.Items.Add((listView_Info.Items.Count + 1).ToString()).SubItems.AddRange(info);
            MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
            textBox_AccountID.Clear();
            textBox_ClientName.Clear();
            textBox_ClientAddress.Clear();
            textBox_AccountBalance.Clear();
            
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (listView_Info.Items.Count == 0)
            {
                MessageBox.Show("Chua co tai khoan nao trong he thong");
                return;
            }
            if (string.IsNullOrEmpty(textBox_AccountID.Text))
            {
                MessageBox.Show("Chua co thong tin so tai khoan");
                return;
            }
            for (int i = 0; i < listView_Info.Items.Count; i++)
            {
                if (textBox_AccountID.Text == listView_Info.Items[i].SubItems[1].Text)
                {                        
                    listView_Info.Items.RemoveAt(i);
                    for (int j = 0; j < listView_Info.Items.Count; j++)
                    {
                        listView_Info.Items[j].Text = (j + 1).ToString();
                    }
                    MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            MessageBox.Show("Không tìm thấy số tài khoản cần xóa", "Thông báo", MessageBoxButtons.OK);
        }

        private void button_Quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AccountManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát chương trình.", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void listView_Info_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView_Info.Items.Count == 0) return;
            ListViewItem item = listView_Info.GetItemAt(e.X, e.Y);
            textBox_AccountID.Text = item.SubItems[1].Text;
            textBox_ClientName.Text = item.SubItems[2].Text;
            textBox_ClientAddress.Text = item.SubItems[3].Text;
            textBox_AccountBalance.Text = item.SubItems[4].Text;
        }
    }
}
