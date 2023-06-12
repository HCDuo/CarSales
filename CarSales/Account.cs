using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CarSales
{
    public partial class Account : Form
    {
        private int userid;
        private string sellname;
        public Account()
        {
            InitializeComponent();
            
        }
        
        public Account(int userid)
        {
            this.userid = userid;
            InitializeComponent();
            //显示任务信息
            string connectStr = "server=47.113.148.155;port=3306;user=root;password=gNeTlc2dw6%g;database=CarSales";
            string userid1 = userid.ToString();
            using (MySqlConnection myCon = new MySqlConnection(connectStr))
            {
                myCon.Open();
                string query = "SELECT * FROM user WHERE id = @user_id";
                using (MySqlCommand myCmd = new MySqlCommand(query, myCon))
                {
                    myCmd.Parameters.AddWithValue("@user_id", userid1);
                    using (MySqlDataReader myReader = myCmd.ExecuteReader())
                    {
                        if (myReader.Read())
                        {
                            string username1 = myReader.GetString("username");
                            username.Text = username1;
                            string realname1 = myReader.GetString("real_name");
                            realname.Text = realname1;
                            sellname = realname1;
                            string phone1 = myReader.GetString("phone_number");
                            phone.Text = phone1;
                            int sex1 = myReader.GetInt16("sex");
                            if (sex1 == 1)
                            {
                                sex.Text = "男";
                            }
                            else
                            {
                                sex.Text = "女";
                            }
                            
                            string address1 = myReader.GetString("address");
                            address.Text = address1;
                        }
                        else
                        {
                            Console.WriteLine("No user found with ID: " + userid);
                        }
                    } 
                }
                myCon.Close();
            }
            //显示车辆信息
            string connectStr1 = "server=47.113.148.155;port=3306;user=root;password=gNeTlc2dw6%g;database=CarSales";
            string query1 = "SELECT * FROM cars WHERE 1=1";
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            query1 += " AND seller_real_name = @seller_real_name";
            parameters.Add(new MySqlParameter("@seller_real_name", sellname));
            using (MySqlConnection connection = new MySqlConnection(connectStr1))
            {
                // 打开连接
                connection.Open();
                // 创建 MySQL 命令对象
                using (MySqlCommand command = new MySqlCommand(query1, connection))
                {
                    // 添加参数到命令对象
                    command.Parameters.AddRange(parameters.ToArray());

                    // 创建数据适配器
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        // 创建 DataTable 对象
                        DataTable dataTable = new DataTable();
                        // 填充 DataTable
                        adapter.Fill(dataTable);
                        // 将 DataTable 绑定到 DataGridView 控件
                        sell.DataSource = dataTable;
                        sell.Columns[0].HeaderText = "车辆id";
                        sell.Columns[1].HeaderText = "卖主名字";
                        sell.Columns[2].HeaderText = "车厂";
                        sell.Columns[3].HeaderText = "型号";
                        sell.Columns[4].HeaderText = "价格";
                        sell.Columns[5].HeaderText = "年份";
                        sell.Columns[6].Visible = false;
                        sell.Columns[7].HeaderText = "是否可售";
                    }
                }
                connection.Close();
            }
        }

        private void modify_Click(object sender, EventArgs e)
        {
            string user_name = username.Text;
            string read_name = realname.Text;
            string ph = phone.Text;
            string addr = address.Text;
            if (Regex.IsMatch(ph, @"^1(3\d|5\d|7[6-8]|8\d)\d{8}$"))
            {
                string connectionString = "server=47.113.148.155;port=3306;user=root;password=gNeTlc2dw6%g;database=CarSales";
                MySqlConnection myCon = new MySqlConnection(connectionString);
                myCon.Open();
                string query = "update user t set t.username = '" + user_name + "', " + "t.real_name = '" + read_name +
                               "', "
                               + "t.phone_number = '" + ph + "', " + "t.address = '" + addr + "' where t.id = " +
                               userid + " ; ";
                MySqlCommand myCom = new MySqlCommand(query, myCon);
                myCom.ExecuteNonQuery();
                Hide();
                Account account = new Account(userid);
                account.ShowDialog();
                myCon.Close();
            }
            else
            {
                MessageBox.Show("注：电话号码注意正确！");
            }
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string connectStr = "server=47.113.148.155;port=3306;user=root;password=gNeTlc2dw6%g;database=CarSales";
            using (MySqlConnection myCon = new MySqlConnection(connectStr))
            {
                myCon.Open();
                string query = "DELETE FROM user WHERE id = @userId";
                using (MySqlCommand myCmd = new MySqlCommand(query, myCon))
                {
                    myCmd.Parameters.AddWithValue("@userId", userid);
                    myCmd.ExecuteNonQuery();
                }
                myCon.Close();
            }
            Login login = new Login();
            Hide();
            login.ShowDialog();
        }

        private void delete_car_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = sell.SelectedCells[0].RowIndex;
            // 通过索引获取选中行的数据
            DataGridViewRow selectedRow = sell.Rows[selectedRowIndex];
            string carid = selectedRow.Cells["id"].Value.ToString();
            string connectionString1 = "server=47.113.148.155;port=3306;user=root;password=gNeTlc2dw6%g;database=CarSales";
            string query1 = "DELETE FROM cars WHERE id = @carId";
            using (MySqlConnection connection = new MySqlConnection(connectionString1))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query1, connection))
                {
                    command.Parameters.AddWithValue("@carId", int.Parse(carid));
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            MessageBox.Show("成功撤销ID为 " + carid + " 的车辆的卖出。");
            Account account1 = new Account(userid);
            account1.ShowDialog();
        }
        

        private void button2_Click_1(object sender, EventArgs e)
        {
            int selectedRowIndex = sell.SelectedCells[0].RowIndex;
            // 通过索引获取选中行的数据
            DataGridViewRow selectedRow = sell.Rows[selectedRowIndex];
            string detail = selectedRow.Cells["detail"].Value.ToString();
            textBox1.Text = detail;
        }
    }
}