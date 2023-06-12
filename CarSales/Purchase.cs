using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarSales
{
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void Search()
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
            if (!string.IsNullOrEmpty(highest_price.Text))
            {
                query += " AND car_purchase_money <= @HighestPrice";
                parameters.Add(new MySqlParameter("@HighestPrice", int.Parse(highest_price.Text)));
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

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            // 通过索引获取选中行的数据
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
            string carId = selectedRow.Cells["id"].Value.ToString(); 
            string is_available = selectedRow.Cells["is_available"].Value.ToString();
            // ...
            // 执行操作
            // 可以使用选中行的数据进行你想要的操作
            if (int.Parse(is_available) == 1)
            {
                Order order1 = new Order(carId);
                order1.ShowDialog();
                MessageBox.Show("你购买了汽车ID为 " + carId + " 的汽车。");
            }
            else
            {
                MessageBox.Show("无法购买了汽车ID为 " + carId + " 的汽车。");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            // 通过索引获取选中行的数据
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
            string detail = selectedRow.Cells["detail"].Value.ToString();
            textBox1.Text = detail;
        }
    }
}