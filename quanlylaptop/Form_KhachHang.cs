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
    public partial class Form_KhachHang : Form
    {
        public Form_KhachHang()
        {
            InitializeComponent();
        }
        MyConnect myconn = new MyConnect();

        private void Form_KhachHang_Load(object sender, EventArgs e)
        {
            ClassDAL classDAL = new ClassDAL();
            classDAL.loadData("select * from KhachHang", dgv_KhachHang);
        }

        private void dgv_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào hàng hợp lệ không
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_KhachHang.Rows[e.RowIndex];

                // Gán giá trị vào các TextBox tương ứng, thực hiện chuyển đổi kiểu dữ liệu khi cần
                this.txt_MaKH.Text = row.Cells["MaKH"].Value.ToString();
                this.txt_LoaiKH.Text = row.Cells["LoaiKH"].Value.ToString();
                this.txt_HoTenKH.Text = row.Cells["HoTenKH"].Value.ToString();
                this.txt_SoCCCD.Text = row.Cells["SOCCCD"].Value.ToString();
                this.txt_SDT.Text = row.Cells["HoTenKH"].Value.ToString();


                // Chuyển đổi kiểu dữ liệu cho các trường cần thiết
                this.txt_TongSoTienDaGiaoDich.Text = Convert.ToInt32(row.Cells["TongSoTienDaGD"].Value).ToString();

                
                // Chuyển sang tab Options
                this.tabControl1.SelectedTab = this.tabPage2;
            }
        }

        private void btn_TimKiem_KhachHang_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_TimKiemKH_SDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sdt = txt_TimKiemKH_SDT.Text.Trim();

                if (!string.IsNullOrEmpty(sdt))
                {
                    string query = $"SELECT * FROM SearchKHBySDT('{sdt}')";
                    ClassDAL classDAL = new ClassDAL();
                    classDAL.loadData(query, dgv_KhachHang);
                }
                else
                {
                    Form_KhachHang_Load(sender, e);
                }
            }
        }

        private void txt_TimKiemKH_CCCD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string CCCD = txt_TimKiemKH_CCCD.Text.Trim();

                if (!string.IsNullOrEmpty(CCCD))
                {
                    string query = $"SELECT * FROM SearchKHBySOCCCD('{CCCD}')";
                    ClassDAL classDAL = new ClassDAL();
                    classDAL.loadData(query, dgv_KhachHang);
                }
                else
                {
                    Form_KhachHang_Load(sender, e);
                }
            }
        }

        private void txt_TimKiemKH_HoTenKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tenKh = txt_TimKiemKH_HoTenKH.Text.Trim();

                if (!string.IsNullOrEmpty(tenKh))
                {
                    string query = $"SELECT * FROM SearchKHByTenKH('{tenKh}')";
                    ClassDAL classDAL = new ClassDAL();
                    classDAL.loadData(query, dgv_KhachHang);
                }
                else
                {
                    Form_KhachHang_Load(sender, e);
                }
            }
        }

        private void btn_Them_KhachHang_Click(object sender, EventArgs e)
        {
            string MaKH = txt_MaKH.Text.Trim(); // Thêm Trim để loại bỏ khoảng trắng
            string LoaiKH = txt_LoaiKH.Text.Trim();
            string TenKH = txt_HoTenKH.Text.Trim();
            string SDT = txt_SDT.Text.Trim();
            string CCCD = txt_SoCCCD.Text.Trim();

            try
            {
                myconn.openConnectionAdmin();
                SqlCommand cmd = new SqlCommand("InsertNewKhachHang", myconn.getConnectionAdmin);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào thủ tục
                cmd.Parameters.Add("@MaKH", SqlDbType.NChar).Value = MaKH;
                cmd.Parameters.Add("@LoaiKH", SqlDbType.NChar).Value = LoaiKH;
                cmd.Parameters.Add("@HoTenKH", SqlDbType.NChar).Value = TenKH;
                cmd.Parameters.Add("@SOCCCD", SqlDbType.NChar).Value = CCCD;
                cmd.Parameters.Add("@SDT", SqlDbType.NChar).Value = SDT;

                // Thực thi thủ tục
                cmd.ExecuteNonQuery();

                // Nếu không xảy ra lỗi, thông báo thành công
                MessageBox.Show("Thêm thành công!", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form_KhachHang_Load(sender, e);
                tabControl1.SelectedIndex = 0;
                
            }
            catch (SqlException ex) // Bắt lỗi SqlException
            {
                // Hiển thị thông báo lỗi từ trigger
                MessageBox.Show($"Thêm thất bại: {ex.Message}", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myconn.closeConnectionAdmin(); // Đảm bảo kết nối được đóng trong mọi trường hợp
            }
            

        }
    }
}
