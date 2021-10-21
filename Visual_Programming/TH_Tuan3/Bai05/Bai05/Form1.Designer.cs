
namespace Bai05
{
    partial class Form1
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
            this.btn_Plus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Num1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Num2 = new System.Windows.Forms.TextBox();
            this.btn_Sub = new System.Windows.Forms.Button();
            this.btn_Dup = new System.Windows.Forms.Button();
            this.btn_Div = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Answer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Plus
            // 
            this.btn_Plus.Location = new System.Drawing.Point(92, 171);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(40, 40);
            this.btn_Plus.TabIndex = 0;
            this.btn_Plus.Text = "+";
            this.btn_Plus.UseVisualStyleBackColor = true;
            this.btn_Plus.Click += new System.EventHandler(this.btn_Plus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number 1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_Num1
            // 
            this.tb_Num1.Location = new System.Drawing.Point(181, 55);
            this.tb_Num1.Name = "tb_Num1";
            this.tb_Num1.Size = new System.Drawing.Size(174, 22);
            this.tb_Num1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number 2:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_Num2
            // 
            this.tb_Num2.Location = new System.Drawing.Point(181, 108);
            this.tb_Num2.Name = "tb_Num2";
            this.tb_Num2.Size = new System.Drawing.Size(174, 22);
            this.tb_Num2.TabIndex = 2;
            // 
            // btn_Sub
            // 
            this.btn_Sub.Location = new System.Drawing.Point(167, 171);
            this.btn_Sub.Name = "btn_Sub";
            this.btn_Sub.Size = new System.Drawing.Size(40, 40);
            this.btn_Sub.TabIndex = 0;
            this.btn_Sub.Text = "-";
            this.btn_Sub.UseVisualStyleBackColor = true;
            this.btn_Sub.Click += new System.EventHandler(this.btn_Sub_Click);
            // 
            // btn_Dup
            // 
            this.btn_Dup.Location = new System.Drawing.Point(242, 171);
            this.btn_Dup.Name = "btn_Dup";
            this.btn_Dup.Size = new System.Drawing.Size(40, 40);
            this.btn_Dup.TabIndex = 0;
            this.btn_Dup.Text = "X";
            this.btn_Dup.UseVisualStyleBackColor = true;
            this.btn_Dup.Click += new System.EventHandler(this.btn_Dup_Click);
            // 
            // btn_Div
            // 
            this.btn_Div.Location = new System.Drawing.Point(315, 171);
            this.btn_Div.Name = "btn_Div";
            this.btn_Div.Size = new System.Drawing.Size(40, 40);
            this.btn_Div.TabIndex = 0;
            this.btn_Div.Text = "/";
            this.btn_Div.UseVisualStyleBackColor = true;
            this.btn_Div.Click += new System.EventHandler(this.btn_Div_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Answer:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_Answer
            // 
            this.tb_Answer.Location = new System.Drawing.Point(181, 241);
            this.tb_Answer.Name = "tb_Answer";
            this.tb_Answer.Size = new System.Drawing.Size(174, 22);
            this.tb_Answer.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 313);
            this.Controls.Add(this.tb_Answer);
            this.Controls.Add(this.tb_Num2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Num1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Div);
            this.Controls.Add(this.btn_Dup);
            this.Controls.Add(this.btn_Sub);
            this.Controls.Add(this.btn_Plus);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Plus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Num1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Num2;
        private System.Windows.Forms.Button btn_Sub;
        private System.Windows.Forms.Button btn_Dup;
        private System.Windows.Forms.Button btn_Div;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Answer;
    }
}

