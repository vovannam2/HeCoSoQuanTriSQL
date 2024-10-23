using quanlylaptop.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlylaptop
{
    public partial class Form_Laptop : Form
    {

        //MyConnect myconn = new MyConnect();
        public Form_Laptop()
        {
            InitializeComponent();
        }
        MyConnect myconn = new MyConnect();
        private void Form_Laptop_Load(object sender, EventArgs e)
        {
            ClassDAL classDAL = new ClassDAL();
            classDAL.loadData("select * from view1_LaptopDangBan", dgv_Laptop);
        }

        private void dgv_Laptop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào hàng hợp lệ không
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_Laptop.Rows[e.RowIndex];

                // Gán giá trị vào các TextBox tương ứng, thực hiện chuyển đổi kiểu dữ liệu khi cần
                this.txt_MaLT.Text = row.Cells["MaLT"].Value.ToString();
                this.txt_TenLT.Text = row.Cells["TenLT"].Value.ToString();
                this.txt_TenHangLT.Text = row.Cells["TenHangLT"].Value.ToString();

                // Chuyển đổi kiểu dữ liệu cho các trường cần thiết
                this.txt_SoLuong.Text = Convert.ToInt32(row.Cells["SoLuong"].Value).ToString();
                this.txt_KhoiLuong.Text = Convert.ToDecimal(row.Cells["KhoiLuong"].Value).ToString("F2"); // Định dạng số thập phân
                this.txt_ThoiGianBaoHanh.Text = Convert.ToInt32(row.Cells["ThoiGianBaoHanh"].Value).ToString();

                this.txt_GiaBanGoc.Text = row.Cells["GiaBanGoc"].Value.ToString();
                this.txt_MauSac.Text = row.Cells["MauSac"].Value.ToString();
                this.txt_DungLuongBoNho.Text = row.Cells["DungLuongBoNho"].Value.ToString();
                this.txt_ManHinh.Text = row.Cells["ManHinh"].Value.ToString();
                this.txt_CPU.Text = row.Cells["CPU"].Value.ToString();
                this.txt_QuaTangKem.Text = row.Cells["QuaTangKem"].Value.ToString();
                this.txt_Pin.Text = row.Cells["Pin"].Value.ToString();
                // Chuyển sang tab Options
                this.tabControl1.SelectedTab = this.tabPage2;
            }
        }

        private void btn_addLapTop_Click(object sender, EventArgs e)
        {
            string MaLT = txt_MaLT.Text.Trim(); // Mã laptop
            string TenLT = txt_TenLT.Text.Trim(); // Tên laptop
            string TenHangLT = txt_TenHangLT.Text.Trim(); // Tên hãng laptop
            int SoLuong = int.Parse(txt_SoLuong.Text.Trim()); // Số lượng
            decimal KhoiLuong = decimal.Parse(txt_KhoiLuong.Text.Trim()); // Khối lượng
            int ThoiGianBaoHanh = int.Parse(txt_ThoiGianBaoHanh.Text.Trim()); // Thời gian bảo hành
            int GiaBanGoc = int.Parse(txt_GiaBanGoc.Text.Trim()); // Giá bán gốc
            string MauSac = txt_MauSac.Text.Trim(); // Màu sắc
            string DungLuongBoNho = txt_DungLuongBoNho.Text.Trim(); // Dung lượng bộ nhớ
            string ManHinh = txt_ManHinh.Text.Trim(); // Thông tin màn hình
            string CPU = txt_CPU.Text.Trim(); // Thông tin CPU
            string QuaTangKem = txt_QuaTangKem.Text.Trim(); // Quà tặng kèm theo
            string Pin = txt_Pin.Text.Trim(); // Thông tin pin

            try
            {
                myconn.openConnectionAdmin();
                SqlCommand cmd = new SqlCommand("proc_AddLaptop", myconn.getConnectionAdmin);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào thủ tục
                cmd.Parameters.Add("@MaLT", SqlDbType.VarChar).Value = MaLT;
                cmd.Parameters.Add("@TenLT", SqlDbType.NVarChar).Value = TenLT;
                cmd.Parameters.Add("@TenHangLT", SqlDbType.NVarChar).Value = TenHangLT;
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = SoLuong;
                cmd.Parameters.Add("@KhoiLuong", SqlDbType.Decimal).Value = KhoiLuong;
                cmd.Parameters.Add("@ThoiGianBaoHanh", SqlDbType.Int).Value = ThoiGianBaoHanh;
                cmd.Parameters.Add("@GiaBanGoc", SqlDbType.Int).Value = GiaBanGoc;
                cmd.Parameters.Add("@MauSac", SqlDbType.NVarChar).Value = MauSac;
                cmd.Parameters.Add("@DungLuongBoNho", SqlDbType.NVarChar).Value = DungLuongBoNho;
                cmd.Parameters.Add("@ManHinh", SqlDbType.NVarChar).Value = ManHinh;
                cmd.Parameters.Add("@CPU", SqlDbType.NVarChar).Value = CPU;
                cmd.Parameters.Add("@QuaTangKem", SqlDbType.NVarChar).Value = QuaTangKem;
                cmd.Parameters.Add("@Pin", SqlDbType.NVarChar).Value = Pin;

                // Thực thi thủ tục
                cmd.ExecuteNonQuery();

                // Nếu không xảy ra lỗi, thông báo thành công
                MessageBox.Show("Thêm laptop thành công!", "Add Laptop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form_Laptop_Load(sender, e); // Gọi lại phương thức load nếu cần để cập nhật dữ liệu
                tabControl1.SelectedIndex = 0; // Chuyển về tab đầu tiên nếu cần

            }
            catch (SqlException ex) // Bắt lỗi SqlException
            {
                // Hiển thị thông báo lỗi từ trigger
                MessageBox.Show($"Thêm laptop thất bại: {ex.Message}", "Add Laptop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myconn.closeConnectionAdmin(); // Đảm bảo kết nối được đóng trong mọi trường hợp
            }
        }
    }
}
