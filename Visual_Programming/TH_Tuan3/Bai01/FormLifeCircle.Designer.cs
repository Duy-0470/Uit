
namespace Bai01
{
    partial class FormLifeCircle
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
            this.TitleLb = new System.Windows.Forms.Label();
            this.RtbFormEvent = new System.Windows.Forms.RichTextBox();
            this.CreateNewFrmBtn = new System.Windows.Forms.Button();
            this.frmEventLB = new System.Windows.Forms.Label();
            this.DeleteEventHistoryLlb = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // TitleLb
            // 
            this.TitleLb.AutoSize = true;
            this.TitleLb.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLb.ForeColor = System.Drawing.Color.SkyBlue;
            this.TitleLb.Location = new System.Drawing.Point(12, 37);
            this.TitleLb.Name = "TitleLb";
            this.TitleLb.Size = new System.Drawing.Size(373, 65);
            this.TitleLb.TabIndex = 0;
            this.TitleLb.Text = "Form Life Cycle";
            // 
            // RtbFormEvent
            // 
            this.RtbFormEvent.BackColor = System.Drawing.SystemColors.Window;
            this.RtbFormEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RtbFormEvent.Cursor = System.Windows.Forms.Cursors.Default;
            this.RtbFormEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtbFormEvent.HideSelection = false;
            this.RtbFormEvent.Location = new System.Drawing.Point(12, 155);
            this.RtbFormEvent.Name = "RtbFormEvent";
            this.RtbFormEvent.ReadOnly = true;
            this.RtbFormEvent.Size = new System.Drawing.Size(357, 214);
            this.RtbFormEvent.TabIndex = 1;
            this.RtbFormEvent.Text = "";
            // 
            // CreateNewFrmBtn
            // 
            this.CreateNewFrmBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewFrmBtn.Location = new System.Drawing.Point(34, 384);
            this.CreateNewFrmBtn.Name = "CreateNewFrmBtn";
            this.CreateNewFrmBtn.Size = new System.Drawing.Size(225, 72);
            this.CreateNewFrmBtn.TabIndex = 2;
            this.CreateNewFrmBtn.Text = "Tạo Form";
            this.CreateNewFrmBtn.UseVisualStyleBackColor = true;
            this.CreateNewFrmBtn.Click += new System.EventHandler(this.CreateNewFrmBtn_Click);
            // 
            // frmEventLB
            // 
            this.frmEventLB.AutoSize = true;
            this.frmEventLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmEventLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.frmEventLB.Location = new System.Drawing.Point(7, 123);
            this.frmEventLB.Name = "frmEventLB";
            this.frmEventLB.Size = new System.Drawing.Size(246, 29);
            this.frmEventLB.TabIndex = 3;
            this.frmEventLB.Text = "Các sự kiện được lưu: ";
            // 
            // DeleteEventHistoryLlb
            // 
            this.DeleteEventHistoryLlb.AutoSize = true;
            this.DeleteEventHistoryLlb.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteEventHistoryLlb.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DeleteEventHistoryLlb.Location = new System.Drawing.Point(7, 9);
            this.DeleteEventHistoryLlb.Name = "DeleteEventHistoryLlb";
            this.DeleteEventHistoryLlb.Size = new System.Drawing.Size(164, 28);
            this.DeleteEventHistoryLlb.TabIndex = 4;
            this.DeleteEventHistoryLlb.TabStop = true;
            this.DeleteEventHistoryLlb.Text = "Xóa lịch sử sự kiện";
            this.DeleteEventHistoryLlb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeleteEventHistoryLlb_LinkClicked);
            // 
            // FormLifeCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(405, 482);
            this.Controls.Add(this.DeleteEventHistoryLlb);
            this.Controls.Add(this.frmEventLB);
            this.Controls.Add(this.CreateNewFrmBtn);
            this.Controls.Add(this.RtbFormEvent);
            this.Controls.Add(this.TitleLb);
            this.Name = "FormLifeCircle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLb;
        private System.Windows.Forms.RichTextBox RtbFormEvent;
        private System.Windows.Forms.Button CreateNewFrmBtn;
        private System.Windows.Forms.Label frmEventLB;
        private System.Windows.Forms.LinkLabel DeleteEventHistoryLlb;
    }
}

