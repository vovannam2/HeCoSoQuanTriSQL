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
        public Form_ChiTietPhieuNhap()
        {
            InitializeComponent();
        }
        MyConnect db = new MyConnect();
        ClassDAL classDAL = new ClassDAL();
        private void dgv_ChiTietPhieuNhapKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_ChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            
            classDAL.loadData("select * from ChiTietPhieuNhap", dgv_ChiTietPhieuNhapKho);
        }

        private void btn_Them_CTPNK_Click(object sender, EventArgs e)
        {
            string maLT = txt_MaLT.Text;
            string maNK = txt_MaNK.Text;
            int soLuongSP;
            int giaNhapTungSP;
            int thueVAT;
            int thanhTienTungSP;

            // Kiểm tra dữ liệu đầu vào hợp lệ
            if (string.IsNullOrWhiteSpace(maLT) || string.IsNullOrWhiteSpace(maNK) ||
                !int.TryParse(txt_SLSP.Text, out soLuongSP) ||
                !int.TryParse(txt_GiaNhapTungSP.Text, out giaNhapTungSP) ||
                !int.TryParse(txt_ThueVAT.Text, out thueVAT) ||
                !int.TryParse(txt_ThanhTienTungSP.Text, out thanhTienTungSP))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi hàm thêm chi tiết phiếu nhập
            AddChiTietPhieuNhap(maLT, maNK, soLuongSP, giaNhapTungSP, thueVAT, thanhTienTungSP);
        }
       

        public bool AddChiTietPhieuNhap(string maLT, string maNK, int soLuongSP, int giaNhapTungSP, int thueVAT, int thanhTienTungSP)
        {
            try
            {
                db.openConnectionAdmin();
                SqlCommand cmd = new SqlCommand("EXEC pro_ThemChiTietPhieuNhap @MaLT, @MaNK, @SoLuongSP, @GiaNhapTungSP, @ThueVAT, @ThanhTienTungSP", db.getConnectionAdmin);
                
                // Thêm các tham số cho stored procedure
                cmd.Parameters.Add("@MaLT", SqlDbType.VarChar, 50).Value = maLT;
                cmd.Parameters.Add("@MaNK", SqlDbType.VarChar, 50).Value = maNK;
                cmd.Parameters.Add("@SoLuongSP", SqlDbType.Int).Value = soLuongSP;
                cmd.Parameters.Add("@GiaNhapTungSP", SqlDbType.Int).Value = giaNhapTungSP;
                cmd.Parameters.Add("@ThueVAT", SqlDbType.Int).Value = thueVAT;
                cmd.Parameters.Add("@ThanhTienTungSP", SqlDbType.Int).Value = thanhTienTungSP;

                // Mở kết nối
               

                // Thực thi stored procedure
                cmd.ExecuteNonQuery();

                // Đóng kết nối
          
                classDAL.loadData("select * from ChiTietPhieuNhap", dgv_ChiTietPhieuNhapKho);
                MessageBox.Show("Thêm chi tiết phiếu nhập thành công", "Thành công", MessageBoxButtons.OK);
                tabControl1.SelectedTab = this.tabPage1;

                return true;
            }
            catch (SqlException ex) // Bắt lỗi SQL
            {
                MessageBox.Show("Lỗi khi thêm chi tiết phiếu nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.closeConnectionAdmin();
                return false;
            }
            catch (Exception ex) // Bắt lỗi khác
            {
                MessageBox.Show("Lỗi khi thêm chi tiết phiếu nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.closeConnectionAdmin();
                return false;
            }
        }
    }
}
