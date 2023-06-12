using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarSales
{
    public partial class Orderinformation : Form
    {
        private int userid;
        
        public Orderinformation()
        {
            InitializeComponent();
        }
        public Orderinformation(int userid)
        {
            this.userid = userid;
            InitializeComponent();
            string customerName = FindUserRealName(userid);
            string connectStr = "server=47.113.148.155;port=3306;user=root;password=gNeTlc2dw6%g;database=CarSales";
            using (MySqlConnection myCon = new MySqlConnection(connectStr))
            {
                myCon.Open();
                // 在 Order 表中查找 customer_real_name 为指定值的数据的 cars_id
                string orderIdQuery = "SELECT cars_id FROM `Order` WHERE customer_real_name = @customerName";
                using (MySqlCommand orderIdCmd = new MySqlCommand(orderIdQuery, myCon))
                {
                    orderIdCmd.Parameters.AddWithValue("@customerName", customerName);
                    List<int> carsIds = new List<int>();

                    using (MySqlDataReader orderIdReader = orderIdCmd.ExecuteReader())
                    {
                        while (orderIdReader.Read())
                        {
                            int carsId = orderIdReader.GetInt32("cars_id");
                            carsIds.Add(carsId);
                        }
                    }

                    foreach (int carsId in carsIds)
                    {
                        // 根据 cars_id 在 cars 表中查找对应的数据
                        string carQuery = "SELECT * FROM cars WHERE id = @carsId";
                        using (MySqlCommand carCmd = new MySqlCommand(carQuery, myCon))
                        {
                            carCmd.Parameters.AddWithValue("@carsId", carsId);
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(carCmd))
                            {
                                // 创建 DataTable 对象
                                DataTable dataTable1 = new DataTable();
                                // 填充 DataTable
                                adapter.Fill(dataTable1);
                                // 将 DataTable 绑定到 DataGridView 控件
                                dataGridView1.DataSource = dataTable1;
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
                    }
                }
                myCon.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e) 
        {
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            // 通过索引获取选中行的数据
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
            string detail = selectedRow.Cells["detail"].Value.ToString();
            textBox1.Text = detail;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            // 通过索引获取选中行的数据
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
            string carId = selectedRow.Cells["id"].Value.ToString(); 
            string connectStr = "server=47.113.148.155;port=3306;user=root;password=gNeTlc2dw6%g;database=CarSales";
            using (MySqlConnection myCon = new MySqlConnection(connectStr))
            {
                myCon.Open();

                // 删除 "order" 表中 "cars_id" 为特定值的数据
                string deleteQuery = "DELETE FROM `Order` WHERE cars_id = @carId";
                using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, myCon))
                {
                    deleteCmd.Parameters.AddWithValue("@carId", carId);
                    deleteCmd.ExecuteNonQuery();
                }
                myCon.Close();
            }
            using (MySqlConnection myCon = new MySqlConnection(connectStr))
            {
                myCon.Open();

                // 更新 "cars" 表中 "id" 为特定值的数据的 "is_available" 列为 1
                string updateQuery = "UPDATE cars SET is_available = 1 WHERE id = @carId";
                using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, myCon))
                {
                    updateCmd.Parameters.AddWithValue("@carId", carId);
                    updateCmd.ExecuteNonQuery();
                }
                myCon.Close();
            }
        }
        public string FindUserRealName(int userid)
        {
            string connectStr = "server=47.113.148.155;port=3306;user=root;password=gNeTlc2dw6%g;database=CarSales";
            string realName = string.Empty;
            using (MySqlConnection myCon = new MySqlConnection(connectStr))
            {
                myCon.Open();
                string query = "SELECT real_name FROM user WHERE id = @userid";
                using (MySqlCommand myCmd = new MySqlCommand(query, myCon))
                {
                    myCmd.Parameters.AddWithValue("@userid", userid);

                    using (MySqlDataReader myReader = myCmd.ExecuteReader())
                    {
                        if (myReader.Read())
                        {
                            realName = myReader.GetString("real_name");
                        }
                        else
                        {
                            Console.WriteLine("No user found with ID: " + userid);
                        }
                    }
                }
                myCon.Close();
            }
            return realName;
        }
    }
}