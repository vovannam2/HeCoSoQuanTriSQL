using quanlylaptop.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
        ClassDAL classDAL = new ClassDAL();
        private void Form_Laptop_Load(object sender, EventArgs e)
        {
            ClassDAL classDAL = new ClassDAL();
            classDAL.loadData("select * from v1_infLaptop", dgv_Laptop);
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


        private void remove_Laptop(String maLT)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa laptop này không?", "Remove laptop", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {

                    SqlCommand cmd = new SqlCommand("EXEC proc_DeleteLaptop @MaLT", myconn.getConnectionAdmin);
                    cmd.Parameters.Add("@MaLT", SqlDbType.NChar, 10).Value = maLT;
                    myconn.openConnectionAdmin();
                    if (cmd.ExecuteNonQuery() == -1)
                    {
                        MessageBox.Show("Xóa thành công!", "Remove Laptop", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);

                        myconn.closeConnectionAdmin();

                        classDAL.loadData("select * from view1_LaptopDangBan", dgv_Laptop);
                        tabControl1.SelectedTab = this.tabPage1;
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại 1001!", "Remove Laptop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        myconn.closeConnectionAdmin();

                    }
                }
            }
            catch
            {
                MessageBox.Show("Xóa thất bại! 1002", "Remove Laptop", MessageBoxButtons.OK,
               MessageBoxIcon.Error);

            }
        }

        private void btn_xoaLaptop_Click(object sender, EventArgs e)
        {
            String maLT = txt_MaLT.Text;
            remove_Laptop(maLT);
        }

        private void btn_updateLaptop_Click(object sender, EventArgs e)
        {
            String maLT = txt_MaLT.Text;
            String tenLT = txt_TenLT.Text;
            String tenHangLT = txt_TenHangLT.Text;
            if (int.TryParse(txt_SoLuong.Text, out int soLuongLT) &&
                decimal.TryParse(txt_KhoiLuong.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal khoiLuong) &&
                int.TryParse(txt_ThoiGianBaoHanh.Text, out int thoiGianBaoHanh) &&
                int.TryParse(txt_GiaBanGoc.Text, out int giaBanGoc))
            {
                String mauSac = txt_MauSac.Text;
                String dungLuongBoNho = txt_DungLuongBoNho.Text;
                String manHinh = txt_ManHinh.Text;
                String cpu = txt_CPU.Text;
                String quaTangKem = string.IsNullOrWhiteSpace(txt_QuaTangKem.Text) ? "Không có" : txt_QuaTangKem.Text;
                String pin = txt_Pin.Text;
                bool isUpdated = UpdateLaptop(maLT, tenLT, tenHangLT, soLuongLT, khoiLuong, thoiGianBaoHanh, giaBanGoc,
                    mauSac, dungLuongBoNho, manHinh, cpu, quaTangKem, pin);

                // Hiển thị thông báo thành công hoặc thất bại
                if (isUpdated)
                {

                    MessageBox.Show("Cập nhật máy tính thành công!!!", "thành công", MessageBoxButtons.OK);
                    classDAL.loadData("select * from view1_LaptopDangBan", dgv_Laptop);
                    this.tabControl1.SelectedTab = this.tabPage1;

                }
                else
                {
                    MessageBox.Show("Cập nhật máy tính thất bại, vui lòng kiểm tra lại.", "Thất bại", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng cho các trường dữ liệu.");
            }
        }
        public Boolean UpdateLaptop(string maLT, string tenLT, string tenHangLT, int soLuong, decimal khoiLuong, int thoiGianBaoHanh, int giaBanGoc, string mauSac, string dungLuongBoNho, string manHinh, string cpu, string quaTangKem, string pin)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("pro_CapNhatLaptop", myconn.getConnectionAdmin))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số cho stored procedure
                    cmd.Parameters.Add("@MaLT", SqlDbType.VarChar, 50).Value = maLT;
                    cmd.Parameters.Add("@TenLT", SqlDbType.NVarChar, 50).Value = tenLT;
                    cmd.Parameters.Add("@TenHangLT", SqlDbType.NVarChar, 100).Value = tenHangLT;
                    cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = soLuong;
                    cmd.Parameters.Add("@KhoiLuong", SqlDbType.Decimal).Value = khoiLuong;
                    cmd.Parameters.Add("@ThoiGianBaoHanh", SqlDbType.Int).Value = thoiGianBaoHanh;
                    cmd.Parameters.Add("@GiaBanGoc", SqlDbType.Int).Value = giaBanGoc;
                    cmd.Parameters.Add("@MauSac", SqlDbType.NVarChar, 50).Value = mauSac;
                    cmd.Parameters.Add("@DungLuongBoNho", SqlDbType.NVarChar, 50).Value = dungLuongBoNho;
                    cmd.Parameters.Add("@ManHinh", SqlDbType.NVarChar, 50).Value = manHinh;
                    cmd.Parameters.Add("@CPU", SqlDbType.NVarChar, 100).Value = cpu;
                    cmd.Parameters.Add("@QuaTangKem", SqlDbType.NVarChar, 255).Value = quaTangKem ?? "Không có";
                    cmd.Parameters.Add("@Pin", SqlDbType.NVarChar, 50).Value = pin;

                    myconn.openConnectionAdmin();

                    // Thực thi lệnh
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return true; // Cập nhật thành công
                    }
                    else
                    {
                        return false; // Không có dòng nào bị thay đổi
                    }
                }
            }
            catch (SqlException ex) // Bắt lỗi SQL
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                return false;
            }
            catch (Exception ex) // Bắt lỗi khác
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                return false;
            }
            finally
            {
                myconn.closeConnectionAdmin();
            }

        }

        private void txt_TimKiemLT_TenLT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tenKh = txt_TimKiemLT_TenLT.Text.Trim(); // Lấy tên khách hàng từ ô tìm kiếm

                if (!string.IsNullOrEmpty(tenKh))
                {
                    // Nếu có tên khách hàng, tạo query để tìm kiếm
                    string query = $"SELECT * FROM TimKiemLaptopTheoTen('{tenKh}')"; // Thay thế bằng tên hàm tìm kiếm trong SQL Server
                    ClassDAL classDAL = new ClassDAL();
                    classDAL.loadData(query, dgv_Laptop); // Gọi hàm loadData để đổ dữ liệu vào DataGridView
                }
                else
                {
                    // Nếu ô tìm kiếm trống, tải lại toàn bộ dữ liệu của khách hàng
                    Form_Laptop_Load(sender, e);
                }
            }
        }
    }
}
