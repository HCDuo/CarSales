using System;
using System.Windows.Forms;

namespace CarSales
{
    public partial class Main : Form
    {
        private int userid;
        public Main()
        {
            InitializeComponent();
        }
        
        public Main(int userid)
        {
            this.userid = userid;
            InitializeComponent();
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            Sell sell = new Sell();
            Hide();
            sell.ShowDialog();
            Main main = new Main(userid);
            main.ShowDialog(this);
        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            Hide();
            purchase.ShowDialog();
            Main main = new Main(userid);
            main.ShowDialog(this);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Account account = new Account(userid);
            Hide();
            account.ShowDialog();
            Main main = new Main(userid);
            main.ShowDialog(this);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            
            Orderinformation orderinformation1 = new Orderinformation(userid);
            Hide();
            orderinformation1.ShowDialog();
            Main main = new Main(userid);
            main.ShowDialog(this);
        }
    }
}