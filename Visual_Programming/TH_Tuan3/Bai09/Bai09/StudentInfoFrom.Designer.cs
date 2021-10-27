
namespace Bai09
{
    partial class Form_StudentInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_StudentInfo = new System.Windows.Forms.GroupBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Unselect = new System.Windows.Forms.Button();
            this.button_Select = new System.Windows.Forms.Button();
            this.listView_SelectedSubjects = new System.Windows.Forms.ListView();
            this.listView_Subjects = new System.Windows.Forms.ListView();
            this.label_Subjects = new System.Windows.Forms.Label();
            this.checkBox_Female = new System.Windows.Forms.CheckBox();
            this.checkBox_Male = new System.Windows.Forms.CheckBox();
            this.comboBox_Profession = new System.Windows.Forms.ComboBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label_Gender = new System.Windows.Forms.Label();
            this.label_Profession = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.dataGridView_StudentInfo = new System.Windows.Forms.DataGridView();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Profession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Subjects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_StudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StudentInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_StudentInfo
            // 
            this.groupBox_StudentInfo.Controls.Add(this.button_Cancel);
            this.groupBox_StudentInfo.Controls.Add(this.button_Save);
            this.groupBox_StudentInfo.Controls.Add(this.button_Unselect);
            this.groupBox_StudentInfo.Controls.Add(this.button_Select);
            this.groupBox_StudentInfo.Controls.Add(this.listView_SelectedSubjects);
            this.groupBox_StudentInfo.Controls.Add(this.listView_Subjects);
            this.groupBox_StudentInfo.Controls.Add(this.label_Subjects);
            this.groupBox_StudentInfo.Controls.Add(this.checkBox_Female);
            this.groupBox_StudentInfo.Controls.Add(this.checkBox_Male);
            this.groupBox_StudentInfo.Controls.Add(this.comboBox_Profession);
            this.groupBox_StudentInfo.Controls.Add(this.textBox_Name);
            this.groupBox_StudentInfo.Controls.Add(this.textBox_ID);
            this.groupBox_StudentInfo.Controls.Add(this.label_Gender);
            this.groupBox_StudentInfo.Controls.Add(this.label_Profession);
            this.groupBox_StudentInfo.Controls.Add(this.label_Name);
            this.groupBox_StudentInfo.Controls.Add(this.label_ID);
            this.groupBox_StudentInfo.Location = new System.Drawing.Point(22, 12);
            this.groupBox_StudentInfo.Name = "groupBox_StudentInfo";
            this.groupBox_StudentInfo.Size = new System.Drawing.Size(754, 365);
            this.groupBox_StudentInfo.TabIndex = 0;
            this.groupBox_StudentInfo.TabStop = false;
            this.groupBox_StudentInfo.Text = "Thông tin sinh viên";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(384, 333);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(93, 23);
            this.button_Cancel.TabIndex = 16;
            this.button_Cancel.Text = "Xóa chọn";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(293, 333);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(85, 23);
            this.button_Save.TabIndex = 15;
            this.button_Save.Text = "Lưu thông tin";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Unselect
            // 
            this.button_Unselect.Location = new System.Drawing.Point(363, 259);
            this.button_Unselect.Name = "button_Unselect";
            this.button_Unselect.Size = new System.Drawing.Size(40, 23);
            this.button_Unselect.TabIndex = 14;
            this.button_Unselect.Text = "<";
            this.button_Unselect.UseVisualStyleBackColor = true;
            this.button_Unselect.Click += new System.EventHandler(this.button_Unselect_Click);
            // 
            // button_Select
            // 
            this.button_Select.Location = new System.Drawing.Point(363, 230);
            this.button_Select.Name = "button_Select";
            this.button_Select.Size = new System.Drawing.Size(40, 23);
            this.button_Select.TabIndex = 13;
            this.button_Select.Text = ">";
            this.button_Select.UseVisualStyleBackColor = true;
            this.button_Select.Click += new System.EventHandler(this.button_Select_Click);
            // 
            // listView_SelectedSubjects
            // 
            this.listView_SelectedSubjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView_SelectedSubjects.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView_SelectedSubjects.HideSelection = false;
            this.listView_SelectedSubjects.Location = new System.Drawing.Point(429, 180);
            this.listView_SelectedSubjects.Name = "listView_SelectedSubjects";
            this.listView_SelectedSubjects.Size = new System.Drawing.Size(319, 147);
            this.listView_SelectedSubjects.TabIndex = 12;
            this.listView_SelectedSubjects.UseCompatibleStateImageBehavior = false;
            this.listView_SelectedSubjects.View = System.Windows.Forms.View.Details;
            // 
            // listView_Subjects
            // 
            this.listView_Subjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView_Subjects.FullRowSelect = true;
            this.listView_Subjects.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView_Subjects.HideSelection = false;
            this.listView_Subjects.Location = new System.Drawing.Point(6, 180);
            this.listView_Subjects.Name = "listView_Subjects";
            this.listView_Subjects.Size = new System.Drawing.Size(330, 147);
            this.listView_Subjects.TabIndex = 11;
            this.listView_Subjects.UseCompatibleStateImageBehavior = false;
            this.listView_Subjects.View = System.Windows.Forms.View.Details;
            // 
            // label_Subjects
            // 
            this.label_Subjects.AutoSize = true;
            this.label_Subjects.Location = new System.Drawing.Point(194, 150);
            this.label_Subjects.Name = "label_Subjects";
            this.label_Subjects.Size = new System.Drawing.Size(140, 13);
            this.label_Subjects.TabIndex = 10;
            this.label_Subjects.Text = "Chọn các môn học tham gia";
            // 
            // checkBox_Female
            // 
            this.checkBox_Female.AutoSize = true;
            this.checkBox_Female.Location = new System.Drawing.Point(351, 116);
            this.checkBox_Female.Name = "checkBox_Female";
            this.checkBox_Female.Size = new System.Drawing.Size(40, 17);
            this.checkBox_Female.TabIndex = 9;
            this.checkBox_Female.Text = "Nữ";
            this.checkBox_Female.UseVisualStyleBackColor = true;
            this.checkBox_Female.CheckedChanged += new System.EventHandler(this.checkBox_Female_CheckedChanged);
            // 
            // checkBox_Male
            // 
            this.checkBox_Male.AutoSize = true;
            this.checkBox_Male.Location = new System.Drawing.Point(297, 116);
            this.checkBox_Male.Name = "checkBox_Male";
            this.checkBox_Male.Size = new System.Drawing.Size(48, 17);
            this.checkBox_Male.TabIndex = 8;
            this.checkBox_Male.Text = "Nam";
            this.checkBox_Male.UseVisualStyleBackColor = true;
            this.checkBox_Male.CheckedChanged += new System.EventHandler(this.checkBox_Male_CheckedChanged);
            // 
            // comboBox_Profession
            // 
            this.comboBox_Profession.FormattingEnabled = true;
            this.comboBox_Profession.Items.AddRange(new object[] {
            "Công nghệ Thông tin",
            "Hệ thống Thông tin",
            "Khoa học Máy tính",
            "Kỹ thuật Phần mềm",
            "Kỹ thuật Máy tính",
            "Mạng máy tính và An toàn thông tin",
            "Mạng máy tính và Truyền thông dữ liệu",
            "An toàn thông tin",
            "Thương mại điện tử",
            "Khoa học Dữ liệu"});
            this.comboBox_Profession.Location = new System.Drawing.Point(297, 82);
            this.comboBox_Profession.Name = "comboBox_Profession";
            this.comboBox_Profession.Size = new System.Drawing.Size(288, 21);
            this.comboBox_Profession.TabIndex = 7;
            this.comboBox_Profession.SelectedIndexChanged += new System.EventHandler(this.comboBox_Profession_SelectedIndexChanged);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(297, 53);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(288, 20);
            this.textBox_Name.TabIndex = 6;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(297, 24);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(288, 20);
            this.textBox_ID.TabIndex = 5;
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Location = new System.Drawing.Point(194, 116);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(47, 13);
            this.label_Gender.TabIndex = 4;
            this.label_Gender.Text = "Giới tính";
            // 
            // label_Profession
            // 
            this.label_Profession.AutoSize = true;
            this.label_Profession.Location = new System.Drawing.Point(194, 85);
            this.label_Profession.Name = "label_Profession";
            this.label_Profession.Size = new System.Drawing.Size(76, 13);
            this.label_Profession.TabIndex = 3;
            this.label_Profession.Text = "Chuyên ngành";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(194, 56);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(39, 13);
            this.label_Name.TabIndex = 2;
            this.label_Name.Text = "Họ tên";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(194, 27);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(67, 13);
            this.label_ID.TabIndex = 1;
            this.label_ID.Text = "Mã sinh viên";
            // 
            // dataGridView_StudentInfo
            // 
            this.dataGridView_StudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_StudentInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ID,
            this.Column_Name,
            this.Column_Profession,
            this.Column_Gender,
            this.Column_Subjects});
            this.dataGridView_StudentInfo.Location = new System.Drawing.Point(22, 383);
            this.dataGridView_StudentInfo.Name = "dataGridView_StudentInfo";
            this.dataGridView_StudentInfo.Size = new System.Drawing.Size(754, 250);
            this.dataGridView_StudentInfo.TabIndex = 1;
            // 
            // Column_ID
            // 
            this.Column_ID.HeaderText = "MSSV";
            this.Column_ID.Name = "Column_ID";
            this.Column_ID.ReadOnly = true;
            this.Column_ID.Width = 110;
            // 
            // Column_Name
            // 
            this.Column_Name.HeaderText = "Họ tên";
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.ReadOnly = true;
            this.Column_Name.Width = 230;
            // 
            // Column_Profession
            // 
            this.Column_Profession.HeaderText = "Chuyên Ngành";
            this.Column_Profession.Name = "Column_Profession";
            this.Column_Profession.ReadOnly = true;
            this.Column_Profession.Width = 230;
            // 
            // Column_Gender
            // 
            this.Column_Gender.HeaderText = "Giới tính";
            this.Column_Gender.Name = "Column_Gender";
            this.Column_Gender.ReadOnly = true;
            this.Column_Gender.Width = 71;
            // 
            // Column_Subjects
            // 
            this.Column_Subjects.HeaderText = "Số môn";
            this.Column_Subjects.Name = "Column_Subjects";
            this.Column_Subjects.ReadOnly = true;
            this.Column_Subjects.Width = 70;
            // 
            // Form_StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 645);
            this.Controls.Add(this.dataGridView_StudentInfo);
            this.Controls.Add(this.groupBox_StudentInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_StudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập liệu sinh viên";
            this.groupBox_StudentInfo.ResumeLayout(false);
            this.groupBox_StudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StudentInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_StudentInfo;
        private System.Windows.Forms.Button button_Unselect;
        private System.Windows.Forms.Button button_Select;
        private System.Windows.Forms.ListView listView_SelectedSubjects;
        private System.Windows.Forms.ListView listView_Subjects;
        private System.Windows.Forms.Label label_Subjects;
        private System.Windows.Forms.CheckBox checkBox_Female;
        private System.Windows.Forms.CheckBox checkBox_Male;
        private System.Windows.Forms.ComboBox comboBox_Profession;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.Label label_Profession;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.DataGridView dataGridView_StudentInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Profession;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Subjects;
    }
}

