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
    public partial class Form_ChiTietHoaDon : Form
    {
        public string maHD;
        public Form_ChiTietHoaDon(string maHD)
        {
            InitializeComponent();
            this.maHD = maHD;
        }
        MyConnect myconn = new MyConnect(Properties.Settings.Default.IsAdmin);
        ClassDAL classDAL = new ClassDAL();
        private void dgv_ChiTietHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_ChiTietHD.Rows[e.RowIndex];

                // Gán giá trị vào các TextBox tương ứng, thực hiện chuyển đổi kiểu dữ liệu khi cần
                this.txt_MaLT.Text = row.Cells["MaLT"].Value?.ToString() ?? "";
                this.txt_MaHD.Text = row.Cells["MaHD"].Value?.ToString() ?? "";

                // Chuyển đổi kiểu dữ liệu cho các trường số nguyên và số thập phân
                this.txt_SLSP.Text = Convert.ToInt32(row.Cells["SoLuongSanPham"].Value ?? 0).ToString();
                this.txt_GiaBanTungSP.Text = Convert.ToDecimal(row.Cells["GiaBanTungSP"].Value ?? 0).ToString("F0");
                this.txt_ThueVAT.Text = Convert.ToDecimal(row.Cells["ThueVAT"].Value ?? 0).ToString("F0");
                this.txt_KhuyenMai.Text = Convert.ToDecimal(row.Cells["KhuyenMai"].Value ?? 0).ToString("F0");
                this.txt_ThanhTienSauThue.Text = Convert.ToDecimal(row.Cells["ThanhTienSauThue"].Value ?? 0).ToString("F0");

                // Chuyển sang tab Options (nếu có)
                this.tabControl1.SelectedTab = this.tabPage2;
            }
        }

        private void Form_ChiTietHoaDon_Load(object sender, EventArgs e)
        {

            classDAL.loadData("SELECT * FROM ChiTietHoaDon WHERE MaHD = '" + maHD + "'", dgv_ChiTietHD);
        }

        private void btn_Them_CTHD_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các textbox
            string maLT = txt_MaLT.Text;
            string maHD = txt_MaHD.Text;
            int soLuongSP;
            int giaNhapTungSP;
            int thueVAT;
            int khuyenMai;
            int thanhTienTungSP;

            // Kiểm tra dữ liệu đầu vào hợp lệ
            if (string.IsNullOrWhiteSpace(maLT) || string.IsNullOrWhiteSpace(maHD) ||
                !int.TryParse(txt_SLSP.Text, out soLuongSP) || // Chuyển đổi chuỗi nhập thành số nguyên
                !int.TryParse(txt_GiaBanTungSP.Text, out giaNhapTungSP) ||
                !int.TryParse(txt_ThueVAT.Text, out thueVAT) ||
                !int.TryParse(txt_ThanhTienSauThue.Text, out thanhTienTungSP) ||
                !int.TryParse(txt_KhuyenMai.Text, out khuyenMai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi hàm thêm chi tiết phiếu nhập
            AddChiTietHoaDon(maLT, maHD, soLuongSP, giaNhapTungSP, thueVAT, khuyenMai, thanhTienTungSP);

        }
        public bool AddChiTietHoaDon(string maLT, string maHD, int soLuongSP, int giaBanTungSP, int thueVAT, int khuyenMai, int thanhTienTungSP)
        {
            try
            {
                SqlConnection con = myconn.getConnection;
                myconn.openConnection(con);
                // Tạo SqlCommand để gọi stored procedure
                SqlCommand cmd = new SqlCommand("EXEC ThemChiTietHoaDon @MaLT, @MaHD, @SoLuongSP, @GiaBanTungSP, @ThueVAT, @KhuyenMai, @ThanhTienSauthue", con);

                // Thêm các tham số vào SqlCommand
                cmd.Parameters.Add("@MaLT", SqlDbType.VarChar, 50).Value = maLT;
                cmd.Parameters.Add("@MaHD", SqlDbType.VarChar, 50).Value = maHD;
                cmd.Parameters.Add("@SoLuongSP", SqlDbType.Int).Value = soLuongSP;
                cmd.Parameters.Add("@GiaBanTungSP", SqlDbType.Int).Value = giaBanTungSP;
                cmd.Parameters.Add("@ThueVAT", SqlDbType.Int).Value = thueVAT;
                cmd.Parameters.Add("@KhuyenMai", SqlDbType.Int).Value = khuyenMai;
                cmd.Parameters.Add("@ThanhTienSauthue", SqlDbType.Int).Value = thanhTienTungSP;

                

                // Thực thi stored procedure
                cmd.ExecuteNonQuery();

                // Đóng kết nối
               // myconn.closeConnection(con);

                // Hiển thị thông báo thành công
                MessageBox.Show("Thêm chi tiết hóa đơn thành công", "Thành công", MessageBoxButtons.OK);
                classDAL.loadData("SELECT * FROM ChiTietHoaDon", dgv_ChiTietHD);
                tabControl1.SelectedTab = this.tabPage1;

                return true;
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi nếu có ngoại lệ SQL
                MessageBox.Show("Lỗi thêm chi tiết hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Đóng kết nối nếu có lỗi
             //   myconn.closeConnection(con);
                return false;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Sua_CTHD_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các TextBox
            string MaLT = txt_MaLT.Text.Trim();        // Mã laptop
            string MaHD = txt_MaHD.Text.Trim();        // Mã hóa đơn
            int SoLuongSP = int.Parse(txt_SLSP.Text.Trim()); // Số lượng sản phẩm
            int GiaBanTungSP = int.Parse(txt_GiaBanTungSP.Text.Trim()); // Giá bán từng sản phẩm
            int ThueVAT = int.Parse(txt_ThueVAT.Text.Trim()); // Thuế VAT
            int KhuyenMai = int.Parse(txt_KhuyenMai.Text.Trim()); // Khuyến mãi
           

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn sửa chi tiết hóa đơn này không?",
                "Xác nhận sửa Chi Tiết hóa đơn",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Nếu người dùng chọn "No", dừng thực hiện
            if (result == DialogResult.No)
            {
                return;
            }

            SqlConnection con = myconn.getConnection;
            myconn.openConnection(con);
            try
            {
                // Khởi tạo SqlCommand và đặt thủ tục
                SqlCommand cmd = new SqlCommand("pro_CapNhatChiTietHoaDon", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số cho thủ tục
                cmd.Parameters.Add("@MaLT", SqlDbType.VarChar).Value = MaLT;
                cmd.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = MaHD;
                cmd.Parameters.Add("@SoLuongSP", SqlDbType.Int).Value = SoLuongSP;
                cmd.Parameters.Add("@GiaBanTungSP", SqlDbType.Int).Value = GiaBanTungSP;
                cmd.Parameters.Add("@ThueVAT", SqlDbType.Int).Value = ThueVAT;
                cmd.Parameters.Add("@KhuyenMai", SqlDbType.Int).Value = KhuyenMai;
               

                // Thực thi thủ tục
                cmd.ExecuteNonQuery();

                // Thông báo thành công nếu không có lỗi
                MessageBox.Show("Cập nhật thành công!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại dữ liệu (nếu cần)
                Form_ChiTietHoaDon_Load(sender, e); // Gọi lại phương thức load để cập nhật dữ liệu nếu cần
                tabControl1.SelectedIndex = 0; // Chuyển về tab đầu tiên nếu cần
            }
            catch (SqlException ex) // Bắt lỗi SqlException nếu xảy ra
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show($"Cập nhật thất bại: {ex.Message}", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myconn.closeConnection(con); // Đảm bảo kết nối được đóng trong mọi trường hợp
            }
        }

        private void btn_Xoa_CTHD_Click(object sender, EventArgs e)
        {
            
            ClassDAL dal = new ClassDAL();
            string maLT = txt_MaLT.Text.Trim();
            string maHD = txt_MaHD.Text.Trim();
            dal.ThucThi("EXEC pro_XoaChiTietHoaDon @MaHD = '" + maHD + "', @MaLT = '" + maLT + "'" );
            Form_ChiTietHoaDon_Load(sender, e);
            tabControl1.SelectedIndex = 0;
        }
    }
}
