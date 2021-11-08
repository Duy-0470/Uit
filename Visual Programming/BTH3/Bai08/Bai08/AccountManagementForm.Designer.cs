
namespace Bai08
{
    partial class AccountManagementForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_AccountID = new System.Windows.Forms.Label();
            this.label_ClientName = new System.Windows.Forms.Label();
            this.label_ClientAddress = new System.Windows.Forms.Label();
            this.label_AccountBalance = new System.Windows.Forms.Label();
            this.textBox_AccountID = new System.Windows.Forms.TextBox();
            this.textBox_ClientName = new System.Windows.Forms.TextBox();
            this.textBox_ClientAddress = new System.Windows.Forms.TextBox();
            this.textBox_AccountBalance = new System.Windows.Forms.TextBox();
            this.button_Add_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Quit = new System.Windows.Forms.Button();
            this.listView_Info = new System.Windows.Forms.ListView();
            this.column_No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_AcountID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_ClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_ClientAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_AccountBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(68, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ THÔNG TIN TÀI KHOẢN";
            // 
            // label_AccountID
            // 
            this.label_AccountID.AutoSize = true;
            this.label_AccountID.Location = new System.Drawing.Point(174, 108);
            this.label_AccountID.Name = "label_AccountID";
            this.label_AccountID.Size = new System.Drawing.Size(67, 13);
            this.label_AccountID.TabIndex = 1;
            this.label_AccountID.Text = "Số tài khoản";
            // 
            // label_ClientName
            // 
            this.label_ClientName.AutoSize = true;
            this.label_ClientName.Location = new System.Drawing.Point(155, 136);
            this.label_ClientName.Name = "label_ClientName";
            this.label_ClientName.Size = new System.Drawing.Size(86, 13);
            this.label_ClientName.TabIndex = 2;
            this.label_ClientName.Text = "Tên khách hàng";
            // 
            // label_ClientAddress
            // 
            this.label_ClientAddress.AutoSize = true;
            this.label_ClientAddress.Location = new System.Drawing.Point(141, 163);
            this.label_ClientAddress.Name = "label_ClientAddress";
            this.label_ClientAddress.Size = new System.Drawing.Size(100, 13);
            this.label_ClientAddress.TabIndex = 3;
            this.label_ClientAddress.Text = "Địa chỉ khách hàng";
            // 
            // label_AccountBalance
            // 
            this.label_AccountBalance.AutoSize = true;
            this.label_AccountBalance.Location = new System.Drawing.Point(127, 191);
            this.label_AccountBalance.Name = "label_AccountBalance";
            this.label_AccountBalance.Size = new System.Drawing.Size(114, 13);
            this.label_AccountBalance.TabIndex = 4;
            this.label_AccountBalance.Text = "Số tiền trong tài khoản";
            // 
            // textBox_AccountID
            // 
            this.textBox_AccountID.Location = new System.Drawing.Point(281, 101);
            this.textBox_AccountID.Name = "textBox_AccountID";
            this.textBox_AccountID.Size = new System.Drawing.Size(310, 20);
            this.textBox_AccountID.TabIndex = 5;
            // 
            // textBox_ClientName
            // 
            this.textBox_ClientName.Location = new System.Drawing.Point(281, 129);
            this.textBox_ClientName.Name = "textBox_ClientName";
            this.textBox_ClientName.Size = new System.Drawing.Size(310, 20);
            this.textBox_ClientName.TabIndex = 6;
            // 
            // textBox_ClientAddress
            // 
            this.textBox_ClientAddress.Location = new System.Drawing.Point(281, 156);
            this.textBox_ClientAddress.Name = "textBox_ClientAddress";
            this.textBox_ClientAddress.Size = new System.Drawing.Size(310, 20);
            this.textBox_ClientAddress.TabIndex = 7;
            // 
            // textBox_AccountBalance
            // 
            this.textBox_AccountBalance.Location = new System.Drawing.Point(281, 184);
            this.textBox_AccountBalance.Name = "textBox_AccountBalance";
            this.textBox_AccountBalance.Size = new System.Drawing.Size(310, 20);
            this.textBox_AccountBalance.TabIndex = 8;
            // 
            // button_Add_Update
            // 
            this.button_Add_Update.Location = new System.Drawing.Point(308, 224);
            this.button_Add_Update.Name = "button_Add_Update";
            this.button_Add_Update.Size = new System.Drawing.Size(104, 23);
            this.button_Add_Update.TabIndex = 9;
            this.button_Add_Update.Text = "Thêm / Cập nhật";
            this.button_Add_Update.UseVisualStyleBackColor = true;
            this.button_Add_Update.Click += new System.EventHandler(this.button_Add_Update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(429, 224);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(64, 23);
            this.button_Delete.TabIndex = 10;
            this.button_Delete.Text = "Xóa";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Quit
            // 
            this.button_Quit.Location = new System.Drawing.Point(510, 224);
            this.button_Quit.Name = "button_Quit";
            this.button_Quit.Size = new System.Drawing.Size(81, 23);
            this.button_Quit.TabIndex = 11;
            this.button_Quit.Text = "Thoát";
            this.button_Quit.UseVisualStyleBackColor = true;
            this.button_Quit.Click += new System.EventHandler(this.button_Quit_Click);
            // 
            // listView_Info
            // 
            this.listView_Info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_No,
            this.column_AcountID,
            this.column_ClientName,
            this.column_ClientAddress,
            this.column_AccountBalance});
            this.listView_Info.FullRowSelect = true;
            this.listView_Info.HideSelection = false;
            this.listView_Info.Location = new System.Drawing.Point(0, 269);
            this.listView_Info.MultiSelect = false;
            this.listView_Info.Name = "listView_Info";
            this.listView_Info.Size = new System.Drawing.Size(726, 261);
            this.listView_Info.TabIndex = 12;
            this.listView_Info.UseCompatibleStateImageBehavior = false;
            this.listView_Info.View = System.Windows.Forms.View.Details;
            this.listView_Info.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_Info_MouseClick);
            // 
            // column_No
            // 
            this.column_No.Text = "STT";
            this.column_No.Width = 46;
            // 
            // column_AcountID
            // 
            this.column_AcountID.Text = "Mã tài khoản";
            this.column_AcountID.Width = 99;
            // 
            // column_ClientName
            // 
            this.column_ClientName.Text = "Tên khách hàng";
            this.column_ClientName.Width = 186;
            // 
            // column_ClientAddress
            // 
            this.column_ClientAddress.Text = "Địa chỉ";
            this.column_ClientAddress.Width = 222;
            // 
            // column_AccountBalance
            // 
            this.column_AccountBalance.Text = "Số tiền";
            this.column_AccountBalance.Width = 169;
            // 
            // AccountManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(725, 530);
            this.Controls.Add(this.listView_Info);
            this.Controls.Add(this.button_Quit);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Add_Update);
            this.Controls.Add(this.textBox_AccountBalance);
            this.Controls.Add(this.textBox_ClientAddress);
            this.Controls.Add(this.textBox_ClientName);
            this.Controls.Add(this.textBox_AccountID);
            this.Controls.Add(this.label_AccountBalance);
            this.Controls.Add(this.label_ClientAddress);
            this.Controls.Add(this.label_ClientName);
            this.Controls.Add(this.label_AccountID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí tài khoản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountManagementForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_AccountID;
        private System.Windows.Forms.Label label_ClientName;
        private System.Windows.Forms.Label label_ClientAddress;
        private System.Windows.Forms.Label label_AccountBalance;
        private System.Windows.Forms.TextBox textBox_AccountID;
        private System.Windows.Forms.TextBox textBox_ClientName;
        private System.Windows.Forms.TextBox textBox_ClientAddress;
        private System.Windows.Forms.TextBox textBox_AccountBalance;
        private System.Windows.Forms.Button button_Add_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Quit;
        private System.Windows.Forms.ListView listView_Info;
        private System.Windows.Forms.ColumnHeader column_No;
        private System.Windows.Forms.ColumnHeader column_AcountID;
        private System.Windows.Forms.ColumnHeader column_ClientName;
        private System.Windows.Forms.ColumnHeader column_ClientAddress;
        private System.Windows.Forms.ColumnHeader column_AccountBalance;
    }
}

