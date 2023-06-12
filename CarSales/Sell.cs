using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CarSales
{
    public partial class Sell : Form
    {
        public Sell()
        {
            InitializeComponent();
        }
        private void btn_Refer_Click(object sender, EventArgs e)
        {
            if (Brand.Text == "" || 
                Type.Text == "" ||
                year.Text == "" || 
                seller_real_name.Text == "" || 
                Price.Text == "" )
            {
                MessageBox.Show("注：带*号的为必填！请输入");
            }
            else
            {
                string connetStr = "server=47.113.148.155;port=3306;user=root;password=gNeTlc2dw6%g;database=CarSales";
                //usr:用户名，password：数据库密码，database;
                MySqlConnection myCon = new MySqlConnection(connetStr);
                myCon.Open();
                var sql = "insert into cars (seller_real_name, car_brand, model, car_purchase_money, years, detail) VALUES('" + 
                seller_real_name.Text + "','" + 
                Brand.Text + "','" + 
                Type.Text + "','" +
                Price.Text + "','" +
                year.Text + "','" +
                details.Text + 
                "')";
                MySqlCommand myCom = new MySqlCommand(sql, myCon);
                myCom.ExecuteNonQuery();
                MessageBox.Show("提交成功！");
                Hide();
                myCon.Close();
            }
        }
        
    }
}