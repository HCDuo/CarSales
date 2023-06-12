using System.ComponentModel;

namespace CarSales
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.RePhoneNumber = new System.Windows.Forms.TextBox();
            this.ReUserName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newPassWord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.com_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RePhoneNumber
            // 
            this.RePhoneNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.RePhoneNumber.Location = new System.Drawing.Point(192, 143);
            this.RePhoneNumber.Name = "RePhoneNumber";
            this.RePhoneNumber.Size = new System.Drawing.Size(159, 33);
            this.RePhoneNumber.TabIndex = 9;
            // 
            // ReUserName
            // 
            this.ReUserName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.ReUserName.Location = new System.Drawing.Point(192, 74);
            this.ReUserName.Name = "ReUserName";
            this.ReUserName.Size = new System.Drawing.Size(159, 33);
            this.ReUserName.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.button1.Location = new System.Drawing.Point(192, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "重置密码";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label2.Location = new System.Drawing.Point(51, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "手机号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label1.Location = new System.Drawing.Point(71, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "账号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(51, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "新密码";
            // 
            // newPassWord
            // 
            this.newPassWord.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.newPassWord.Location = new System.Drawing.Point(192, 208);
            this.newPassWord.Name = "newPassWord";
            this.newPassWord.Size = new System.Drawing.Size(159, 33);
            this.newPassWord.TabIndex = 11;
            this.newPassWord.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(29, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 33);
            this.label4.TabIndex = 12;
            this.label4.Text = "确定密码";
            // 
            // com_password
            // 
            this.com_password.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.com_password.Location = new System.Drawing.Point(192, 281);
            this.com_password.Name = "com_password";
            this.com_password.Size = new System.Drawing.Size(159, 33);
            this.com_password.TabIndex = 13;
            this.com_password.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(140, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 45);
            this.label5.TabIndex = 14;
            this.label5.Text = "重置密码";
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(427, 448);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.com_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newPassWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RePhoneNumber);
            this.Controls.Add(this.ReUserName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ResetPassword";
            this.Text = "ResetPassWord";
            this.Load += new System.EventHandler(this.RePassWord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label5;

        #endregion

        private System.Windows.Forms.TextBox RePhoneNumber;
        private System.Windows.Forms.TextBox ReUserName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newPassWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox com_password;
    }
}