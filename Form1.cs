using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using System.IO.Ports;
using ZedGraph;

using System.Collections.Generic;
using System.Linq;


using System.Data.Common;
using System.Data;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {




        List<User> list = new List<User>();
        User user;
        public Form1()
        {
            InitializeComponent();

            user = new User() { name = "nguyễn văn bản", address = "hội an" };
            list.Add(user);

        }

        private void export_Click(object sender, EventArgs e)
        {
            import_Click(sender,e);
            /*SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Eport File Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx| Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    exportExel(saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("xuất file không thành công!\n" + ex.Message);
                }
            }*/
        }
        // import excel
        private void importExcel(string path)
        {
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                DataTable dataTable = new DataTable();
                excelWorksheet.Cells[1, 1].Value = 5;
                /*for (int i = excelWorksheet.Dimension.Start.Column; i <= excelWorksheet.Dimension.End.Column; i++)
                {
                    
                    //dataTable.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());
                    
                }
                for (int i = excelWorksheet.Dimension.Start.Row + 1; i <= excelWorksheet.Dimension.End.Row; i++)
                {
                    List<string> listRows = new List<string>();
                    for (int j = excelWorksheet.Dimension.Start.Column; j <= excelWorksheet.Dimension.End.Column; j++)
                    {
                        listRows.Add(excelWorksheet.Cells[i, j].Value.ToString());
                    }
                    dataTable.Rows.Add(listRows.ToArray());
                }

                dataGridView1.DataSource = dataTable;*/
            }
        }


        //exportexcel
        int l = 0;
        private void exportExel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }
            /*for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }*/
            //example
            for (int i = (dataGridView1.Rows.Count-1); i >= 0 ; i--)
            {
                l++;
                Console.WriteLine(l);
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Console.WriteLine("đếm số lần đủ 3 lần");
                    application.Cells[l+1 , j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }


            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }
         void exportexcell()
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook sheet = excel.Workbooks.Open("E:\\visual\\123.xlsx");
           
            Microsoft.Office.Interop.Excel.Worksheet x = excel.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;

            x.Cells[2, 1] = "123";
            sheet.Close(true, Type.Missing, Type.Missing);
            excel.Quit();
        }
        // work with excel
        private void import_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Title = "Import File Excel";
            OpenFileDialog.Filter = "Excel (*.xlsx)|*.xlsx| Excel 2003 (*.xls)|*.xls";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    importExcel(OpenFileDialog.FileName);
                    //exportExel(OpenFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("nhập file không thành công!\n" + ex.Message);
                }
            }
        }
        // export into mysql
        private void ExportMysql()
        {
            MySqlConnection connection = DBUtils.GetDBConnection();
            connection.Open();
            try
            {
                // Câu lệnh Insert.
                string sql = "Insert into xuanhoang2 ( name, adress) "
                                                 + " values ( @name, @adress) ";

                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;

                // Tạo một đối tượng Parameter.
                MySqlParameter gradeParam = new MySqlParameter("@name", MySqlDbType.VarChar, 50);
                gradeParam.Value = time;
                cmd.Parameters.Add(gradeParam);

                // Thêm tham số @highSalary (Viết ngắn hơn).
                MySqlParameter highSalaryParam = cmd.Parameters.Add("@adress", MySqlDbType.VarChar, 50);
                highSalaryParam.Value = data;

                // Thêm tham số @lowSalary (Viết ngắn hơn nữa).
                //cmd.Parameters.Add("@adress", (MySqlDbType)SqlDbType.NVarChar).Value = "xuan hoang";

                // Thực thi Command (Dùng cho delete, insert, update).
                int rowCount = cmd.ExecuteNonQuery();

                Console.WriteLine("Row Count affected = " + rowCount);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                connection.Close();
                connection.Dispose();
                connection = null;
            }
            Console.Read();
        }
        // nút để export excel
        private void button1_Click(object sender, EventArgs e)
        {
            ExportMysql();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            button2.TabStop = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent
            if (!serialPort1.IsOpen) // Nếu đối tượng serialPort1 chưa được mở , sau khi nhấn button 1 thỳ…
            {
                serialPort1.PortName = "COM3";//cổng serialPort1 = ComboBox mà bạn đang chọn
                serialPort1.Open();// Mở cổng serialPort1
                                   // Console.WriteLine("ta đã vô đây rồi nghe mở kết nối");
                button2.BackColor = Color.Red;
                button5.BackColor = Color.DarkBlue;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();//Đóng cổng Serial sau khi button 4 được nhấn
                button5.BackColor = Color.Red;
                button2.BackColor = Color.DarkBlue;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                button3.BackColor = Color.Red;
                button4.BackColor = Color.FromArgb(38, 39, 59);
                Console.WriteLine("long1");
                String y = "1500long1";
                serialPort1.Write(y);//Nếu button2 được nhấn,gửi byte “1” đến cổng serialPort1
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                button4.BackColor = Color.Red;
                button3.BackColor = Color.FromArgb(38, 39, 59);
                Console.WriteLine("long0");
                String x = "1500long0";
                serialPort1.Write(x);//gửi byte “0” đến cổng serialPort1
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show("Phần mềm được viết bởi Ðỗ Hữu Toàn (Bạn của Ðinh Hồng Thái)", "Tác giả");// Nếu MenuTrip tác giả được nhấn thỳ hiện lên hộp thoại 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                button1.Text = ("Kết nối");
                label3.Text = ("Chưa kết nối");
                label3.ForeColor = Color.Red;
                //Nếu Timer được làm mới, Cổng serialPort1 chưa được mở thì thay đổi Text trong button1, label3…đổi màu text label3 thành màu đỏ 
            }
            else if (serialPort1.IsOpen)
            {
                button1.Text = ("Ngắt kết nối");
                label3.Text = ("Ðã kết nối");
                label3.ForeColor = Color.Green;
                //Nếu Timer được làm mới, Cổng serialPort1 đã mở thì thay đổi Text trong button1, label3…đổi màu text label3 thành màu xanh
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        

        private void ledvang_Click(object sender, EventArgs e)
        {
        }
        String name;
        String value;
        float time=1;
        float data=2;
        int b = 0;
        int h = 0;
        private void Form1_Load_1(object sender, EventArgs e)
        {
           
            textBox1.Focus();
        
               
                if (h == 0)
                {
                    graph.BackColor = Color.Red;
                h++;
                }
            
         
            this.dataGridView1.DefaultCellStyle.Font = new Font("Time new  roman", 10);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Blue;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridView2.DefaultCellStyle.Font = new Font("Time new  roman", 10);
            this.dataGridView2.DefaultCellStyle.ForeColor = Color.Blue;
            this.dataGridView2.DefaultCellStyle.BackColor = Color.Beige;
            // add tên cột cho datagridview1
            dt.Columns.Add("STT");
            dt.Columns.Add("KN");
            dt.Columns.Add("MM");
            
            // add tên cột cho datagridview2
            dt2.Columns.Add("STT");
            dt2.Columns.Add("KN");
            dt2.Columns.Add("MM");
            
            // Khởi tạo ZedGraph
            GraphPane myPane = zedGraphControl1.GraphPane;
           
           // myPane.Fill.Color = System.Drawing.Color.FromArgb(38, 39, 59);
           // myPane.Chart.Fill = new Fill(Color.FromArgb(38, 39, 59));
           // myPane.XAxis.Title.FontSpec.FontColor = Color.DeepSkyBlue;
            
            //myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.Title.FontSpec.FontColor = Color.DeepSkyBlue;
            myPane.XAxis.Scale.FontSpec.FontColor = Color.DeepSkyBlue;
            myPane.YAxis.Scale.FontSpec.FontColor = Color.DeepSkyBlue;
            //myPane.YAxis.MajorGrid.IsVisible = true;
            //myPane.Chart.Fill.Color = SystemColors.ControlText;
            // This will do the area outside of the graphing area
            //myPane.Fill = new Fill(Color.FromArgb(222, 224, 212));
            // This will do the area inside the graphing area
            //myPane.Chart.Fill = new Fill(Color.FromArgb(222, 224, 212));
            myPane.Title.Text = "Đồ thị dữ liệu theo thời gian";
            myPane.XAxis.Title.Text = "Thời gian (s)";
            myPane.YAxis.Title.Text = "Dữ liệu";
            RollingPointPairList list = new RollingPointPairList(60000);
            LineItem curve = myPane.AddCurve("Dữ liệu", list, Color.Red, SymbolType.None);
            curve.Symbol.Fill = new Fill(Color.White);
            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 30;
            myPane.XAxis.Scale.MinorStep = 1;
            myPane.XAxis.Scale.MajorStep = 0.2;
            myPane.YAxis.Scale.Min = 0;
            myPane.YAxis.Scale.Max = 0;
            try
            {
                //string[] arrList = new List<string>();
                /*string[] arrList = new string[5];
                arrList = serialPort1.ReadLine().Split('|'); // Đọc một dòng của Serial, cắt chuỗi khi gặp ký tự gạch đứng
                String name;
                String value;
                name = arrList[0]; // Chuỗi đầu tiên lưu vào SRealTime
                value = arrList[1];*/ // Chuỗi thứ hai lưu vào SDatas
            }
            catch
            {
                return;
            }

        }
        int lo = 0;
        int t = 0;
        int j = 1;
        int cancel = 0;
        float ex=0;
        // timer lặp lại
        private void timer2_Tick(object sender, EventArgs e)
        {
            /*if (q == 0)
            {
                time = time + 1;
                data = data + 1;
                Draw();
                button12_Click(sender, e);
            }*/
            
            // nút nhấn xóa chưa nhấn đang chạy trên dữ liệu lớn
            //Draw();
            if (lo == 1)
            {
                if (b == 0)
                {
                    Draw();
                }
                button12_Click(sender, e);
                //ExportMysql();
                lo = 0;
                //Console.WriteLine("ta đã vô đây rồi nghe, trong vòng lặp timer");
            }
                   }
       // nhận dữ liệu từ arduno
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                
                try
                {  
                    /*string[] arrList = serialPort1.ReadLine().Split('|'); // Đọc một dòng của Serial, cắt chuỗi khi gặp ký tự gạch đứng
                    name = arrList[0];// Chuỗi đầu tiên lưu vào SRealTime
                    value = arrList[1];
                      time = int.Parse(name);
                    data = int.Parse(value);
                    Console.WriteLine(time);
                    Console.WriteLine(data);*/
                    string datareceived = serialPort1.ReadLine(); // Đọc một dòng của Serial, cắt chuỗi khi gặp ký tự gạch đứng
                                                                  //name = arrList[0];// Chuỗi đầu tiên lưu vào SRealTime
                                                                  //value = arrList[1];
                                                                  // time = int.Parse(name);
                                                                  //data = int.Parse(value);
                                                                  //Console.WriteLine(time);
                                                       //Console.WriteLine(data);
                    if (datareceived.Contains('h')) {
                        
                        string name = datareceived.Substring(0, datareceived.IndexOf("h"));
                        string value = datareceived.Substring(datareceived.IndexOf("h")+1);
                        time = float.Parse(name);
                        data = float.Parse(value);
                        Console.WriteLine(data);

                        if (data > ex)
                        {
                            ex = data;
                            receive.Text = ex.ToString();
                        }

                        lo = 1;
                        t = 1;
                    }
                }
                catch
                {
                    return;
                }
            }
            
        }

        private void serialPort1_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {

        }
        private void lightled()
        {
            // Chuỗi thứ hai lưu vào SDatas
            Console.WriteLine("ta đã vô đây rồi nghe vòng lặp đèn");
        }

       

        private void button11_Click(object sender, EventArgs e)
        {
           
            if (serialPort1.IsOpen == true)
            {
                String x = "long4";
                serialPort1.Write(x);//gửi byte “0” đến cổng serialPort1

            }
        }
        // truyền dữ liệu vào datagridview
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        private void button12_Click(object sender, EventArgs e)
        {
            // code không có dữ liệu từ arduno
            // datagridview1
            dataGridView1.DataSource = dt;
            DataRow row;
                row = dt.NewRow();
                row["KN"] = time;
                row["MM"] = data;
            button12.Text = time.ToString();
            button13.Text = data.ToString(); ;
            dt.Rows.Add(row);
                int k = dataGridView1.Rows.Count;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = (i + 1);
            }
            if (b == 0)
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[k - 2].Cells[0];
            }
            //dataGridView1.CurrentCell = dataGridView1.Rows[k-2].Cells[0];// Đưa Control về vị trí của nó
            dataGridView1.CurrentRow.Selected = true;// Set trạng thái Selected                                                          
            // thêm dữ liệu mới nhất vào textbox
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                string x = dataGridView1.Rows[item.Index].Cells[1].Value.ToString();
                string y = dataGridView1.Rows[item.Index].Cells[2].Value.ToString();
               // textBox1.Text = x;
               // textBox2.Text = y;
                // time2 = int.Parse(x);
                //data2 = int.Parse(y);
                //Console.WriteLine(item.Index);
                //dataGridView2.DataSource = dt2;
                // DataRow row2;
                //row2 = dt2.NewRow();
                // row2["TenSV"] = dataGridView1.Rows[item.Index].Cells[0].Value.ToString();
                // row2["MASV"] = dataGridView1.Rows[item.Index].Cells[1].Value.ToString();
                // dt2.Rows.Add(row2);
                if (b == 1)
                {
                    Draw1();
                }


            }

            /* for (int i = 0; i < dt.Rows.length; i++)
             {
                 string name = dt.rows[i]["columnname"].ToString();
             }*/

        }

        // vẽ đồ thị cần 2 giá trị truyền vào là data và time
        private void Draw()
        {
            if (zedGraphControl1.GraphPane.CurveList.Count <= 0)
                return;

            LineItem curve = zedGraphControl1.GraphPane.CurveList[0] as LineItem;

            if (curve == null)
                return;

            IPointListEdit list = curve.Points as IPointListEdit;

            if (list == null)
                return;

            list.Add(time, data);
            Console.WriteLine(list);
              
           
            Scale xScale = zedGraphControl1.GraphPane.XAxis.Scale;
            
            Scale yScale = zedGraphControl1.GraphPane.YAxis.Scale;

            // Tự động Scale theo trục x
            if (time > xScale.Max - xScale.MajorStep)
            {
                xScale.Max = time + xScale.MajorStep;
                xScale.Min = xScale.Max - 30;
            }

            // Tự động Scale theo trục y
            if (data > yScale.Max - yScale.MajorStep)
            {
                yScale.Max = data + yScale.MajorStep;
            }
            else if (data < yScale.Min + yScale.MajorStep)
            {
                yScale.Min = data - yScale.MajorStep;
            }
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            zedGraphControl1.Refresh();
        }
        // vẽ đồ thị 
        private void Draw1()
        {

            if (zedGraphControl1.GraphPane.CurveList.Count <= 0)
                return;

            LineItem curve = zedGraphControl1.GraphPane.CurveList[0] as LineItem;

            if (curve == null)
                return;

            IPointListEdit list = curve.Points as IPointListEdit;

            if (list == null)
                return;

            list.Add(time2, data2);
            Console.WriteLine(list);


            Scale xScale = zedGraphControl1.GraphPane.XAxis.Scale;

            Scale yScale = zedGraphControl1.GraphPane.YAxis.Scale;

            // Tự động Scale theo trục x
            if (time2 > xScale.Max - xScale.MajorStep)
            {
                xScale.Max = time2 + xScale.MajorStep;
                xScale.Min = xScale.Max - 30;
            }

            // Tự động Scale theo trục y
            if (data2 > yScale.Max - yScale.MajorStep)
            {
                yScale.Max = data2 + yScale.MajorStep;
            }
            else if (data2 < yScale.Min + yScale.MajorStep)
            {
                yScale.Min = data2 - yScale.MajorStep;
            }
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            zedGraphControl1.Refresh();
        }
        // xóa đồ thị
        void ClearZedGraph()
        {
            zedGraphControl1.GraphPane.CurveList.Clear(); // Xóa đường
            zedGraphControl1.GraphPane.GraphObjList.Clear(); // Xóa đối tượng

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();

            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "Đồ thị dữ liệu theo thời gian";
            myPane.XAxis.Title.Text = "Thời gian (s)";
            myPane.YAxis.Title.Text = "Dữ liệu";

            RollingPointPairList list = new RollingPointPairList(60000);
            LineItem curve = myPane.AddCurve("Dữ liệu", list, Color.Red, SymbolType.None);

            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 30;
            myPane.XAxis.Scale.MinorStep = 1;
            myPane.XAxis.Scale.MajorStep = 5;
            myPane.YAxis.Scale.Min = 0;
            myPane.YAxis.Scale.Max = 0;

            zedGraphControl1.AxisChange();
        }
        // xóa dữ liệu trong đồ thị

        int s = 0;
        private void graph_Click(object sender, EventArgs e)
        {
            graph.BackColor = Color.Red;
            button11.BackColor = Color.FromArgb(38, 39, 59);
            
            if (s == 0)
            {
                button8_Click(sender, e);
                s++;
                v = 0;
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        // xóa hàng trong gridview
        void deleterow()
        {
            foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
            {
                Console.WriteLine(dataGridView2.Rows[item.Index].Cells[0].Value.ToString());
                Console.WriteLine(item.Index);
                dataGridView2.Rows.RemoveAt(item.Index);
                Console.WriteLine("giá trị của cột");
            }
        }
        float time2;
        float data2;
        // chuyển dữ liệu từ data2 sang data1
        void transferdata()
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                string x = dataGridView1.Rows[item.Index].Cells[1].Value.ToString();
                string y= dataGridView1.Rows[item.Index].Cells[2].Value.ToString();
                time2 = float.Parse(x);
                data2 = float.Parse(y);
                Console.WriteLine(item.Index);
                dataGridView2.DataSource = dt2;
                DataRow row2;
                row2 = dt2.NewRow();
                row2["KN"] = dataGridView1.Rows[item.Index].Cells[1].Value.ToString();
                row2["MM"] = dataGridView1.Rows[item.Index].Cells[2].Value.ToString();
                /*for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = (i + 1);
                }*/
                dt2.Rows.Add(row2);
                if (b == 1)
                {
                    Draw1();
                }
                

            }
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            /*foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                Console.WriteLine(dataGridView1.Rows[item.Index].Cells[0].Value.ToString());
                Console.WriteLine(item.Index);
                //dataGridView1.Rows.RemoveAt(item.Index);
                Console.WriteLine("giá trị của cột");
            }*/
            deleterow();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            button4_Click( sender, e);
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        // xóa đồ thị
        int c = 0;
        private void button8_Click(object sender, EventArgs e)
        {
            
            if (c == 0)
            {
                b = 1;
                c++;
            }
            else
            {
                b = 0;
                c = 0;
            }
            ClearZedGraph();
        }
        // chuyển dữ liệu từ data2 sang data1
        private void button9_Click(object sender, EventArgs e)
        {
            transferdata();
            for(int i = 0; i < dt2.Rows.Count; i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = (i + 1);
            }
        }
        int v = 0;
        
        private void button11_Click_1(object sender, EventArgs e)
        {
            graph.BackColor = Color.FromArgb(38, 39, 59);
            button11.BackColor = Color.Red;
            if (v == 0)
            {
                h++;
                button8_Click(sender, e);
                v++;
                s = 0;
            }
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ExportMysql();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            export_Click( sender,  e);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            import_Click( sender, e);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            button6_Click_1( sender, e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            string p = textBox1.Text;
            Console.WriteLine(p);
            String r = "long1";
            string g = p + r;
            Console.WriteLine(g);
            serialPort1.Write(g.Trim());
          
        }
        void swap(object a, object b)
        {
            object c = a;
            a = b;
            b = c;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
            {
                //Console.WriteLine(dataGridView2.Rows[item.Index].Cells[0].Value.ToString());
                //Console.WriteLine(item.Index);
               // dataGridView2.Rows.RemoveAt(item.Index);
             /*int f =int.Parse(dataGridView2.Rows[item.Index].Cells[2].Value.ToString());
             int y = int.Parse(dataGridView2.Rows[item.Index+1].Cells[2].Value.ToString());
               Console.WriteLine(f);
              Console.WriteLine(y);*/
                string x= dataGridView2.Rows[item.Index ].Cells[2].Value.ToString();
                dataGridView2.Rows[item.Index].Cells[2].Value = dataGridView2.Rows[item.Index + 1].Cells[2].Value.ToString();
                dataGridView2.Rows[item.Index+1].Cells[2].Value = x;
                string k = dataGridView2.Rows[item.Index].Cells[1].Value.ToString();
                dataGridView2.Rows[item.Index].Cells[1].Value = dataGridView2.Rows[item.Index + 1].Cells[1].Value.ToString();
                dataGridView2.Rows[item.Index + 1].Cells[1].Value = k;


                //swap(dataGridView2.Rows[item.Index].Cells[2].Value, dataGridView2.Rows[item.Index + 1].Cells[2].Value);
                //dataGridView2.Rows[item.Index].Cells[1].ValuedataGridView2.Rows[item.Index+1].Cells[2].Value.ToString()
                //dataGridView2.Rows[item.Index-1].Cells[1].Value
                // Console.WriteLine(dataGridView2.Rows[item.Index].Cells[1].Value);
                // Console.WriteLine(dataGridView2.Rows[item.Index].Cells[1].Value);
            }
            /*for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }*/
        }

        private void button14_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
            {
                
                string x = dataGridView2.Rows[item.Index].Cells[2].Value.ToString();
                dataGridView2.Rows[item.Index].Cells[2].Value = dataGridView2.Rows[item.Index - 1].Cells[2].Value.ToString();
                dataGridView2.Rows[item.Index - 1].Cells[2].Value = x;
                string k = dataGridView2.Rows[item.Index].Cells[1].Value.ToString();
                dataGridView2.Rows[item.Index].Cells[1].Value = dataGridView2.Rows[item.Index - 1].Cells[1].Value.ToString();
                dataGridView2.Rows[item.Index - 1].Cells[1].Value = k;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            exportexcell();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            /*for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                
                time = float.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()) ;
                    data= float.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                 Console.WriteLine(time);
                 Console.WriteLine(data);


            }*/
        }
        int q = 0;
        
        private void button19_Click(object sender, EventArgs e)
        {
            /*q++;
            ClearZedGraph();*/
        }

        private void button20_Click(object sender, EventArgs e)
        {

            

            cartesianChart3.Series = new SeriesCollection
             {
                 new LineSeries
                 {

                     Values = new ChartValues<ObservablePoint>
                     {
                         new ObservablePoint(0,10),      //First Point of First Line
                         new ObservablePoint(4,7),       //2nd POint
                         new ObservablePoint(5,3),     //------
                         new ObservablePoint(7,6),
                         new ObservablePoint(10,8)
                     },
                    // LineSmoothness = 0.6,
                     PointGeometrySize = 10,
                     
                    StrokeThickness = 4,
                    
                     //ScalesYAt = 1
                 }


             };
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
            
        
    
    

    


    


    

