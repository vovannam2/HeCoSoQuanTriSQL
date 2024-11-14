using quanlylaptop.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace quanlylaptop
{
    public partial class Form_HoaDon : Form
    {
        public Form_HoaDon()
        {
            InitializeComponent();
        }
        MyConnect myconn = new MyConnect(Properties.Settings.Default.IsAdmin);
        ClassDAL classDAL = new ClassDAL();
        private void Form_HoaDon_Load(object sender, EventArgs e)
        {
            dgv_HoaDon.Columns["NgayMuaHang"].DefaultCellStyle.Format = "dd/MM/yyyy"; // Định dạng ngày
            classDAL.loadData("select * from v1_infThongTinHoaDon", dgv_HoaDon);
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "hoạt động ",
                Text = "Thêm laptop",
                UseColumnTextForButtonValue = true, // This allows you to have the same text for all buttons

                Name = "ButtonColumn"
            };

            if (!dgv_HoaDon.Columns.Contains("ButtonColumn")) // Kiểm tra xem cột đã tồn tại chưa
            {
                dgv_HoaDon.Columns.Add(buttonColumn); // Thêm cột vào DataGridView
            }
        }

        private void dgv_HoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào hàng hợp lệ không
            // Kiểm tra xem người dùng có click vào cột "Action" hay không
            if (e.RowIndex >= 0 && dgv_HoaDon.Columns[e.ColumnIndex].Name == "ButtonColumn")
            {
                // Lấy thông tin của dòng hiện tại
                int rowIndex = e.RowIndex;
                DataGridViewRow selectedRow = dgv_HoaDon.Rows[rowIndex];

                // Giả sử bạn có các cột chứa thông tin cần thiết như "MaNK" trong DataGridView
                string maHD = selectedRow.Cells["MaHD"].Value.ToString();

                // Thực hiện các thao tác khi nhấn nút, chẳng hạn như mở form chọn laptop
                optLaptop formThemLaptop = new optLaptop(maHD,false); // Truyền mã phiếu nhập kho nếu cần
                formThemLaptop.ShowDialog();

                // Sau khi thêm xong, bạn có thể gọi lại load dữ liệu
                Form_HoaDon_Load(sender, e);
            }

            if (e.RowIndex >= 0 && dgv_HoaDon.Columns[e.ColumnIndex].Name == "MaHD")
            {
                // Lấy thông tin của dòng hiện tại
                int rowIndex = e.RowIndex;
                DataGridViewRow selectedRow = dgv_HoaDon.Rows[rowIndex];

                // Giả sử bạn có các cột chứa thông tin cần thiết như "MaNK" trong DataGridView
                string maHD = selectedRow.Cells["MaHD"].Value.ToString();

                // Thực hiện các thao tác khi nhấn nút, chẳng hạn như mở form chọn laptop
                Form_ChiTietHoaDon form = new Form_ChiTietHoaDon(maHD); // Truyền mã phiếu nhập kho nếu cần
                form.ShowDialog();

                // Sau khi thêm xong, bạn có thể gọi lại load dữ liệu
                Form_HoaDon_Load(sender, e);
            }

            if (e.RowIndex >= 0 && dgv_HoaDon.Columns[e.ColumnIndex].Name == "MaKH")
            {
                // Lấy hàng hiện tại
                DataGridViewRow row = this.dgv_HoaDon.Rows[e.RowIndex];

                // Gán giá trị vào các Guna2TextBox và Guna2DateTimePicker tương ứng
                this.txt_PTTT.Text = row.Cells["PTTT"].Value.ToString();
                this.txt_SoTienDaThanhToan.Text = row.Cells["SoTienThanhToan"].Value.ToString();
                this.txt_MaHD.Text = row.Cells["MaHD"].Value.ToString();
                this.txt_MaKH.Text = row.Cells["MaKH"].Value.ToString();

                // Chuyển đổi giá trị ô thành kiểu DateTime và gán cho Guna2DateTimePicker
                this.dtp_dateNgayMH.Value = Convert.ToDateTime(row.Cells["NgayMuaHang"].Value);

                // Ẩn nút "Thêm"
                this.btn_Them_HoaDon.Visible = false;

                // Chuyển sang tab Options
                this.tabControl1.SelectedTab = this.tabPage2;
            }

        }

        private void btn_Them_HoaDon_Click(object sender, EventArgs e)
        {
            string MaHD = txt_MaHD.Text.Trim(); // Mã hóa đơn
            string MaKH = txt_MaKH.Text.Trim(); // Mã khách hàng
            DateTime NgayMuaHang = dtp_dateNgayMH.Value; // Ngày mua hàng từ DateTimePicker
            string PhuongThucThanhToan = txt_PTTT.Text.Trim(); // Phương thức thanh toán
            SqlConnection con = myconn.getConnection;
            try
            {
                myconn.openConnection(con);
                SqlCommand cmd = new SqlCommand("proc_AddHoaDon",con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào thủ tục
                cmd.Parameters.Add("@MaHD", SqlDbType.NChar).Value = MaHD;
                cmd.Parameters.Add("@MaKH", SqlDbType.NChar).Value = MaKH;
                cmd.Parameters.Add("@NgayMuaHang", SqlDbType.Date).Value = NgayMuaHang;
                cmd.Parameters.Add("@PhuongThucThanhToan", SqlDbType.NVarChar).Value = PhuongThucThanhToan;

                // Thực thi thủ tục
                cmd.ExecuteNonQuery();

                // Nếu không xảy ra lỗi, thông báo thành công
                MessageBox.Show("Thêm hóa đơn thành công!", "Add Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form_HoaDon_Load(sender, e); // Gọi lại phương thức load nếu cần để cập nhật dữ liệu
                tabControl1.SelectedIndex = 0; // Chuyển về tab đầu tiên nếu cần

            }
            catch (SqlException ex) // Bắt lỗi SqlException
            {
                // Hiển thị thông báo lỗi từ trigger
                MessageBox.Show($"Thêm hóa đơn thất bại: {ex.Message}", "Add Invoice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myconn.closeConnection(con); // Đảm bảo kết nối được đóng trong mọi trường hợp
            }
        }

        private void btn_TimKiem_HoaDon_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ DateTimePicker
            DateTime ngayBatDau = dtp_ngaybd.Value;
            DateTime ngayKetThuc = dtp_ngaykt.Value;

            // Tạo DataTable để lưu trữ kết quả
            DataTable table = new DataTable();
            SqlConnection con = myconn.getConnection;
            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                myconn.openConnection(con);

                // Tạo SqlCommand với thủ tục lưu trữ
                SqlCommand command = new SqlCommand("procedure_TimKiemHoaDon", con);
                command.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                command.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                command.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);

                // Sử dụng SqlDataAdapter để điền dữ liệu vào DataTable
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(table);
                }

                // Đặt DataTable làm nguồn dữ liệu cho DataGridView
              
                
                
                dgv_HoaDon.Rows.Clear();
                foreach (DataRow row in table.Rows)
                {
                    dgv_HoaDon.Rows.Add(row.ItemArray);
                }
                // Kiểm tra nếu không có dữ liệu nào
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn nào trong khoảng thời gian này.", "Tìm kiếm hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                }
            }
            catch (SqlException ex) // Bắt lỗi SqlException
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show($"Tìm kiếm hóa đơn thất bại: {ex.Message}", "Tìm kiếm hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đảm bảo đóng kết nối trong mọi trường hợp
                myconn.closeConnection(con);
                    ;
            }
        }

        private void btn_Add_HoaDon_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage2;
            this.label19.Text = "THÊM HÓA ĐƠN";
            this.btn_Sua_HoaDon.Visible = false; // Ẩn nút "Thêm"
            this.btn_Xoa_HoaDon.Visible = false; // Ẩn nút "Thêm"
            this.btn_Them_HoaDon.Visible = true;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.txt_MaHD.Text = string.Empty;
            this.txt_MaKH.Text = string.Empty;
            this.txt_PTTT.Text = string.Empty;
            this.txt_SoTienDaThanhToan.Text = string.Empty;
            this.dtp_dateNgayMH.Text = string.Empty;

            this.tabControl1.SelectedTab = this.tabPage1;
            this.label19.Text = "TÙY CHỈNH THÔNG TIN HÓA ĐƠN";
            this.btn_Sua_HoaDon.Visible = true;
            this.btn_Xoa_HoaDon.Visible = true;
            this.btn_Them_HoaDon.Visible = false;
        }

        private void btn_Xoa_HoaDon_Click(object sender, EventArgs e)
        {
            ClassDAL dal = new ClassDAL();
            string maHD = txt_MaHD.Text.Trim();
            dal.ThucThi("EXEC proc_DeleteHoaDon @MaHD = " + maHD + "");
            Form_HoaDon_Load(sender, e);
            tabControl1.SelectedIndex = 0;
        }

        private void btn_Sua_HoaDon_Click(object sender, EventArgs e)
        {
            string MaHD = txt_MaHD.Text.Trim(); // Mã hóa đơn
            string MaKH = txt_MaKH.Text.Trim(); // Mã khách hàng
            DateTime NgayMuaHang = dtp_dateNgayMH.Value; // Ngày mua hàng từ DateTimePicker
            
            string PhuongThucThanhToan = txt_PTTT.Text.Trim(); // Phương thức thanh toán
            decimal SoTienThanhToan = decimal.TryParse(txt_SoTienDaThanhToan.Text.Trim(), out var result) ? result : 0;
            SqlConnection con = myconn.getConnection;
            try
            {
                myconn.openConnection(con);
                SqlCommand cmd = new SqlCommand("proc_UpdateHoaDon", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào thủ tục
                cmd.Parameters.Add("@MaHD", SqlDbType.NChar).Value = MaHD;
                cmd.Parameters.Add("@MaKH", SqlDbType.NChar).Value = MaKH;
                cmd.Parameters.Add("@NgayMuaHang", SqlDbType.Date).Value = NgayMuaHang;
                cmd.Parameters.Add("@PhuongThucThanhToan", SqlDbType.NVarChar).Value = PhuongThucThanhToan;
                cmd.Parameters.Add("@SoTienThanhToanHoaDon", SqlDbType.Decimal).Value = SoTienThanhToan;


                // Thực thi thủ tục
                cmd.ExecuteNonQuery();

                // Nếu không xảy ra lỗi, thông báo thành công
                MessageBox.Show("Cập nhật hóa đơn thành công!", "Update Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form_HoaDon_Load(sender, e); // Gọi lại phương thức load nếu cần để cập nhật dữ liệu
                tabControl1.SelectedIndex = 0; // Chuyển về tab đầu tiên nếu cần

            }
            catch (SqlException ex) // Bắt lỗi SqlException
            {
                // Hiển thị thông báo lỗi từ trigger
                MessageBox.Show($"cập nhật hóa đơn thất bại: {ex.Message}", "Update Invoice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myconn.closeConnection(con); // Đảm bảo kết nối được đóng trong mọi trường hợp
            }
        }
    }

}
