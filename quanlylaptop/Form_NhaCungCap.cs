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
    public partial class Form_NhaCungCap : Form
    {
        public Form_NhaCungCap()
        {
            InitializeComponent();
        }
        MyConnect myconn = new MyConnect();
        ClassDAL classDAL = new ClassDAL();
        private void Form_NhaCungCap_Load(object sender, EventArgs e)
        {
            ClassDAL classDAL = new ClassDAL();
            classDAL.loadData("select * from v_infNhaCungCap", dgv_NhaCungCap);
        }

        private void dgv_NhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Them_NCC_Click(object sender, EventArgs e)
        {
            string MaNCC = txt_MaNCC.Text.Trim(); // Mã nhà cung cấp
            string TenNCC = txt_TenNCC.Text.Trim(); // Tên nhà cung cấp
            string Email = txt_Email.Text.Trim(); // Email nhà cung cấp
            string DiaChi = txt_DiaChi.Text.Trim(); // Địa chỉ nhà cung cấp
            string SDT = txt_SDT.Text.Trim(); // Số điện thoại nhà cung cấp
            string TrangThaiHopTac = txt_TrangThaiHopTac.Text.Trim(); // Trạng thái hợp tác

            try
            {
                myconn.openConnectionAdmin();
                SqlCommand cmd = new SqlCommand("ThemNhaCungCap", myconn.getConnectionAdmin);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào thủ tục
                cmd.Parameters.Add("@MaNCC", SqlDbType.NVarChar).Value = MaNCC;
                cmd.Parameters.Add("@TenNCC", SqlDbType.NVarChar).Value = TenNCC;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;
                cmd.Parameters.Add("@DiaChi", SqlDbType.VarChar).Value = DiaChi;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = SDT;
                cmd.Parameters.Add("@TrangThaiHopTac", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(TrangThaiHopTac) ? (object)DBNull.Value : TrangThaiHopTac;

                // Thực thi thủ tục
                cmd.ExecuteNonQuery();

                // Nếu không xảy ra lỗi, thông báo thành công
                MessageBox.Show("Thêm nhà cung cấp thành công!", "Add Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form_NhaCungCap_Load(sender, e); // Gọi lại phương thức load nếu cần để cập nhật dữ liệu
                tabControl1.SelectedIndex = 0; // Chuyển về tab đầu tiên nếu cần
            }
            catch (SqlException ex) // Bắt lỗi SqlException
            {
                // Hiển thị thông báo lỗi từ trigger
                MessageBox.Show($"Thêm nhà cung cấp thất bại: {ex.Message}", "Add Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myconn.closeConnectionAdmin(); // Đảm bảo kết nối được đóng trong mọi trường hợp
            }
        }
    }
}
