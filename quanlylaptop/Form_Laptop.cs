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

        
        public Form_Laptop()
        {
            InitializeComponent();
        }
        MyConnect myconn = new MyConnect(Properties.Settings.Default.IsAdmin);
        ClassDAL classDAL = new ClassDAL();
        public void Form_Laptop_Load(object sender, EventArgs e)
        {
           
            classDAL.loadData("select * from v1_infLaptop", dgv_Laptop);
            
        }

        private void dgv_Laptop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào hàng hợp lệ không
            if (e.RowIndex >= 0)
            {
                btn_addLapTop.Visible = true;
                DataGridViewRow row = this.dgv_Laptop.Rows[e.RowIndex];

                // Gán giá trị vào các TextBox tương ứng, thực hiện chuyển đổi kiểu dữ liệu khi cần
                this.txt_MaLT.Text = row.Cells["MaLT"].Value.ToString();
                this.txt_TenLT.Text = row.Cells["TenLT"].Value.ToString();

                // Đặt giá trị cho ComboBox
                this.cb2_hanglaptop.SelectedItem = row.Cells["TenHangLT"].Value.ToString();
                this.cb2_mausac.SelectedItem = row.Cells["MauSac"].Value.ToString();
                this.cb2_dungluong.SelectedItem = row.Cells["DungLuongBoNho"].Value.ToString();
                this.cb2_manhinh.SelectedItem = row.Cells["ManHinh"].Value.ToString();

                // Chuyển đổi kiểu dữ liệu cho các trường cần thiết
                this.txt_SoLuong.Text = Convert.ToInt32(row.Cells["SoLuong"].Value).ToString();
                this.txt_KhoiLuong.Text = Convert.ToDecimal(row.Cells["KhoiLuong"].Value).ToString("F2"); // Định dạng số thập phân
                this.txt_ThoiGianBaoHanh.Text = Convert.ToInt32(row.Cells["ThoiGianBaoHanh"].Value).ToString();

                this.txt_GiaBanGoc.Text = row.Cells["GiaBanGoc"].Value.ToString();
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
            string TenHangLT = cb2_hanglaptop.Text.Trim(); // Tên hãng laptop
            int SoLuong = int.Parse(txt_SoLuong.Text.Trim()); // Số lượng
            decimal KhoiLuong = decimal.Parse(txt_KhoiLuong.Text.Trim()); // Khối lượng
            int ThoiGianBaoHanh = int.Parse(txt_ThoiGianBaoHanh.Text.Trim()); // Thời gian bảo hành
            int GiaBanGoc = int.Parse(txt_GiaBanGoc.Text.Trim()); // Giá bán gốc
            string MauSac = cb2_mausac.Text.Trim(); // Màu sắc
            string DungLuongBoNho = cb2_dungluong.Text.Trim(); // Dung lượng bộ nhớ
            string ManHinh = cb2_manhinh.Text.Trim(); // Thông tin màn hình
            string CPU = txt_CPU.Text.Trim(); // Thông tin CPU
            string QuaTangKem = txt_QuaTangKem.Text.Trim(); // Quà tặng kèm theo
            string Pin = txt_Pin.Text.Trim(); // Thông tin pin
            SqlConnection con = myconn.getConnection;
            try
            {
                myconn.openConnection(con);
                SqlCommand cmd = new SqlCommand("proc_AddLaptop", con);
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
                myconn.closeConnection(con); // Đảm bảo kết nối được đóng trong mọi trường hợp
            }
        }

        private void btn_xoaLaptop_Click(object sender, EventArgs e)
        {
            String maLT = txt_MaLT.Text;
            ClassDAL dal = new ClassDAL();
            dal.ThucThi("EXEC proc_DeleteLaptop @MaLT = " + maLT + "");
            Form_Laptop_Load(sender, e);
            tabControl1.SelectedIndex = 0;
           
        }

        private void btn_updateLaptop_Click(object sender, EventArgs e)
        {
            String maLT = txt_MaLT.Text;
            String tenLT = txt_TenLT.Text;
            String tenHangLT = cb2_hanglaptop.Text;
            if (int.TryParse(txt_SoLuong.Text, out int soLuongLT) &&
                decimal.TryParse(txt_KhoiLuong.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal khoiLuong) &&
                int.TryParse(txt_ThoiGianBaoHanh.Text, out int thoiGianBaoHanh) &&
                int.TryParse(txt_GiaBanGoc.Text, out int giaBanGoc))
            {
                String mauSac = cb2_mausac.Text;
                String dungLuongBoNho = cb2_dungluong.Text;
                String manHinh = cb2_manhinh.Text;
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
            SqlConnection con = myconn.getConnection;
            try
            {
                myconn.openConnection(con);
                using (SqlCommand cmd = new SqlCommand("pro_CapNhatLaptop", con))
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
                myconn.closeConnection(con);
            }

        }

        private void txt_TimKiemLT_TenLT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }
        }

        

        // Phương thức lọc dữ liệu chung
        private void FilterData()
        {
            // Thu thập giá trị từ ComboBox
            string hangSX = string.IsNullOrWhiteSpace(cb1_HangLaptop.Text) ? null : cb1_HangLaptop.Text.Trim();
            decimal? giaMax = null;
            if (decimal.TryParse(cb_giaMax.Text.Trim(), out decimal price))
            {
                giaMax = price;
            }
            string dungLuongBoNho = string.IsNullOrWhiteSpace(cb1_dungluong.Text) ? null : cb1_dungluong.Text.Trim();
            string manHinh = string.IsNullOrWhiteSpace(cb1_KichThuocManHinh.Text) ? null : cb1_KichThuocManHinh.Text.Trim();
            string mauSac = string.IsNullOrWhiteSpace(cb1_mausac.Text) ? null : cb1_mausac.Text.Trim();

            // Tạo câu truy vấn dựa trên các giá trị đã chọn
            string query = $"SELECT * FROM dbo.FLocLaptop({(string.IsNullOrEmpty(hangSX) ? "NULL" : $"N'{hangSX}'")}, {(giaMax.HasValue ? giaMax.ToString() : "NULL")}, {(string.IsNullOrEmpty(dungLuongBoNho) ? "NULL" : $"N'{dungLuongBoNho}'")}, {(string.IsNullOrEmpty(manHinh) ? "NULL" : $"N'{manHinh}'")}, {(string.IsNullOrEmpty(mauSac) ? "NULL" : $"N'{mauSac}'")})";

            Console.WriteLine(query); // In câu truy vấn ra console hoặc log để kiểm tra

            // Gọi phương thức loadData và truyền câu query
            classDAL.loadData(query, dgv_Laptop);

            if (dgv_Laptop.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa lựa chọn trong các ComboBox
                cb1_HangLaptop.SelectedIndex = -1;
                cb_giaMax.SelectedIndex = -1;
                cb1_dungluong.SelectedIndex = -1;
                cb1_KichThuocManHinh.SelectedIndex = -1;
                cb1_mausac.SelectedIndex = -1;

                // Bạn có thể gọi LoadInitialData để nạp lại dữ liệu nếu cần
                classDAL.loadData("select * from v1_infLaptop", dgv_Laptop);
            }
        }

        private void cb_giaMax_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void cb1_HangLaptop_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void cb1_dungluong_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void cb1_mausac_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void cb1_KichThuocManHinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.txt_MaLT.Text = string.Empty;
            this.txt_TenLT.Text = string.Empty;
            this.txt_SoLuong.Text = string.Empty;
            this.txt_KhoiLuong.Text = string.Empty;
            this.txt_GiaBanGoc.Text = string.Empty;
            this.txt_Pin.Text = string.Empty;
            this.txt_QuaTangKem.Text = string.Empty;
            this.txt_CPU.Text = string.Empty;


            this.tabControl1.SelectedTab = this.tabPage1;
            this.label19.Text = "TÙY CHỈNH THÔNG TIN LAPTOP";
            this.btn_updateLaptop.Visible = true;
            this.btn_xoaLaptop.Visible = true;
            this.btn_addLapTop.Visible = false;
        }

        private void btn_Add_Laptop_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage2;
            this.label19.Text = "THÊM LAPTOP";
            this.btn_updateLaptop.Visible = false; // Ẩn nút "Thêm"
            this.btn_xoaLaptop.Visible = false; // Ẩn nút "Thêm"
            this.btn_addLapTop.Visible = true;
        }
    }
}
