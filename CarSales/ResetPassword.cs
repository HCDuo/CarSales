using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarSales
{
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }
        private void RePassWord_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connectStr = "server=47.113.148.155;port=3306;user=root;password=gNeTlc2dw6%g;database=CarSales";
            if (string.IsNullOrEmpty(ReUserName.Text) || string.IsNullOrEmpty(RePhoneNumber.Text) || string.IsNullOrEmpty(newPassWord.Text))
            {
                MessageBox.Show("用户名、手机号和新密码均不能为空！");
                return;
            }
            using (MySqlConnection myCon = new MySqlConnection(connectStr))
            {
                myCon.Open();
                string query = "SELECT * FROM user WHERE username = @username";
                using (MySqlCommand myCmd = new MySqlCommand(query, myCon))
                {
                    myCmd.Parameters.AddWithValue("@username", ReUserName.Text);
                    using (MySqlDataReader myReader = myCmd.ExecuteReader())
                    {
                        if (myReader.Read())
                        {
                            string storedUsername = myReader.GetString("username");
                            string storedPhoneNumber = myReader.GetString("phone_number");
                            string storedPassword = myReader.GetString("password");
                            if (ReUserName.Text == storedUsername && RePhoneNumber.Text == storedPhoneNumber &&
                                RePhoneNumber.Text == com_password.Text && !string.IsNullOrEmpty(newPassWord.Text))
                            {
                                string newPasswordHash = Sha1(newPassWord.Text).ToLower();
                                if (storedPassword == newPasswordHash)
                                {
                                    MessageBox.Show("新密码不能与原密码相同！");
                                    return;
                                }
                                myReader.Close();
                                string updateQuery = "UPDATE user SET password = @newPassword WHERE username = @username";
                                using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, myCon))
                                {
                                    updateCmd.Parameters.AddWithValue("@newPassword", newPasswordHash);
                                    updateCmd.Parameters.AddWithValue("@username", ReUserName.Text);
                                    try
                                    {
                                        updateCmd.ExecuteNonQuery();
                                        MessageBox.Show("密码重置成功");
                                    }
                                    catch (MySqlException ex)
                                    {
                                        MessageBox.Show("密码重置失败：" + ex.Message);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("用户名、手机号或密码输入错误！");
                            }
                        }
                        else
                        {
                            MessageBox.Show("用户名不存在！");
                        }
                    }
                }
            }
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
                //MessageBox.Show(result);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("SHA1加密出错：" + ex.Message);
            }
        }
        
    }
}