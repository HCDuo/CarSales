using System.Drawing;

namespace CarSales
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_ForgetPassword = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.log_PassWord = new System.Windows.Forms.TextBox();
            this.log_UserName = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(127, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 36);
            this.label3.TabIndex = 15;
            this.label3.Text = "车辆交易市场";
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(127, 284);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(91, 44);
            this.btn_Register.TabIndex = 14;
            this.btn_Register.Text = "注册";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_ForgetPassword
            // 
            this.btn_ForgetPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.btn_ForgetPassword.Location = new System.Drawing.Point(235, 284);
            this.btn_ForgetPassword.Name = "btn_ForgetPassword";
            this.btn_ForgetPassword.Size = new System.Drawing.Size(91, 44);
            this.btn_ForgetPassword.TabIndex = 13;
            this.btn_ForgetPassword.Text = "忘记密码";
            this.btn_ForgetPassword.UseVisualStyleBackColor = true;
            this.btn_ForgetPassword.Click += new System.EventHandler(this.btn_ForgetPassword_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(127, 234);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(199, 34);
            this.btn_Login.TabIndex = 12;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label2.Location = new System.Drawing.Point(46, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label1.Location = new System.Drawing.Point(46, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "账号";
            // 
            // log_PassWord
            // 
            this.log_PassWord.Location = new System.Drawing.Point(127, 160);
            this.log_PassWord.Name = "log_PassWord";
            this.log_PassWord.Size = new System.Drawing.Size(199, 25);
            this.log_PassWord.TabIndex = 9;
            this.log_PassWord.UseSystemPasswordChar = true;
            // 
            // log_UserName
            // 
            this.log_UserName.Location = new System.Drawing.Point(127, 93);
            this.log_UserName.Name = "log_UserName";
            this.log_UserName.Size = new System.Drawing.Size(199, 25);
            this.log_UserName.TabIndex = 8;
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(181, 204);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 24);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "管理员";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(417, 340);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_ForgetPassword);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.log_PassWord);
            this.Controls.Add(this.log_UserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_ForgetPassword;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox log_PassWord;
        private System.Windows.Forms.TextBox log_UserName;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}