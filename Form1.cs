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
            SaveFileDialog saveFileDialog = new SaveFileDialog();
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
            }
        }
        private void importExcel(string path)
        {
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                DataTable dataTable = new DataTable();
                for (int i = excelWorksheet.Dimension.Start.Column; i <= excelWorksheet.Dimension.End.Column; i++)
                {
                    dataTable.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());
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
                dataGridView1.DataSource = dataTable;
            }
        }

        private void exportExel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;

        }

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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("nhập file không thành công!\n" + ex.Message);
                }
            }
        }
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
            if (!serialPort1.IsOpen) // Nếu đối tượng serialPort1 chưa được mở , sau khi nhấn button 1 thỳ…
            {
                serialPort1.PortName = "COM4";//cổng serialPort1 = ComboBox mà bạn đang chọn
                serialPort1.Open();// Mở cổng serialPort1
                Console.WriteLine("ta đã vô đây rồi nghe mở kết nối");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();//Đóng cổng Serial sau khi button 4 được nhấn
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                String y = "long1";
                serialPort1.Write(y);//Nếu button2 được nhấn,gửi byte “1” đến cổng serialPort1

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                String x = "long2";
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



        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void ledvang_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            dt.Columns.Add("TenSV");
            dt.Columns.Add("MASV");
            // Khởi tạo ZedGraph
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
            myPane.YAxis.Scale.Min = -100;
            myPane.YAxis.Scale.Max = 100;
            try
            {

                //string[] arrList = new List<string>();
                string[] arrList = new string[5];
                arrList = serialPort1.ReadLine().Split('|'); // Đọc một dòng của Serial, cắt chuỗi khi gặp ký tự gạch đứng

                String name;
                String value;
                name = arrList[0]; // Chuỗi đầu tiên lưu vào SRealTime
                value = arrList[1]; // Chuỗi thứ hai lưu vào SDatas

             
            }
            catch
            {
                return;
            }

        }
        int lo = 0;
        int t = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (lo == 1)
            {
                
                Draw();
                button12_Click(sender, e);
                //ExportMysql();
                lo = 0;
                //Console.WriteLine("ta đã vô đây rồi nghe, trong vòng lặp timer");
            }
            
            
        }
        String name;
        String value;

        int time;
        int data ;
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            

            if (serialPort1.IsOpen == true)
            {
                Console.WriteLine("ta đã vô đây rồi nghe datareceived");
                
                //Console.WriteLine("received y");
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
                    Console.WriteLine(datareceived);                                    //Console.WriteLine(data);
                    if (datareceived.Contains('h')) {
                        
                    string name = datareceived.Substring(0, datareceived.IndexOf("h")-1);
                    string value = datareceived.Substring(datareceived.IndexOf("h")+1);
                        time = int.Parse(name);
                        data = int.Parse(value);
                        Console.WriteLine(time);
                        Console.WriteLine(data);
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

        private void button10_Click(object sender, EventArgs e)
        {
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
            if (serialPort1.IsOpen == true)
            {
                String x = "long4";
                serialPort1.Write(x);//gửi byte “0” đến cổng serialPort1

            }
        }
        DataTable dt = new DataTable();
        
        
        
        
        private void button12_Click(object sender, EventArgs e)
        {
            if (t == 1) { 
            dataGridView1.DataSource = dt;
            DataRow row;
            row = dt.NewRow();
            row["TenSV"] = time;
            row["MASV"] = data;
            dt.Rows.Add(row);
                t = 0;
            }
            /* dataGridView1.DataSource = list;
                  dataGridView1 = new DataGridView();*/
        }
      
        
        private void Draw()
        {

            if (zedGraphControl1.GraphPane.CurveList.Count <= 0)
                return;

            LineItem curve = zedGraphControl1.GraphPane.CurveList[0] as LineItem;

            if (curve == null)
                return;

            IPointListEdit list = curve.Points as IPointListEdit;

                list.Add(time, data);
              
           
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
        
        private void graph_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }
    }
}
            
        
    
    

    


    


    

