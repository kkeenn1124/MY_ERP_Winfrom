
namespace MY_ERP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            編號 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            工廠編號 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            工廠名稱 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            產品編號 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            產品名稱 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            成本 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            售價 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            數量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            記錄人員 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            textBox4 = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            textBox5 = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            textBox6 = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            textBox7 = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            textBox8 = new System.Windows.Forms.TextBox();
            tabControl1 = new System.Windows.Forms.TabControl();
            進 = new System.Windows.Forms.TabPage();
            銷 = new System.Windows.Forms.TabPage();
            textBox13 = new System.Windows.Forms.TextBox();
            button6 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            label21 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            textBox11 = new System.Windows.Forms.TextBox();
            label17 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            label14 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            商品 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            單價 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            textBox12 = new System.Windows.Forms.TextBox();
            textBox10 = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            textBox9 = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            存 = new System.Windows.Forms.TabPage();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            進.SuspendLayout();
            銷.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            存.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(5, 643);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(146, 71);
            button1.TabIndex = 0;
            button1.Text = "查詢";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { 編號, 工廠編號, 工廠名稱, 產品編號, 產品名稱, 成本, 售價, 數量, 記錄人員, 日期 });
            dataGridView1.Location = new System.Drawing.Point(157, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.RowTemplate.ReadOnly = true;
            dataGridView1.Size = new System.Drawing.Size(841, 711);
            dataGridView1.TabIndex = 1;
            // 
            // 編號
            // 
            編號.HeaderText = "編號";
            編號.MinimumWidth = 6;
            編號.Name = "編號";
            編號.Width = 125;
            // 
            // 工廠編號
            // 
            工廠編號.HeaderText = "工廠編號";
            工廠編號.MinimumWidth = 6;
            工廠編號.Name = "工廠編號";
            工廠編號.Width = 250;
            // 
            // 工廠名稱
            // 
            工廠名稱.HeaderText = "工廠名稱";
            工廠名稱.MinimumWidth = 6;
            工廠名稱.Name = "工廠名稱";
            工廠名稱.Width = 300;
            // 
            // 產品編號
            // 
            產品編號.HeaderText = "產品編號";
            產品編號.MinimumWidth = 6;
            產品編號.Name = "產品編號";
            產品編號.Width = 125;
            // 
            // 產品名稱
            // 
            產品名稱.HeaderText = "產品名稱";
            產品名稱.MinimumWidth = 6;
            產品名稱.Name = "產品名稱";
            產品名稱.Width = 300;
            // 
            // 成本
            // 
            成本.HeaderText = "成本";
            成本.MinimumWidth = 6;
            成本.Name = "成本";
            成本.Width = 125;
            // 
            // 售價
            // 
            售價.HeaderText = "售價";
            售價.MinimumWidth = 6;
            售價.Name = "售價";
            售價.Width = 125;
            // 
            // 數量
            // 
            數量.HeaderText = "數量";
            數量.MinimumWidth = 6;
            數量.Name = "數量";
            數量.Width = 125;
            // 
            // 記錄人員
            // 
            記錄人員.HeaderText = "記錄人員";
            記錄人員.MinimumWidth = 6;
            記錄人員.Name = "記錄人員";
            記錄人員.Width = 125;
            // 
            // 日期
            // 
            日期.HeaderText = "日期";
            日期.MinimumWidth = 6;
            日期.Name = "日期";
            日期.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(18, 29);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(103, 47);
            label1.TabIndex = 2;
            label1.Text = "人員:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(18, 104);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(177, 47);
            label2.TabIndex = 3;
            label2.Text = "工廠編號:";
            // 
            // button2
            // 
            button2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(18, 327);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(113, 58);
            button2.TabIndex = 4;
            button2.Text = "建立";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            textBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(122, 26);
            textBox1.MaxLength = 4;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(203, 54);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox2.Location = new System.Drawing.Point(195, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(278, 54);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(481, 104);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(177, 47);
            label3.TabIndex = 7;
            label3.Text = "工廠名稱:";
            label3.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox3.Location = new System.Drawing.Point(658, 100);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(331, 54);
            textBox3.TabIndex = 8;
            textBox3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(18, 179);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(177, 47);
            label4.TabIndex = 9;
            label4.Text = "產品編號:";
            // 
            // textBox4
            // 
            textBox4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox4.Location = new System.Drawing.Point(195, 176);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(280, 54);
            textBox4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(481, 176);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(177, 47);
            label5.TabIndex = 11;
            label5.Text = "產品名稱:";
            label5.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox5.Location = new System.Drawing.Point(658, 173);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(331, 54);
            textBox5.TabIndex = 12;
            textBox5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(18, 247);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(103, 47);
            label6.TabIndex = 13;
            label6.Text = "成本:";
            // 
            // textBox6
            // 
            textBox6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox6.Location = new System.Drawing.Point(110, 244);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(203, 54);
            textBox6.TabIndex = 14;
            textBox6.KeyDown += textBox6_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(332, 247);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(103, 47);
            label7.TabIndex = 15;
            label7.Text = "售價:";
            // 
            // textBox7
            // 
            textBox7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox7.Location = new System.Drawing.Point(424, 244);
            textBox7.Name = "textBox7";
            textBox7.Size = new System.Drawing.Size(234, 54);
            textBox7.TabIndex = 16;
            textBox7.KeyDown += textBox7_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(675, 247);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(103, 47);
            label8.TabIndex = 17;
            label8.Text = "數量:";
            // 
            // textBox8
            // 
            textBox8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox8.Location = new System.Drawing.Point(773, 244);
            textBox8.Name = "textBox8";
            textBox8.Size = new System.Drawing.Size(216, 54);
            textBox8.TabIndex = 18;
            textBox8.KeyDown += textBox8_KeyDown;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(進);
            tabControl1.Controls.Add(銷);
            tabControl1.Controls.Add(存);
            tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            tabControl1.Location = new System.Drawing.Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1011, 749);
            tabControl1.TabIndex = 19;
            // 
            // 進
            // 
            進.BackColor = System.Drawing.Color.WhiteSmoke;
            進.Controls.Add(button2);
            進.Controls.Add(label1);
            進.Controls.Add(label2);
            進.Controls.Add(textBox1);
            進.Controls.Add(textBox2);
            進.Controls.Add(textBox8);
            進.Controls.Add(label3);
            進.Controls.Add(label8);
            進.Controls.Add(textBox3);
            進.Controls.Add(textBox7);
            進.Controls.Add(label4);
            進.Controls.Add(label7);
            進.Controls.Add(textBox4);
            進.Controls.Add(textBox6);
            進.Controls.Add(label5);
            進.Controls.Add(label6);
            進.Controls.Add(textBox5);
            進.Location = new System.Drawing.Point(4, 28);
            進.Name = "進";
            進.Padding = new System.Windows.Forms.Padding(3);
            進.Size = new System.Drawing.Size(1003, 717);
            進.TabIndex = 0;
            進.Text = "進";
            // 
            // 銷
            // 
            銷.BackColor = System.Drawing.Color.WhiteSmoke;
            銷.Controls.Add(textBox13);
            銷.Controls.Add(button6);
            銷.Controls.Add(button5);
            銷.Controls.Add(button4);
            銷.Controls.Add(label21);
            銷.Controls.Add(label22);
            銷.Controls.Add(label23);
            銷.Controls.Add(label20);
            銷.Controls.Add(label19);
            銷.Controls.Add(label18);
            銷.Controls.Add(textBox11);
            銷.Controls.Add(label17);
            銷.Controls.Add(label16);
            銷.Controls.Add(label15);
            銷.Controls.Add(button3);
            銷.Controls.Add(label14);
            銷.Controls.Add(label11);
            銷.Controls.Add(dataGridView2);
            銷.Controls.Add(textBox12);
            銷.Controls.Add(textBox10);
            銷.Controls.Add(label13);
            銷.Controls.Add(label12);
            銷.Controls.Add(label10);
            銷.Controls.Add(textBox9);
            銷.Controls.Add(label9);
            銷.Location = new System.Drawing.Point(4, 28);
            銷.Name = "銷";
            銷.Size = new System.Drawing.Size(1003, 717);
            銷.TabIndex = 2;
            銷.Text = "銷";
            // 
            // textBox13
            // 
            textBox13.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox13.Location = new System.Drawing.Point(203, 585);
            textBox13.Name = "textBox13";
            textBox13.Size = new System.Drawing.Size(231, 54);
            textBox13.TabIndex = 27;
            textBox13.Visible = false;
            textBox13.KeyDown += textBox13_KeyDown;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(310, 489);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(94, 29);
            button6.TabIndex = 30;
            button6.Text = "現金";
            button6.UseVisualStyleBackColor = true;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(175, 489);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(94, 29);
            button5.TabIndex = 29;
            button5.Text = "信用卡";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(40, 489);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(94, 29);
            button4.TabIndex = 28;
            button4.Text = "Line Pay";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label21.Location = new System.Drawing.Point(104, 588);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(103, 47);
            label21.TabIndex = 26;
            label21.Text = "收取:";
            label21.Visible = false;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label22.Location = new System.Drawing.Point(175, 588);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(205, 47);
            label22.TabIndex = 25;
            label22.Text = "使用刷卡機";
            label22.Visible = false;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label23.Location = new System.Drawing.Point(123, 588);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(311, 47);
            label23.TabIndex = 24;
            label23.Text = "刷取Line Pay條碼";
            label23.Visible = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label20.ForeColor = System.Drawing.Color.Red;
            label20.Location = new System.Drawing.Point(808, 652);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(61, 38);
            label20.TabIndex = 23;
            label20.Text = "$ 0";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label19.ForeColor = System.Drawing.Color.Red;
            label19.Location = new System.Drawing.Point(643, 652);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(77, 38);
            label19.TabIndex = 22;
            label19.Text = "找零";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label18.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label18.Location = new System.Drawing.Point(808, 585);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(61, 38);
            label18.TabIndex = 21;
            label18.Text = "$ 0";
            // 
            // textBox11
            // 
            textBox11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox11.Location = new System.Drawing.Point(203, 395);
            textBox11.Name = "textBox11";
            textBox11.Size = new System.Drawing.Size(231, 54);
            textBox11.TabIndex = 16;
            textBox11.Visible = false;
            textBox11.KeyDown += textBox11_KeyDown;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label17.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label17.Location = new System.Drawing.Point(643, 585);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(77, 38);
            label17.TabIndex = 20;
            label17.Text = "收您";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label16.Location = new System.Drawing.Point(808, 519);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(61, 38);
            label16.TabIndex = 19;
            label16.Text = "$ 0";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label15.Location = new System.Drawing.Point(643, 525);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(77, 38);
            label15.TabIndex = 18;
            label15.Text = "合計";
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(440, 420);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(94, 29);
            button3.TabIndex = 17;
            button3.Text = "結帳";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label14.Location = new System.Drawing.Point(104, 398);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(103, 47);
            label14.TabIndex = 15;
            label14.Text = "數量:";
            label14.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(30, 252);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(0, 47);
            label11.TabIndex = 14;
            label11.Visible = false;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { 商品, dataGridViewTextBoxColumn1, 單價 });
            dataGridView2.Location = new System.Drawing.Point(561, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new System.Drawing.Size(438, 490);
            dataGridView2.TabIndex = 13;
            // 
            // 商品
            // 
            商品.HeaderText = "商品";
            商品.MinimumWidth = 6;
            商品.Name = "商品";
            商品.ReadOnly = true;
            商品.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "數量";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // 單價
            // 
            單價.HeaderText = "單價";
            單價.MinimumWidth = 6;
            單價.Name = "單價";
            單價.ReadOnly = true;
            單價.Width = 125;
            // 
            // textBox12
            // 
            textBox12.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox12.Location = new System.Drawing.Point(203, 335);
            textBox12.Name = "textBox12";
            textBox12.Size = new System.Drawing.Size(231, 54);
            textBox12.TabIndex = 10;
            textBox12.Visible = false;
            textBox12.KeyDown += textBox12_KeyDown;
            // 
            // textBox10
            // 
            textBox10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox10.Location = new System.Drawing.Point(203, 181);
            textBox10.Name = "textBox10";
            textBox10.Size = new System.Drawing.Size(231, 54);
            textBox10.TabIndex = 5;
            textBox10.Visible = false;
            textBox10.KeyDown += textBox10_KeyDown;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label13.Location = new System.Drawing.Point(30, 109);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(0, 47);
            label13.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(30, 338);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(177, 47);
            label12.TabIndex = 9;
            label12.Text = "產品編號:";
            label12.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(30, 184);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(177, 47);
            label10.TabIndex = 4;
            label10.Text = "會員編號:";
            label10.Visible = false;
            // 
            // textBox9
            // 
            textBox9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            textBox9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox9.Location = new System.Drawing.Point(196, 37);
            textBox9.MaxLength = 4;
            textBox9.Name = "textBox9";
            textBox9.Size = new System.Drawing.Size(238, 54);
            textBox9.TabIndex = 1;
            textBox9.KeyDown += textBox9_KeyDown;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(30, 44);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(177, 47);
            label9.TabIndex = 0;
            label9.Text = "人員編號:";
            // 
            // 存
            // 
            存.BackColor = System.Drawing.Color.WhiteSmoke;
            存.Controls.Add(dataGridView1);
            存.Controls.Add(button1);
            存.Location = new System.Drawing.Point(4, 28);
            存.Name = "存";
            存.Padding = new System.Windows.Forms.Padding(3);
            存.Size = new System.Drawing.Size(1003, 717);
            存.TabIndex = 1;
            存.Text = "存";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1017, 758);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "POS進銷存";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            進.ResumeLayout(false);
            進.PerformLayout();
            銷.ResumeLayout(false);
            銷.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            存.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DataGridViewTextBoxColumn 編號;
        private System.Windows.Forms.DataGridViewTextBoxColumn 工廠編號;
        private System.Windows.Forms.DataGridViewTextBoxColumn 工廠名稱;
        private System.Windows.Forms.DataGridViewTextBoxColumn 產品編號;
        private System.Windows.Forms.DataGridViewTextBoxColumn 產品名稱;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成本;
        private System.Windows.Forms.DataGridViewTextBoxColumn 售價;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 記錄人員;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日期;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage 進;
        private System.Windows.Forms.TabPage 存;
        private System.Windows.Forms.TabPage 銷;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 單價;
        private System.Windows.Forms.Timer timer1;
    }
}

