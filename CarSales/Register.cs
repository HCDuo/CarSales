using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CarSales
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

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
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("SHA1加密出错：" + ex.Message);
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            string connectionString = "server=47.113.148.155;port=3306;user=root;password=gNeTlc2dw6%g;database=CarSales";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                // 检查用户名是否已存在
                string checkUsernameQuery = "SELECT COUNT(*) FROM user WHERE username = @username";
                using (MySqlCommand checkUsernameCommand = new MySqlCommand(checkUsernameQuery, connection))
                {
                    checkUsernameCommand.Parameters.AddWithValue("@username", rgs_UserName.Text);
                    int usernameCount = Convert.ToInt32(checkUsernameCommand.ExecuteScalar());
                    
                    if (usernameCount > 0)
                    {
                        MessageBox.Show("该用户名已被使用！");
                        return;
                    }
                }
                if (string.IsNullOrWhiteSpace(rgs_UserName.Text) || string.IsNullOrWhiteSpace(rgs_PassWord.Text) ||
                    string.IsNullOrWhiteSpace(RealName.Text) || string.IsNullOrWhiteSpace(Phone.Text) ||
                    string.IsNullOrWhiteSpace(Confirm_password.Text))
                {
                    MessageBox.Show("注：请检查必填信息的正确性！");
                    return;
                }
                if (rgs_PassWord.Text != Confirm_password.Text)
                {
                    MessageBox.Show("请输入一样的密码");
                    return;
                }
                // 执行插入操作
                string insertQuery = "INSERT INTO user(username, password, real_name, phone_number, address, sex) " +
                                     "VALUES (@username, @password, @realName, @phoneNumber, @address, @sex)";
                using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@username", rgs_UserName.Text);
                    insertCommand.Parameters.AddWithValue("@password", Sha1(rgs_PassWord.Text).ToLower());
                    insertCommand.Parameters.AddWithValue("@realName", RealName.Text);
                    insertCommand.Parameters.AddWithValue("@phoneNumber", Phone.Text);
                    insertCommand.Parameters.AddWithValue("@address", Address.Text);
                    insertCommand.Parameters.AddWithValue("@sex", radioButton1.Checked);

                    insertCommand.ExecuteNonQuery();
                }
                MessageBox.Show("注册成功，请登录！");
                Hide();
            }
        }
    }
}