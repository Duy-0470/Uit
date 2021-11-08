using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Bai09
{
    public partial class Form_StudentInfo : Form
    {
        private static IEnumerable<string> EnumerateLines(StringReader reader)
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                yield return line;
            }
        }

        private static string[] ReadAllResourceLines(string resourceText)
        {
            using (StringReader reader = new StringReader(resourceText))
            {
                return EnumerateLines(reader).ToArray();
            }
        }

        private readonly string[] IT = ReadAllResourceLines(Properties.Resources.IT);
        private readonly string[] InSy = ReadAllResourceLines(Properties.Resources.InSy);
        private readonly string[] CS = ReadAllResourceLines(Properties.Resources.CS);
        private readonly string[] SE = ReadAllResourceLines(Properties.Resources.SE);
        private readonly string[] CE = ReadAllResourceLines(Properties.Resources.CE);
        private readonly string[] CNaDS = ReadAllResourceLines(Properties.Resources.CNaDS);
        private readonly string[] CNaDT = ReadAllResourceLines(Properties.Resources.CNaDT);
        private readonly string[] InSe = ReadAllResourceLines(Properties.Resources.InSe);
        private readonly string[] EC = ReadAllResourceLines(Properties.Resources.EC);
        private readonly string[] DaSc = ReadAllResourceLines(Properties.Resources.DaSc);
        private readonly List<string[]> professions = new List<string[]>();
             
        public Form_StudentInfo()
        {
            InitializeComponent();
            professions.AddRange(new List<string[]>() { IT, InSy, CS, SE, CE, CNaDS, CNaDT, InSe, EC, DaSc });
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_ID.Text) || string.IsNullOrEmpty(textBox_Name.Text) || (checkBox_Male.Checked == false && checkBox_Female.Checked == false) || comboBox_Profession.SelectedIndex == -1 || listView_SelectedSubjects.Items.Count == 0)
            {
                MessageBox.Show("Lam on nhap day du thong tin", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (dataGridView_StudentInfo.RowCount > 1)
                {
                    for (int i = 0; i < dataGridView_StudentInfo.RowCount; i++)
                    {
                        if (dataGridView_StudentInfo.Rows[i].Cells[0].Value != null && textBox_ID.Text == dataGridView_StudentInfo.Rows[i].Cells[0].Value.ToString())
                        {
                            MessageBox.Show("MSSV da ton tai", "Lỗi", MessageBoxButtons.OK);
                            return;
                        }
                    }
                }
            }
            string[] data = { textBox_ID.Text, textBox_Name.Text, comboBox_Profession.Text, checkBox_Male.Checked ? "Nam" : "Nữ", listView_SelectedSubjects.Items.Count.ToString() };
            dataGridView_StudentInfo.Rows.Add(data);
            textBox_ID.Clear();
            textBox_Name.Clear();
            comboBox_Profession.SelectedIndex = -1;
            listView_SelectedSubjects.Items.Clear();
            checkBox_Male.Checked = checkBox_Female.Checked = false;
            textBox_ID.Focus();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            if (listView_SelectedSubjects.Items.Count == 0) return;                 
            for (int i = 0; i < listView_SelectedSubjects.Items.Count; i++)
            {
                listView_Subjects.Items.Add(listView_SelectedSubjects.Items[i].Text);
                listView_SelectedSubjects.Items[i].Remove();
                i--;               
            }
        }

        private void comboBox_Profession_SelectedIndexChanged(object sender, EventArgs e)
        {            
            listView_Subjects.Items.Clear();
            listView_SelectedSubjects.Items.Clear();
            if (comboBox_Profession.SelectedIndex == -1) return;
            for (int i = 0; i < professions[comboBox_Profession.SelectedIndex].Length; i++)
            {
                listView_Subjects.Items.Add(professions[comboBox_Profession.SelectedIndex][i]);
            }
        }

        private void button_Select_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView_Subjects.Items.Count; i++)
            {
                if (listView_Subjects.Items[i].Selected)
                {
                    listView_SelectedSubjects.Items.Add(listView_Subjects.Items[i].Text);
                    listView_Subjects.Items[i].Remove();
                    i--;
                }
            }
        }

        private void button_Unselect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView_SelectedSubjects.Items.Count; i++)
            {
                if (listView_SelectedSubjects.Items[i].Selected)
                {
                    listView_Subjects.Items.Add(listView_SelectedSubjects.Items[i].Text);
                    listView_SelectedSubjects.Items[i].Remove();
                    i--;
                }
            }
        }

        private void checkBox_Male_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Male.Checked == true) checkBox_Female.Checked = false;
        }

        private void checkBox_Female_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Female.Checked == true) checkBox_Male.Checked = false;
        }
    }
}