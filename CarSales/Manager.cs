using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;

namespace CarSales
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        //车辆查询
        private void button1_Click(object sender, EventArgs e)
        {
            Search_cars();
        }
        //删除车辆
        private void button2_Click(object sender, EventArgs e)
        {
            Delete_cars();
        }
        //查找用户
        private void button3_Click(object sender, EventArgs e)
        {
            Search_user();
        }
        //查找用户
        private void button4_Click(object sender, EventArgs e)
        {
            Delete_user();
        }
        
        private void Search_cars()
        {
            string connectStr = "server=47.113.148.155;port=3306;user=root;password=gNeTlc2dw6%g;database=CarSales";
            string query = "SELECT * FROM cars WHERE 1=1";
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            if (!string.IsNullOrEmpty(brand.Text))
            {
                query += " AND car_brand = @CarBrand";
                parameters.Add(new MySqlParameter("@CarBrand", brand.Text));
            }
            if (!string.IsNullOrEmpty(type.Text))
            {
                query += " AND model = @Type";
                parameters.Add(new MySqlParameter("@Type", type.Text));
            }
            if (!string.IsNullOrEmpty(Lowest_price.Text))
            {
                query += " AND car_purchase_money >= @LowestPrice";
                parameters.Add(new MySqlParameter("@LowestPrice", int.Parse(Lowest_price.Text)));
            }
            if (!string.IsNullOrEmpty(textBox4.Text))
            {
                query += " AND car_purchase_money <= @HighestPrice";
                parameters.Add(new MySqlParameter("@HighestPrice", int.Parse(textBox4.Text)));
            }
            using (MySqlConnection connection = new MySqlConnection(connectStr))
            {
                // 打开连接
                connection.Open();
                // 创建 MySQL 命令对象
                using (MySqlCommand command = new MySqlCommand(query, connection))
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
                        dataGridView1.DataSource = dataTable;
                        dataGridView1.Columns[0].HeaderText = "车辆id";
                        dataGridView1.Columns[1].HeaderText = "卖主名字";
                        dataGridView1.Columns[2].HeaderText = "车厂";
                        dataGridView1.Columns[3].HeaderText = "型号";
                        dataGridView1.Columns[4].HeaderText = "价格";
                        dataGridView1.Columns[5].HeaderText = "年份";
                        dataGridView1.Columns[6].Visible = false;
                        dataGridView1.Columns[7].HeaderText = "是否可售";
                    }
                }
                connection.Close();
            }
        }

        private void Delete_cars()
        {
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            // 通过索引获取选中行的数据
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
            string carId = selectedRow.Cells["id"].Value.ToString(); 
            string is_available = selectedRow.Cells["is_available"].Value.ToString();
            if (int.Parse(is_available) == 0)
            {
                MessageBox.Show("汽车ID为 " + carId + " 的汽车已售出，无法删除。");
            }
            else
            {
                string connectionString1 = "server=47.113.148.155;port=3306;user=root;password=gNeTlc2dw6%g;database=CarSales";
                string query1 = "DELETE FROM cars WHERE id = @carId";
                using (MySqlConnection connection = new MySqlConnection(connectionString1))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query1, connection))
                    {
                        command.Parameters.AddWithValue("@CarId", int.Parse(carId));
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                MessageBox.Show("成功删除汽车ID为 " + carId + " 的汽车。");
            }
            
        }
        private void Search_user()
        {
            string connectStr = "server=47.113.148.155;port=3306;user=root;password=gNeTlc2dw6%g;database=CarSales";
            string query = "SELECT * FROM user WHERE 1=1";
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            if (!string.IsNullOrEmpty(username.Text))
            {
                query += " AND username = @username";
                parameters.Add(new MySqlParameter("@username", username.Text));
            }
            if (!string.IsNullOrEmpty(real_name.Text))
            {
                query += " AND real_name = @real_name";
                parameters.Add(new MySqlParameter("@real_name", real_name.Text));
            }
            if (!string.IsNullOrEmpty(phone_number.Text))
            {
                query += " AND phone_number = @phone_number";
                parameters.Add(new MySqlParameter("@phone_number", phone_number.Text));
            }
            using (MySqlConnection connection = new MySqlConnection(connectStr))
            {
                // 打开连接
                connection.Open();
                // 创建 MySQL 命令对象
                using (MySqlCommand command = new MySqlCommand(query, connection))
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
                        dataGridView2.DataSource = dataTable;
                        dataGridView2.Columns[0].HeaderText = "用户id";
                        dataGridView2.Columns[1].HeaderText = "用户名字";
                        dataGridView2.Columns[2].Visible = false;
                        dataGridView2.Columns[3].HeaderText = "真实名字";
                        dataGridView2.Columns[4].HeaderText = "电话号码";
                        dataGridView2.Columns[5].HeaderText = "性别";
                        dataGridView2.Columns[6].HeaderText = "地址";
                    }
                }
                connection.Close();
            }
        }

        private void Delete_user()
        {
            int selectedRowIndex = dataGridView2.SelectedCells[0].RowIndex;
            // 通过索引获取选中行的数据
            DataGridViewRow selectedRow = dataGridView2.Rows[selectedRowIndex];
            string userId = selectedRow.Cells["id"].Value.ToString();
            string connectionString1 = "server=47.113.148.155;port=3306;user=root;password=gNeTlc2dw6%g;database=CarSales";
            string query1 = "DELETE FROM user WHERE id = @userId";
            using (MySqlConnection connection = new MySqlConnection(connectionString1))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query1, connection))
                {
                    command.Parameters.AddWithValue("@userId", int.Parse(userId));
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            MessageBox.Show("成功删除ID为 " + userId + " 的用户。");
        }
    }
}