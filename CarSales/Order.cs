using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarSales
{
    public partial class Order : Form
    {
        private string carId;
        public Order()
        {
            InitializeComponent();
        }
        public Order(string carId)
        {
            InitializeComponent();
            this.carId = carId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //加入订单数据表
            string connectionString = "server=47.113.148.155;port=3306;user=root;password=gNeTlc2dw6%g;database=CarSales";
            string query = "INSERT INTO `Order` (cars_id,customer_real_name) VALUES (@CarId,@customer_real_name)";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@customer_real_name",customer_real_name.Text);
                    command.Parameters.AddWithValue("@CarId", int.Parse(carId));
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            //加入车辆数据表
            string connectionString1 = "server=47.113.148.155;port=3306;user=root;password=gNeTlc2dw6%g;database=CarSales";
            string query1 = "UPDATE cars SET is_available = 0 WHERE id = @CarId";
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
            Hide();
        }
    }
}