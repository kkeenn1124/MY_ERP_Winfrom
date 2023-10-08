using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MY_ERP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string _connectionString = @"Data Source=C:\D槽\Company_Data.db";

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"SELECT i.Numbering,i.FactoryID,c.companyName,i.ProductID,p.ProductName,i.Cost,i.Price,i.quantity,i.UserID,i.date from input_table as i,product as p,company as c where i.FactoryID=c.companyID and i.ProductID=p.ProductID";

                using (var reader1 = command.ExecuteReader())
                {
                    while (reader1.Read())
                    {
                        int numbering = reader1.GetInt32(0);
                        string factoryID = reader1.GetString(1);
                        string factoryName = reader1.GetString(2);
                        int productID = reader1.GetInt32(3);
                        string productName = reader1.GetString(4);
                        int cost = reader1.GetInt32(5);
                        int price = reader1.GetInt32(6);
                        int quantity = reader1.GetInt32(7);
                        string userID = Convert.ToString(reader1.GetString(8));
                        string date = reader1.GetString(9);

                        dataGridView1.Rows.Add(numbering, factoryID, factoryName, productID, productName, cost, price, quantity, userID, date);
                    }
                }
            }
        }

        int productID;
        private void button2_Click(object sender, EventArgs e)
        {
            string employeeID = textBox1.Text;
            string companyID = textBox2.Text;
            string companyName = textBox3.Text;
            //string productID = textBox4.Text;
            productID = int.Parse(textBox4.Text);
            string productName = textBox5.Text;
            string cost = textBox6.Text;
            string price = textBox7.Text;
            string quantity = textBox8.Text;
            bool companytoken = false;
            bool producttoken = false;
            if (employeeID != "" && companyID != "" && /*companyName != "" &&*/ productID != 0 /*&& productName != ""*/ && cost != "" && price != "" && quantity != "")
            {

                string _connectionString = @"Data Source=C:\D槽\Company_Data.db";
                using (var connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    var serach = connection.CreateCommand();
                    var companyserach = connection.CreateCommand();
                    var productserach = connection.CreateCommand();
                    serach.CommandText = $@"SELECT * from employee where employeeID='{employeeID}'";
                    var ss = serach.ExecuteReader();
                    var command = connection.CreateCommand();

                    if (ss.Read() == true)
                    {
                        ss.Close();
                        serach.CommandText = $@"SELECT * FROM company where companyID='{companyID}'";
                        ss = serach.ExecuteReader();
                        if (ss.Read() == true)
                        {
                            companyID = ss.GetString(0);
                            companytoken = true;
                        }
                        ss.Close();

                        serach.CommandText = $@"SELECT * from Product where ProductID='{productID}'";
                        ss = serach.ExecuteReader();
                        if (ss.Read() == true)
                        {
                            productID = ss.GetInt32(0);
                            producttoken = true;
                        }
                        ss.Close();
                        //while (ss.Read())
                        //{
                        //    productID = ss.GetInt32(0) + 1;

                        //    command = connection.CreateCommand();
                        //    command.CommandText = $@"insert into Product VALUES({productID},'{productName}')";
                        //    command.ExecuteNonQuery();
                        //}
                        if (companytoken == true && producttoken == true)
                        {
                            serach.CommandText = @"select Numbering from input_table ORDER by Numbering DESC  LIMIT 1";
                            ss = serach.ExecuteReader();
                            while (ss.Read())
                            {
                                int numbering = ss.GetInt32(0) + 1;
                                string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                command = connection.CreateCommand();
                                command.CommandText = $@"insert into input_table values ({numbering},'{companyID}',{productID},{cost},{price},{quantity},'{employeeID}','{date}')";
                                command.ExecuteNonQuery();
                                MessageBox.Show($"成功建立編號:{numbering}");
                                CleanTextBox();
                            }
                            ss.Close();
                        }
                        else
                        {
                            if (companytoken == false && producttoken == false)
                            {
                                MessageBox.Show("查無此供應商、產品 請確認此供應商、產品是否建立");
                            }
                            else if (producttoken == false)
                            {
                                MessageBox.Show("查無此產品 請確認此產品是否建立");
                            }
                            else
                            {
                                MessageBox.Show("查無此供應商 請確認此供應商是否建立");
                            }
                        }

                    }
                    else
                    {
                        ss.Close();
                        MessageBox.Show("工號錯誤");
                        textBox1.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("勿空白");
            }


            //if (employeeID != "" && factoryID != "" && factoryName != "" /*&& productID != ""*/ && productName != "" && cost != "" && price != "" && quantity != "")
            //{
            //    int.Parse(cost);
            //    int.Parse(price);
            //    int.Parse(quantity);
            //    //string _connectionString = @"Data Source=C:\D槽\Company_Data.db";
            //    using (var connection = new SQLiteConnection(_connectionString))
            //    {
            //        connection.Open();
            //        var serach = connection.CreateCommand();
            //        serach.CommandText = @"select Numbering from input_table ORDER by Numbering DESC  LIMIT 1";
            //        var ss = serach.ExecuteReader();
            //        while (ss.Read())
            //        {
            //            int numbering = ss.GetInt32(0) + 1;

            //            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //            var command = connection.CreateCommand();
            //            command.CommandText = $@"insert into input_table values ({numbering},'{factoryID}','{factoryName}','{productID}','{productName}',{cost},{price},{quantity},'{employeeID}','{date}')";
            //            command.ExecuteNonQuery();
            //            MessageBox.Show($"成功建立編號:{numbering}");
            //            CleanTextBox();
            //            break;
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("勿空白");
            //}

        }

        public void CleanTextBox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode != 8 && (int)e.KeyCode != 16)
            {
                if ((int)e.KeyCode < 48 | (int)e.KeyCode > 57)
                {
                    MessageBox.Show("偵測到數字以外字元 請重新輸入");
                    textBox6.Text = "";
                }
            }
            e.Handled = true;
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode != 8 && (int)e.KeyCode != 16)
            {
                if ((int)e.KeyCode < 48 | (int)e.KeyCode > 57)
                {
                    MessageBox.Show("偵測到數字以外字元 請重新輸入");
                    textBox7.Text = "";
                }
            }
            e.Handled = true;
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode != 8 && (int)e.KeyCode != 16)
            {
                if ((int)e.KeyCode < 48 | (int)e.KeyCode > 57)
                {
                    MessageBox.Show("偵測到數字以外字元 請重新輸入");
                    textBox8.Text = "";
                }
            }
            e.Handled = true;
        }

        CustomerInterface customer = new CustomerInterface();
        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == 13)
            {
                bool token = false;
                string _connectionString = @"Data Source=C:\D槽\Company_Data.db";
                using (var connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    var serach = connection.CreateCommand();
                    serach.CommandText = $@"select * FROM employee where employeeID='{textBox9.Text}'";
                    var ss = serach.ExecuteReader();
                    while (ss.Read())
                    {
                        customer.Show();
                        label13.Text = "收銀人員:" + ss.GetString(1);
                        token = true;
                    }
                    label10.Visible = true;
                    label12.Visible = true;
                    textBox10.Visible = true;
                    textBox12.Visible = true;
                    button3.Visible = true;
                    label14.Visible = true;
                    textBox11.Visible = true;
                    label11.Visible = true;
                    textBox10.Focus();
                }
                if (token == false)
                {
                    label13.Text = "無此編號 請重新輸入";
                    label10.Visible = false;
                    label12.Visible = false;
                    textBox10.Visible = false;
                    textBox12.Visible = false;
                    button3.Visible = false;
                    label14.Visible = false;
                    textBox11.Visible = false;
                    label11.Visible = false;
                    textBox9.Text = "";
                    textBox9.Focus();
                }
            }
        }

        private void textBox10_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == 13)
            {
                bool token = false;
                string _connectionString = @"Data Source=C:\D槽\Company_Data.db";
                using (var connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    var serach = connection.CreateCommand();
                    serach.CommandText = $@"select * FROM customer where customerID='{textBox10.Text}'";
                    var ss = serach.ExecuteReader();
                    while (ss.Read())
                    {
                        token = true;
                        customer.customerinfo(ss.GetString(1));
                        label11.Text = $"會員:{ss.GetString(1)}";
                    }
                    if (token == false)
                    {
                        customer.customerinfo("此號碼未註冊");
                        label11.Text = $"此號碼未註冊";
                    }
                }
                textBox12.Focus();
            }
        }

        private void textBox12_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == 13)
            {
                textBox11.Focus();
            }
        }
        int[,] ProductIDary = new int[100, 3]; // 產品ID  庫存  購買數量
        public static int count = 0;

        private void textBox11_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == 13)
            {
                bool token = false;
                string _connectionString = @"Data Source=C:\D槽\Company_Data.db";
                using (var connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    var serach = connection.CreateCommand();
                    serach.CommandText = $@"select i.ProductID,p.ProductName,i.price,i.quantity FROM input_table as i,product as p where i.ProductID=p.ProductID AND i.ProductID={textBox12.Text}";
                    var ss = serach.ExecuteReader();
                    while (ss.Read())
                    {

                        ProductIDary[count, 0] = ss.GetInt32(0); //產品ID
                        ProductIDary[count, 1] = ss.GetInt32(3); //庫存
                        string ProductName = ss.GetString(1);
                        ProductIDary[count, 2] = int.Parse(textBox11.Text); //購買數量
                        int qty = int.Parse(textBox11.Text); ;
                        int price = ss.GetInt32(2) * qty;

                        dataGridView2.Rows.Add(ProductName, qty, price);
                        customer.productinfo(ProductName, qty, price);
                        token = true;
                        count++;
                    }
                }
                if (token == false)
                {
                    textBox11.AppendText("查無此產品\r\n");
                }
                textBox12.Text = "";
                textBox11.Text = "";
                textBox12.Focus();
            }
        }
        public int pricesum = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;

            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                pricesum += int.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString());
            }
            customer.pricetotal(pricesum);
            label16.Text = "$ " + pricesum;
        }

        public void collectmoney(int collect)
        {
            label18.Text = "$ " + collect;
        }
        public void givechange(int pricetotal, int give)
        {
            label20.Text = (pricetotal - give).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = true;
            textBox13.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label21.Visible = false;
            label22.Visible = true;
            label23.Visible = false;
            textBox13.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label21.Visible = true;
            label22.Visible = false;
            label23.Visible = false;
            textBox13.Visible = true;
            textBox13.Focus();
        }

        private void textBox13_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode != 8 && (int)e.KeyCode != 16 && (int)e.KeyCode != 13)
            {
                if ((int)e.KeyCode < 48 | (int)e.KeyCode > 57)
                {
                    MessageBox.Show("偵測到數字以外字元 請重新輸入");
                    textBox8.Text = "";
                }
            }
            e.Handled = true;
            if ((int)e.KeyCode == 13)
            {
                int givechange = int.Parse(textBox13.Text) - pricesum;
                label18.Text = "$ " + textBox13.Text;
                customer.give(int.Parse(textBox13.Text), givechange);
                label20.Text = "$ " + givechange;

                string sale_date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string _connectionString = @"Data Source=C:\D槽\Company_Data.db";
                using (var connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();

                    for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                    {
                        int lastquantity = ProductIDary[i, 1] - int.Parse(dataGridView2.Rows[i].Cells[1].Value.ToString());
                        var command = connection.CreateCommand();
                        command.CommandText = $@"UPDATE input_table set quantity = {lastquantity} where ProductID = {ProductIDary[i, 0]}";
                        command.ExecuteNonQuery();
                        command.CommandText = $@"insert into sale_Record VALUES ('{textBox10.Text}',{ProductIDary[i, 0]},{ProductIDary[i, 2]},'{textBox9.Text}','{sale_date}')";
                        command.ExecuteNonQuery();
                    }
                }
                Array.Clear(ProductIDary, 0, ProductIDary.Length);
                count = 0;
                timer1.Interval = 10000;
                timer1.Enabled = true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            label16.Text = "$ 0";
            label18.Text = "$ 0";
            label20.Text = "$ 0";
            label11.Text = "";
            textBox13.Text = "";
            customer.allclear();
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            textBox13.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            timer1.Enabled = false;
            textBox10.Text = "";
            textBox10.Focus();
        }
    }
}