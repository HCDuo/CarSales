
using System.Drawing;
using System.Windows.Forms;

namespace CarSales
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_Baco = new System.Windows.Forms.Button();
            this.btn_Ltime = new System.Windows.Forms.Button();
            this.Account = new System.Windows.Forms.Button();
            this.Orderinformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Baco
            // 
            this.btn_Baco.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Baco.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F);
            this.btn_Baco.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Baco.Location = new System.Drawing.Point(581, 1);
            this.btn_Baco.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Baco.Name = "btn_Baco";
            this.btn_Baco.Size = new System.Drawing.Size(334, 146);
            this.btn_Baco.TabIndex = 5;
            this.btn_Baco.Text = "出售车辆";
            this.btn_Baco.UseVisualStyleBackColor = false;
            this.btn_Baco.Click += new System.EventHandler(this.btn_sell_Click);
            // 
            // btn_Ltime
            // 
            this.btn_Ltime.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Ltime.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F);
            this.btn_Ltime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Ltime.Location = new System.Drawing.Point(-2, 1);
            this.btn_Ltime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Ltime.Name = "btn_Ltime";
            this.btn_Ltime.Size = new System.Drawing.Size(579, 448);
            this.btn_Ltime.TabIndex = 3;
            this.btn_Ltime.Text = "寻找心仪的车辆";
            this.btn_Ltime.UseVisualStyleBackColor = false;
            this.btn_Ltime.Click += new System.EventHandler(this.btn_purchase_Click);
            // 
            // Account
            // 
            this.Account.BackColor = System.Drawing.SystemColors.Control;
            this.Account.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Account.Location = new System.Drawing.Point(582, 154);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(333, 143);
            this.Account.TabIndex = 6;
            this.Account.Text = "查看个人信息";
            this.Account.UseVisualStyleBackColor = false;
            this.Account.Click += new System.EventHandler(this.button1_Click);
            // 
            // Orderinformation
            // 
            this.Orderinformation.BackColor = System.Drawing.SystemColors.Control;
            this.Orderinformation.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Orderinformation.Location = new System.Drawing.Point(581, 303);
            this.Orderinformation.Name = "Orderinformation";
            this.Orderinformation.Size = new System.Drawing.Size(334, 146);
            this.Orderinformation.TabIndex = 7;
            this.Orderinformation.Text = "订单信息";
            this.Orderinformation.UseVisualStyleBackColor = false;
            this.Orderinformation.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 448);
            this.Controls.Add(this.Orderinformation);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.btn_Baco);
            this.Controls.Add(this.btn_Ltime);
            this.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button Orderinformation;

        #endregion
        private System.Windows.Forms.Button Account;
        private System.Windows.Forms.Button btn_Baco;
        private System.Windows.Forms.Button btn_Ltime;
    }
}