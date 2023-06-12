using System.ComponentModel;

namespace CarSales
{
    partial class Sell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sell));
            this.Price = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Refer = new System.Windows.Forms.Button();
            this.details = new System.Windows.Forms.TextBox();
            this.seller_real_name = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.TextBox();
            this.Brand = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.Price.Location = new System.Drawing.Point(487, 190);
            this.Price.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(111, 33);
            this.Price.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label8.Location = new System.Drawing.Point(337, 196);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 27);
            this.label8.TabIndex = 33;
            this.label8.Text = "车辆价格*";
            // 
            // btn_Refer
            // 
            this.btn_Refer.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btn_Refer.Location = new System.Drawing.Point(260, 391);
            this.btn_Refer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Refer.Name = "btn_Refer";
            this.btn_Refer.Size = new System.Drawing.Size(129, 45);
            this.btn_Refer.TabIndex = 30;
            this.btn_Refer.Text = "提交";
            this.btn_Refer.UseVisualStyleBackColor = true;
            this.btn_Refer.Click += new System.EventHandler(this.btn_Refer_Click);
            // 
            // details
            // 
            this.details.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.details.Location = new System.Drawing.Point(412, 257);
            this.details.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.details.Multiline = true;
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(186, 92);
            this.details.TabIndex = 29;
            // 
            // seller_real_name
            // 
            this.seller_real_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.seller_real_name.Location = new System.Drawing.Point(487, 126);
            this.seller_real_name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.seller_real_name.Name = "seller_real_name";
            this.seller_real_name.Size = new System.Drawing.Size(111, 33);
            this.seller_real_name.TabIndex = 28;
            // 
            // year
            // 
            this.year.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.year.Location = new System.Drawing.Point(178, 257);
            this.year.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(111, 33);
            this.year.TabIndex = 27;
            // 
            // Type
            // 
            this.Type.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.Type.Location = new System.Drawing.Point(178, 190);
            this.Type.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(111, 33);
            this.Type.TabIndex = 26;
            // 
            // Brand
            // 
            this.Brand.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.Brand.Location = new System.Drawing.Point(178, 126);
            this.Brand.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(111, 33);
            this.Brand.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label7.Location = new System.Drawing.Point(337, 263);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 27);
            this.label7.TabIndex = 24;
            this.label7.Text = "详情";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label6.Location = new System.Drawing.Point(337, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 27);
            this.label6.TabIndex = 23;
            this.label6.Text = "车主真实名字*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label4.Location = new System.Drawing.Point(19, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 27);
            this.label4.TabIndex = 21;
            this.label4.Text = "车辆年份(YY)*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label3.Location = new System.Drawing.Point(19, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 27);
            this.label3.TabIndex = 20;
            this.label3.Text = "车辆型号*";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label2.Location = new System.Drawing.Point(19, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 27);
            this.label2.TabIndex = 19;
            this.label2.Text = "车辆品牌*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F);
            this.label1.Location = new System.Drawing.Point(190, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 50);
            this.label1.TabIndex = 18;
            this.label1.Text = "请填写车辆信息";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label5.Location = new System.Drawing.Point(447, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 27);
            this.label5.TabIndex = 35;
            this.label5.Text = "注：带*号为必填";
            // 
            // Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(672, 448);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Refer);
            this.Controls.Add(this.details);
            this.Controls.Add(this.seller_real_name);
            this.Controls.Add(this.year);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sell";
            this.Text = "sell";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Refer;
        private System.Windows.Forms.TextBox details;
        private System.Windows.Forms.TextBox seller_real_name;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.TextBox Brand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}