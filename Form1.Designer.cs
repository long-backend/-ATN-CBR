
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.export = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.receive = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.graph = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button17 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
            this.angularGauge1 = new LiveCharts.WinForms.AngularGauge();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // export
            // 
            this.export.BackColor = System.Drawing.Color.Silver;
            this.export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.export.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.export.FlatAppearance.BorderSize = 2;
            this.export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.export.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.export.Location = new System.Drawing.Point(0, 265);
            this.export.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(153, 33);
            this.export.TabIndex = 0;
            this.export.Text = "Lưu (excel)";
            this.export.UseVisualStyleBackColor = false;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView1.Location = new System.Drawing.Point(234, 109);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(205, 363);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(2, 200);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lưu (mysql)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort1_ErrorReceived);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1155, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chọn cổng com";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 15);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 85;
            this.comboBox1.Text = "COM3";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(625, 495);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 158);
            this.button2.TabIndex = 8;
            this.button2.TabStop = false;
            this.button2.Text = "Kết nối \r\nvới arduno";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(0, 62);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 30);
            this.button3.TabIndex = 11;
            this.button3.Text = "Nhận dữ liệu ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(0, 127);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 52);
            this.button4.TabIndex = 12;
            this.button4.Text = " Dừng nhận dữ liệu";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(1044, 499);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(170, 155);
            this.button5.TabIndex = 13;
            this.button5.Text = "Ngắt kết nối \r\narduno";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // receive
            // 
            this.receive.BackColor = System.Drawing.Color.Silver;
            this.receive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("receive.BackgroundImage")));
            this.receive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.receive.FlatAppearance.BorderSize = 0;
            this.receive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receive.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receive.ForeColor = System.Drawing.Color.Black;
            this.receive.Location = new System.Drawing.Point(845, 503);
            this.receive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.receive.Name = "receive";
            this.receive.Size = new System.Drawing.Size(141, 140);
            this.receive.TabIndex = 22;
            this.receive.Text = "Nhận data \r\ntừ loadcell";
            this.receive.UseVisualStyleBackColor = false;
            this.receive.Click += new System.EventHandler(this.button12_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.zedGraphControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.zedGraphControl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.zedGraphControl1.Location = new System.Drawing.Point(625, 109);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(740, 363);
            this.zedGraphControl1.TabIndex = 23;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            this.zedGraphControl1.Load += new System.EventHandler(this.Form1_Load_1);
            // 
            // graph
            // 
            this.graph.BackColor = System.Drawing.Color.Silver;
            this.graph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.graph.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.graph.FlatAppearance.BorderSize = 2;
            this.graph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graph.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graph.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.graph.Location = new System.Drawing.Point(0, 327);
            this.graph.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(153, 31);
            this.graph.TabIndex = 24;
            this.graph.Text = "Vẽ đồ thị lớn";
            this.graph.UseVisualStyleBackColor = false;
            this.graph.Click += new System.EventHandler(this.graph_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.graph);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.export);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(31, 155);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 498);
            this.panel1.TabIndex = 87;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Silver;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button11.FlatAppearance.BorderSize = 2;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button11.Location = new System.Drawing.Point(0, 390);
            this.button11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(153, 30);
            this.button11.TabIndex = 109;
            this.button11.Text = "Vẽ đồ thị nhỏ";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Silver;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(0, 450);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(153, 30);
            this.button6.TabIndex = 86;
            this.button6.Text = "Xóa một cột";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(39, 304);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Silver;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button7.ForeColor = System.Drawing.Color.Blue;
            this.button7.Location = new System.Drawing.Point(234, 25);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(980, 86);
            this.button7.TabIndex = 89;
            this.button7.Text = "ĐỒ ÁN TỐT NGHIỆP\r\nMÁY NÉN CBR-ĐÁNH GIÁ CHẤT LƯỢNG NỀN MẶT ĐƯỜNG\r\n";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView2.Location = new System.Drawing.Point(437, 109);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(189, 363);
            this.dataGridView2.TabIndex = 103;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_1);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(0, 640);
            this.button8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 34);
            this.button8.TabIndex = 104;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.Location = new System.Drawing.Point(398, 510);
            this.button9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(87, 38);
            this.button9.TabIndex = 105;
            this.button9.Text = "Chuyển";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button12
            // 
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button12.Location = new System.Drawing.Point(229, 510);
            this.button12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(73, 38);
            this.button12.TabIndex = 109;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button13.Location = new System.Drawing.Point(316, 510);
            this.button13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(65, 38);
            this.button13.TabIndex = 110;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button16.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button16.Location = new System.Drawing.Point(229, 603);
            this.button16.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(73, 32);
            this.button16.TabIndex = 111;
            this.button16.Text = "Lực (max)";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(316, 603);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 34);
            this.textBox1.TabIndex = 112;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button17
            // 
            this.button17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button17.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button17.Location = new System.Drawing.Point(398, 602);
            this.button17.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(87, 36);
            this.button17.TabIndex = 113;
            this.button17.Text = "Gửi";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button10
            // 
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.Location = new System.Drawing.Point(519, 510);
            this.button10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(69, 38);
            this.button10.TabIndex = 114;
            this.button10.Text = "Đảo lên";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button14
            // 
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button14.Location = new System.Drawing.Point(519, 602);
            this.button14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(93, 36);
            this.button14.TabIndex = 115;
            this.button14.Text = "Đảo xuống";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(245, 567);
            this.button15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(50, 15);
            this.button15.TabIndex = 116;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I"});
            this.comboBox2.Location = new System.Drawing.Point(245, 469);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(82, 21);
            this.comboBox2.TabIndex = 117;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(245, 648);
            this.button18.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(56, 19);
            this.button18.TabIndex = 118;
            this.button18.Text = "button18";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button19.Location = new System.Drawing.Point(379, 648);
            this.button19.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(90, 27);
            this.button19.TabIndex = 119;
            this.button19.Text = "xóa đồ thị";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(814, 711);
            this.button20.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(56, 50);
            this.button20.TabIndex = 121;
            this.button20.Text = "vẽ lin chart";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // cartesianChart2
            // 
            this.cartesianChart2.Location = new System.Drawing.Point(104, 780);
            this.cartesianChart2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cartesianChart2.Name = "cartesianChart2";
            this.cartesianChart2.Size = new System.Drawing.Size(6, 6);
            this.cartesianChart2.TabIndex = 123;
            this.cartesianChart2.Text = "cartesianChart2";
            // 
            // angularGauge1
            // 
            this.angularGauge1.Location = new System.Drawing.Point(-21, -46);
            this.angularGauge1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.angularGauge1.Name = "angularGauge1";
            this.angularGauge1.Size = new System.Drawing.Size(150, 81);
            this.angularGauge1.TabIndex = 124;
            this.angularGauge1.Text = "angularGauge1";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(-21, -46);
            this.cartesianChart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(150, 81);
            this.cartesianChart1.TabIndex = 125;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1155, 845);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.angularGauge1);
            this.Controls.Add(this.cartesianChart2);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.receive);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button export;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button receive;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button graph;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private LiveCharts.WinForms.CartesianChart cartesianChart2;
        private LiveCharts.WinForms.AngularGauge angularGauge1;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
    }
}

