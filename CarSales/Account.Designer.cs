using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CarSales
{
    partial class Account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.delete_car = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.address = new System.Windows.Forms.RichTextBox();
            this.sex = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.realname = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.delete_user = new System.Windows.Forms.Button();
            this.modify_user = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sell = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.delete_car.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sell)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // delete_car
            // 
            this.delete_car.Controls.Add(this.button2);
            this.delete_car.Controls.Add(this.button1);
            this.delete_car.Controls.Add(this.address);
            this.delete_car.Controls.Add(this.sex);
            this.delete_car.Controls.Add(this.phone);
            this.delete_car.Controls.Add(this.realname);
            this.delete_car.Controls.Add(this.username);
            this.delete_car.Controls.Add(this.delete_user);
            this.delete_car.Controls.Add(this.modify_user);
            this.delete_car.Controls.Add(this.label5);
            this.delete_car.Controls.Add(this.label4);
            this.delete_car.Controls.Add(this.label3);
            this.delete_car.Controls.Add(this.label2);
            this.delete_car.Controls.Add(this.label1);
            this.delete_car.Location = new System.Drawing.Point(1, 4);
            this.delete_car.Name = "delete_car";
            this.delete_car.Size = new System.Drawing.Size(278, 445);
            this.delete_car.TabIndex = 0;
            this.delete_car.TabStop = false;
            this.delete_car.Text = "个人信息";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 40);
            this.button2.TabIndex = 14;
            this.button2.Text = "查看车辆";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "取消售出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.delete_car_Click);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(87, 220);
            this.address.Multiline = false;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(139, 79);
            this.address.TabIndex = 12;
            this.address.Text = "";
            // 
            // sex
            // 
            this.sex.Location = new System.Drawing.Point(126, 171);
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            this.sex.Size = new System.Drawing.Size(100, 25);
            this.sex.TabIndex = 10;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(126, 127);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(100, 25);
            this.phone.TabIndex = 9;
            // 
            // realname
            // 
            this.realname.Location = new System.Drawing.Point(126, 82);
            this.realname.Name = "realname";
            this.realname.Size = new System.Drawing.Size(100, 25);
            this.realname.TabIndex = 8;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(126, 39);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 25);
            this.username.TabIndex = 7;
            // 
            // delete_user
            // 
            this.delete_user.Location = new System.Drawing.Point(151, 315);
            this.delete_user.Name = "delete_user";
            this.delete_user.Size = new System.Drawing.Size(88, 40);
            this.delete_user.TabIndex = 6;
            this.delete_user.Text = "注销账号";
            this.delete_user.UseVisualStyleBackColor = true;
            this.delete_user.Click += new System.EventHandler(this.delete_Click);
            // 
            // modify_user
            // 
            this.modify_user.Location = new System.Drawing.Point(20, 315);
            this.modify_user.Name = "modify_user";
            this.modify_user.Size = new System.Drawing.Size(91, 40);
            this.modify_user.TabIndex = 5;
            this.modify_user.Text = "修改信息";
            this.modify_user.UseVisualStyleBackColor = true;
            this.modify_user.Click += new System.EventHandler(this.modify_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(44, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "地址";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(44, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "性别";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(11, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "电话号码";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "真实名字";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(44, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号";
            // 
            // sell
            // 
            this.sell.AllowUserToAddRows = false;
            this.sell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sell.Location = new System.Drawing.Point(285, 12);
            this.sell.Name = "sell";
            this.sell.ReadOnly = true;
            this.sell.RowTemplate.Height = 27;
            this.sell.Size = new System.Drawing.Size(503, 291);
            this.sell.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(285, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 130);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "详情";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(491, 100);
            this.textBox1.TabIndex = 0;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sell);
            this.Controls.Add(this.delete_car);
            this.Name = "Account";
            this.Text = "Account";
            this.delete_car.ResumeLayout(false);
            this.delete_car.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sell)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }
        

        #endregion
        
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView sell;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox realname;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox sex;
        private System.Windows.Forms.RichTextBox address;
        private System.Windows.Forms.Button modify_user;
        private System.Windows.Forms.Button delete_user;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox delete_car;
    }
}