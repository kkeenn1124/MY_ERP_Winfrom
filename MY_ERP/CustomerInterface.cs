using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_ERP
{
    public partial class CustomerInterface : Form
    {
        public CustomerInterface()
        {
            InitializeComponent();
        }

        public void customerinfo(string cusinfo)
        {
            label9.Text = cusinfo;
        }

        public void productinfo(string product,int qty,int price)
        {
            dataGridView1.Rows.Add(product, qty, price);
        }

        public void pricetotal(int pricesum)
        {
            label2.Text = $"$ {pricesum}";
        }

        public void give(int collectmoney,int givechange)
        {
            label4.Text = "$ " + collectmoney;
            label6.Text = "$ "+givechange;
            label10.Text = "       謝謝光臨  \n    歡迎下次再來";
        }

        public void allclear()
        {
            dataGridView1.Rows.Clear();
            label9.Text = "";
            label2.Text = "$ 0";
            label4.Text = "$ 0";
            label6.Text = "$ 0";
            label10.Text = "你好！歡迎光臨";
        }
    }
}
