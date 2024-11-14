using quanlylaptop.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;





namespace quanlylaptop
{
    public partial class Form_ThongKe : Form
    {
        public Form_ThongKe()
        {
            InitializeComponent();
        }
        ClassDAL classDAL = new ClassDAL();
        private void Form_ThongKe_Load(object sender, EventArgs e)
        {
            classDAL.loadData("EXEC ThongKeDoanhThuTheoThang;", dgv_ThongKe);
            classDAL.loadData("EXEC ThongKeSoLuongBan;", dgv_SLBan);
            DrawChartDoanhThu();
            HighlightLastRow();
            DrawChartTopBestSellers();
        }
        private void HighlightLastRow()
        {
            // Kiểm tra xem dgv có dữ liệu không
            if (dgv_ThongKe.Rows.Count > 0)
            {
                // Lấy chỉ số của hàng cuối cùng
                int lastRowIndex = dgv_ThongKe.Rows.Count - 1;

                // Tô màu hàng cuối cùng
                dgv_ThongKe.Rows[lastRowIndex].DefaultCellStyle.BackColor = Color.FromArgb(20, 81, 68);  // Bạn có thể chọn màu khác
                dgv_ThongKe.Rows[lastRowIndex].DefaultCellStyle.ForeColor = Color.White; // Tô màu chữ nếu cần
            }
        }

        private void btn_TimKiem_ThongKe_Click(object sender, EventArgs e)
        {
            dgv_ThongKe.Rows.Clear();
            DateTime inputDate = dtp_Ngay.Value;
            classDAL.loadData($"EXEC ThongKeDoanhThuTheoNgay '{inputDate.ToString("yyyy-MM-dd")}'", dgv_ThongKe);
            dgv_ThongKe.Columns["Thang"].HeaderText = "Ngày";
            dgv_ThongKe.Columns["Thang"].DefaultCellStyle.Format = "dd/MM/yyyy"; // Định dạng ngày
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            classDAL.loadData("EXEC ThongKeDoanhThuTheoThang;", dgv_ThongKe);
            dgv_ThongKe.Columns["Thang"].HeaderText = "Tháng";
            dgv_ThongKe.Columns["Thang"].DefaultCellStyle.Format = string.Empty;
            HighlightLastRow();
        }
        private void DrawChartDoanhThu()
        {
            // Lấy dữ liệu từ cơ sở dữ liệu
            DataTable dt = classDAL.LoadDatas("EXEC ThongKeDoanhThuTheoThang;");
            // Khởi tạo series cho biểu đồ
            var series = new LineSeries
            {
                Title = "Doanh Thu",
                Values = new ChartValues<double>() // Giá trị biểu đồ
            };

            // Lấy doanh thu cho từng tháng
            int currentMonth = DateTime.Now.Month; // Lấy tháng hiện tại
            for (int i = 1; i <= currentMonth; i++) // Bắt đầu từ 1 đến currentMonth
            {
                double doanhThu = 0; // Giá trị mặc định
                                     // Tìm kiếm doanh thu trong DataTable
                var row = dt.AsEnumerable().FirstOrDefault(r => r.Field<string>("Thang") == i.ToString());
                if (row != null)
                {
                    doanhThu = Convert.ToDouble(row["DoanhThuTheoThang"]);
                }
                series.Values.Add(doanhThu); // Thêm doanh thu vào biểu đồ
            }
            // Xóa tất cả các series hiện có và thêm series mới vào biểu đồ
            chart1.Series.Clear(); // Dùng chart1 thay vì cartesianChart1
            chart1.Series.Add(series);
            // Thiết lập trục Y để bắt đầu từ 0
            chart1.AxisY.Clear(); // Xóa các trục Y hiện tại
            chart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Doanh Thu",
                MinValue = 0 // Thiết lập giá trị nhỏ nhất cho trục Y là 0
            });

            // Thiết lập các nhãn cho trục X
            chart1.AxisX.Clear(); // Xóa các trục X hiện tại
            chart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Tháng",
                Labels = Enumerable.Range(1, currentMonth).Select(x => x.ToString()).ToList() // Tạo nhãn cho các tháng
            });

            // Thiết lập tiêu đề cho biểu đồ
            chart1.LegendLocation = LegendLocation.Bottom; // Nếu sử dụng Legend

        }
        private void DrawChartTopBestSellers()
        {
            DataTable dt = classDAL.LoadDatas("EXEC ThongKeTop5Bestseller;");

            // Kiểm tra nếu DataTable có dữ liệu
            if (dt.Rows.Count > 0)
            {
                // Thiết lập biểu đồ
                chart2.Series.Clear();
                chart2.AxisX.Clear();
                chart2.AxisY.Clear();

                // Đặt tên cho biểu đồ


                // Thêm series cho từng laptop
                foreach (DataRow row in dt.Rows)
                {
                    string maLT = row["MaLT"].ToString();
                    var series = new LineSeries
                    {
                        Title = maLT,
                        Values = new ChartValues<int> // Sử dụng int cho số lượng bán
            {
                Convert.ToInt32(row["Thang1"]),
                Convert.ToInt32(row["Thang2"]),
                Convert.ToInt32(row["Thang3"]),
                Convert.ToInt32(row["Thang4"]),
                Convert.ToInt32(row["Thang5"]),
                Convert.ToInt32(row["Thang6"]),
                Convert.ToInt32(row["Thang7"]),
                Convert.ToInt32(row["Thang8"]),
                Convert.ToInt32(row["Thang9"]),
                Convert.ToInt32(row["Thang10"]),
                Convert.ToInt32(row["Thang11"]),
                Convert.ToInt32(row["Thang12"])
            }
                    };

                    chart2.Series.Add(series);
                }

                // Thiết lập nhãn trục
                chart2.AxisX.Add(new Axis
                {
                    Title = "Tháng",
                    Labels = new[] { "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12" }
                });

                chart2.AxisY.Add(new Axis
                {
                    Title = "Số lượng bán"
                });
            }
        }


    }
}



