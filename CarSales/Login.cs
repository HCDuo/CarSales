using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;


namespace CarSales
{
    public partial class Login : Form
    {
        private int userid;
        public Login()
        {
            InitializeComponent();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                bool isRight = false;
                //如果其中任意一个为空，弹出消息框提醒用户输入。
                if (log_UserName.Text == "" || log_PassWord.Text == "")
                {
                    MessageBox.Show("用户名和密码都不能为为空！请重新输入：");
                }
                else if (radioButton1.Checked)
                {
                    string connectionString = "server=47.113.148.155;port=3306;user=root;password=gNeTlc2dw6%g;database=CarSales";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT * FROM manager WHERE username = @username AND password = @password";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@username", log_UserName.Text);
                        command.Parameters.AddWithValue("@password", log_PassWord.Text);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isRight = true;
                                Manager manager1 = new Manager();
                                Hide();
                                manager1.ShowDialog();
                                Application.ExitThread();
                            }
                            else
                            {
                                MessageBox.Show("出错了！！！请重新输入");
                            }
                        }
                        connection.Close();
                    }
                }
                else
                {
                    string connectionString = "server=47.113.148.155;port=3306;user=root;password=gNeTlc2dw6%g;database=CarSales";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT * FROM user WHERE username = @username AND password = @password";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@username", log_UserName.Text);
                        command.Parameters.AddWithValue("@password", Sha1(log_PassWord.Text).ToLower());
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isRight = true;
                                userid = reader.GetInt16(0);
                                Main main = new Main(userid);
                                Hide();
                                main.ShowDialog();
                                Application.ExitThread();
                            }
                            else
                            {
                                MessageBox.Show("账号或密码输入错误！请重新输入：");
                            }
                        }
                        connection.Close();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //加密算法
        private static string Sha1(string content)
        {
            return Sha1(content, Encoding.UTF8);
        }

        private static string Sha1(string content, Encoding encode)
        {
            try
            {
                SHA1 sha1 = new SHA1CryptoServiceProvider();
                byte[] bytesIn = encode.GetBytes(content);
                byte[] bytesOut = sha1.ComputeHash(bytesIn);
                sha1.Dispose();
                string result = BitConverter.ToString(bytesOut);
                result = result.Replace("-", "");
                // MessageBox.Show(result);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("SHA1加密出错：" + ex.Message);
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void btn_ForgetPassword_Click(object sender, EventArgs e)
        {
            ResetPassword resetPassword = new ResetPassword();
            resetPassword.ShowDialog();
        }
    }
}