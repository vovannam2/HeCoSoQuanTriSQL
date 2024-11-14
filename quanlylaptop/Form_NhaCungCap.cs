using quanlylaptop.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace quanlylaptop
{
    public partial class Form_NhaCungCap : Form
    {
        public Form_NhaCungCap()
        {
            InitializeComponent();
        }
        MyConnect myconn = new MyConnect(Properties.Settings.Default.IsAdmin);
        ClassDAL classDAL = new ClassDAL();
        private void Form_NhaCungCap_Load(object sender, EventArgs e)
        {
            
            classDAL.loadData("select * from v_infNhaCungCap", dgv_NhaCungCap);
            //foreach (DataGridViewColumn column in this.dgv_NhaCungCap.Columns)
            //{
            //    Console.WriteLine(column.Name);
            //}
        }

        private void dgv_NhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_NhaCungCap.Rows[e.RowIndex];

                // Gán giá trị vào các TextBox tương ứng, thực hiện chuyển đổi kiểu dữ liệu khi cần
                this.txt_MaNCC.Text = row.Cells["MaNCC"].Value.ToString();
                this.txt_TenNCC.Text = row.Cells["TenNCC"].Value.ToString();
                this.txt_Email.Text = row.Cells["Email"].Value.ToString();
                this.txt_DiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                this.txt_SDT.Text = row.Cells["SDT"].Value.ToString();
                this.txt_TrangThaiHopTac.Text = row.Cells["TrangThaiHopTac"].Value.ToString();

                // Chuyển sang tab Options
                this.btn_Them_NCC.Visible = false; // Ẩn nút "Thêm"
             
                this.tabControl1.SelectedTab = this.tabPage2;
            }
        }

        private void btn_Them_NCC_Click(object sender, EventArgs e)
        {
            string MaNCC = txt_MaNCC.Text.Trim(); // Mã nhà cung cấp
            string TenNCC = txt_TenNCC.Text.Trim(); // Tên nhà cung cấp
            string Email = txt_Email.Text.Trim(); // Email nhà cung cấp
            string DiaChi = txt_DiaChi.Text.Trim(); // Địa chỉ nhà cung cấp
            string SDT = txt_SDT.Text.Trim(); // Số điện thoại nhà cung cấp
            string TrangThaiHopTac = txt_TrangThaiHopTac.Text.Trim(); // Trạng thái hợp tác
            SqlConnection con = myconn.getConnection;
            try
            {
                //SqlConnection con = myconn.getConnection;
                myconn.openConnection(con);
                SqlCommand cmd = new SqlCommand("ThemNhaCungCap", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào thủ tục
                cmd.Parameters.Add("@MaNCC", SqlDbType.NVarChar).Value = MaNCC;
                cmd.Parameters.Add("@TenNCC", SqlDbType.NVarChar).Value = TenNCC;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;
                cmd.Parameters.Add("@DiaChi", SqlDbType.VarChar).Value = DiaChi;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = SDT;
                cmd.Parameters.Add("@TrangThaiHopTac", SqlDbType.NVarChar).Value = TrangThaiHopTac;

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
                MessageBox.Show($"Thêm thất bại: {ex.Message}", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myconn.closeConnection(con); // Đảm bảo kết nối được đóng trong mọi trường hợp
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.txt_MaNCC.Text = string.Empty;
            this.txt_TenNCC.Text = string.Empty;
            this.txt_Email.Text = string.Empty;
            this.txt_DiaChi.Text = string.Empty;
            this.txt_SDT.Text = string.Empty;
            this.txt_TrangThaiHopTac.Text = string.Empty;
            this.tabControl1.SelectedTab = this.tabPage1;
            this.label19.Text = "TÙY CHỈNH THÔNG TIN NHÀ CUNG CẤP";
            this.btn_Sua_NCC.Visible = true; // Ẩn nút "Thêm"
            this.btn_Xoa_NCC.Visible = true; // Ẩn nút "Thêm"
            this.btn_Them_NCC.Visible = true; // Ẩn nút "Thêm"
        }

        private void btn_Add_NhaCungCap_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage2;
            this.label19.Text = "THÊM NHÀ CUNG CẤP";
            this.btn_Sua_NCC.Visible = false; // Ẩn nút "Thêm"
            this.btn_Xoa_NCC.Visible = false; // Ẩn nút "Thêm"
        }

        private void btn_Xoa_NCC_Click(object sender, EventArgs e)
        {
            SqlConnection con = myconn.getConnection;
            myconn.openConnection(con);
            string MaNCC = txt_MaNCC.Text.Trim();
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa laptop này không?", "Remove laptop", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {

                    SqlCommand cmd = new SqlCommand("XoaNhaCungCap", myconn.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaNCC", SqlDbType.NChar, 10).Value = MaNCC;

                    cmd.ExecuteNonQuery();
                   
                    MessageBox.Show("Xóa thành công!", "Remove Nhà cung cấp", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                        

                    Form_NhaCungCap_Load(sender, e);
                    tabControl1.SelectedTab = this.tabPage1;
                    
                }
            }
            catch (SqlException ex) // Bắt lỗi SqlException
            {
                // Hiển thị thông báo lỗi từ trigger
                MessageBox.Show($"xóa thất bại: {ex.Message}", "delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myconn.closeConnection(con); // Đảm bảo kết nối được đóng trong mọi trường hợp
            }
        }

        private void btn_Sua_NCC_Click(object sender, EventArgs e)
        {
            SqlConnection con = myconn.getConnection;
            myconn.openConnection(con);

            string MaNCC = txt_MaNCC.Text.Trim(); // Mã nhà cung cấp
            string TenNCC = txt_TenNCC.Text.Trim(); // Tên nhà cung cấp
            string Email = txt_Email.Text.Trim(); // Email nhà cung cấp
            string DiaChi = txt_DiaChi.Text.Trim(); // Địa chỉ nhà cung cấp
            string SDT = txt_SDT.Text.Trim(); // Số điện thoại nhà cung cấp
            string TrangThaiHopTac = txt_TrangThaiHopTac.Text.Trim(); // Trạng thái hợp tác
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin?", "Edit Nhà cung cấp", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {

                    SqlCommand cmd = new SqlCommand("CapNhatNhaCungCap", myconn.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaNCC", SqlDbType.NVarChar).Value = MaNCC;
                    cmd.Parameters.Add("@TenNCC", SqlDbType.NVarChar).Value = TenNCC;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;
                    cmd.Parameters.Add("@DiaChi", SqlDbType.VarChar).Value = DiaChi;
                    cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = SDT;
                    cmd.Parameters.Add("@TrangThaiHopTac", SqlDbType.NVarChar).Value = TrangThaiHopTac;


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sửa thành công!", "Edit Nhà cung cấp", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);



                    Form_NhaCungCap_Load(sender, e);
                    tabControl1.SelectedTab = this.tabPage1;

                }
            }
            catch (SqlException ex) // Bắt lỗi SqlException
            {
                // Hiển thị thông báo lỗi từ trigger
                MessageBox.Show($"Sửa thất bại: {ex.Message}", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myconn.closeConnection(con); // Đảm bảo kết nối được đóng trong mọi trường hợp
            }
        }

        private void txt_searchNCC_TextChanged(object sender, EventArgs e)
        {
            string tenncc = txt_searchNCC.Text.Trim();

            if (!string.IsNullOrEmpty(tenncc))
            {
                string query = $"SELECT * FROM SearchNCCByTenNCC('{tenncc}')";
                ClassDAL classDAL = new ClassDAL();
                classDAL.loadData(query, dgv_NhaCungCap);
            }
            else
            {
                Form_NhaCungCap_Load(sender, e);
            }
        }
    }
}
