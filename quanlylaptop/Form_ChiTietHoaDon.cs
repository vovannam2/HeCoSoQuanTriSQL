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
        public Form_ChiTietHoaDon()
        {
            InitializeComponent();
        }
        MyConnect db = new MyConnect();
        ClassDAL classDAL = new ClassDAL();
        private void dgv_ChiTietHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            ClassDAL classDAL = new ClassDAL();
            classDAL.loadData("select * from ChiTietHoaDon", dgv_ChiTietHD);
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
                // Tạo SqlCommand để gọi stored procedure
                SqlCommand cmd = new SqlCommand("EXEC ThemChiTietHoaDon @MaLT, @MaHD, @SoLuongSP, @GiaBanTungSP, @ThueVAT, @KhuyenMai, @ThanhTienSauthue", db.getConnectionAdmin);

                // Thêm các tham số vào SqlCommand
                cmd.Parameters.Add("@MaLT", SqlDbType.VarChar, 50).Value = maLT;
                cmd.Parameters.Add("@MaHD", SqlDbType.VarChar, 50).Value = maHD;
                cmd.Parameters.Add("@SoLuongSP", SqlDbType.Int).Value = soLuongSP;
                cmd.Parameters.Add("@GiaBanTungSP", SqlDbType.Int).Value = giaBanTungSP;
                cmd.Parameters.Add("@ThueVAT", SqlDbType.Int).Value = thueVAT;
                cmd.Parameters.Add("@KhuyenMai", SqlDbType.Int).Value = khuyenMai;
                cmd.Parameters.Add("@ThanhTienSauthue", SqlDbType.Int).Value = thanhTienTungSP;

                // Mở kết nối cơ sở dữ liệu
                db.openConnectionAdmin();

                // Thực thi stored procedure
                cmd.ExecuteNonQuery();

                // Đóng kết nối
                db.closeConnectionAdmin();

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
                db.closeConnectionAdmin();
                return false;
            }
        }

    }
}
