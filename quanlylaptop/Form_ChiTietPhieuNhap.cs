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
    public partial class Form_ChiTietPhieuNhap : Form
    {
        public string maNK1;
        public Form_ChiTietPhieuNhap(string maNK1)
        {
            InitializeComponent();
            this.maNK1 = maNK1;
        }
        MyConnect myconn = new MyConnect(Properties.Settings.Default.IsAdmin);
        ClassDAL classDAL = new ClassDAL();
        
        private void Form_ChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            
            classDAL.loadData("SELECT * FROM ChiTietPhieuNhap WHERE MaNK = '" + maNK1 + "'", dgv_ChiTietPhieuNhapKho);
        }

        
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form hiện tại
        }

        private void dgv_ChiTietPhieuNhapKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Kiểm tra xem người dùng có click vào hàng hợp lệ không
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_ChiTietPhieuNhapKho.Rows[e.RowIndex];

                // Gán giá trị vào các TextBox tương ứng, thực hiện chuyển đổi kiểu dữ liệu khi cần
                this.txt_MaLT.Text = row.Cells["MaLT"].Value?.ToString() ?? "";
                this.txt_MaNK.Text = row.Cells["MaNK"].Value?.ToString() ?? "";

                // Chuyển đổi kiểu dữ liệu cho các trường số nguyên và số thập phân
                this.txt_SLSP.Text = Convert.ToInt32(row.Cells["SoLuongSanPham"].Value ?? 0).ToString();
                this.txt_GiaNhapTungSP.Text = Convert.ToDecimal(row.Cells["GiaNhapTungSP"].Value ?? 0).ToString("F0");
                this.txt_ThueVAT.Text = Convert.ToDecimal(row.Cells["ThueVAT"].Value ?? 0).ToString("F0");
                this.txt_ThanhTienTungSP.Text = Convert.ToDecimal(row.Cells["ThanhTienTungSanPham"].Value ?? 0).ToString("F0");

                // Chuyển sang tab Options (nếu có)
                this.tabControl1.SelectedTab = this.tabPage2;
            }
        }

        private void btn_Sua_CTPNK_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các TextBox và ComboBox
            string MaLT = txt_MaLT.Text.Trim(); // Mã laptop
            string MaNK = txt_MaNK.Text.Trim(); // Mã nhập kho
            int SoLuongSP = int.Parse(txt_SLSP.Text.Trim()); // Số lượng sản phẩm
            int GiaNhapTungSP = int.Parse(txt_GiaNhapTungSP.Text.Trim()); // Giá nhập từng sản phẩm
            int ThueVAT = int.Parse(txt_ThueVAT.Text.Trim()); // Thuế VAT
          

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn sửa chi tiết phiếu nhập này không?",
                "Xác nhận sửa Chi Tiết Phiếu Nhập",
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
                SqlCommand cmd = new SqlCommand("pro_CapNhatChiTietPhieuNhap", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số cho thủ tục
                cmd.Parameters.Add("@MaLT", SqlDbType.VarChar).Value = MaLT;
                cmd.Parameters.Add("@MaNK", SqlDbType.VarChar).Value = MaNK;
                cmd.Parameters.Add("@SoLuongSP", SqlDbType.Int).Value = SoLuongSP;
                cmd.Parameters.Add("@GiaNhapTungSP", SqlDbType.Int).Value = GiaNhapTungSP;
                cmd.Parameters.Add("@ThueVAT", SqlDbType.Int).Value = ThueVAT;
               

                // Thực thi thủ tục
                cmd.ExecuteNonQuery();

                // Thông báo thành công nếu không có lỗi
                MessageBox.Show("Cập nhật thành công!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại dữ liệu (nếu cần)
                Form_ChiTietPhieuNhap_Load(sender, e); // Gọi lại phương thức load để cập nhật dữ liệu nếu cần
                tabControl1.SelectedIndex = 0; // Chuyển về tab đầu tiên nếu cần
            }
            catch (SqlException ex) // Bắt lỗi SqlException nếu xảy ra
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show($"cập nhật  thất bại: {ex.Message}", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myconn.closeConnection(con); // Đảm bảo kết nối được đóng trong mọi trường hợp
            }
        }

        private void btn_Xoa_CTPNK_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các TextBox và ComboBox
            string MaLT = txt_MaLT.Text.Trim(); // Mã laptop
            string MaNK = txt_MaNK.Text.Trim(); // Mã nhập kho
           


            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa chi tiết phiếu nhập này không?",
                "Xác nhận xóa Chi Tiết Phiếu Nhập",
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
                SqlCommand cmd = new SqlCommand("pro_XoaChiTietPhieuNhap", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số cho thủ tục
                cmd.Parameters.Add("@MaLT", SqlDbType.VarChar).Value = MaLT;
                cmd.Parameters.Add("@MaNK", SqlDbType.VarChar).Value = MaNK;
               

                // Thực thi thủ tục
                cmd.ExecuteNonQuery();

                // Thông báo thành công nếu không có lỗi
                MessageBox.Show("Xóa thành công!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại dữ liệu (nếu cần)
                Form_ChiTietPhieuNhap_Load(sender, e); // Gọi lại phương thức load để cập nhật dữ liệu nếu cần
                tabControl1.SelectedIndex = 0; // Chuyển về tab đầu tiên nếu cần
            }
            catch (SqlException ex) // Bắt lỗi SqlException nếu xảy ra
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show($"xóa  thất bại: {ex.Message}", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myconn.closeConnection(con); // Đảm bảo kết nối được đóng trong mọi trường hợp
            }
        }
    }
}
