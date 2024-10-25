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
        MyConnect myconn = new MyConnect();
        ClassDAL classDAL = new ClassDAL();
        private void Form_HoaDon_Load(object sender, EventArgs e)
        {
           
            classDAL.loadData("select * from v1_infThongTinHoaDon", dgv_HoaDon);
            foreach (DataGridViewColumn column in this.dgv_HoaDon.Columns)
            {
                Console.WriteLine(column.Name);
            }
        }

        private void dgv_HoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào hàng hợp lệ không
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_HoaDon.Rows[e.RowIndex];

                // Gán giá trị vào các TextBox tương ứng, thực hiện chuyển đổi kiểu dữ liệu khi cần
                this.txt_MaHD.Text = row.Cells["MaHD"].Value.ToString();
                this.txt_MaKH.Text = row.Cells["MaKH"].Value.ToString();

                this.txt_PTTT.Text = row.Cells["PTTT"].Value.ToString();

                // Gán giá trị cho DateTimePicker
                DateTime ngayMuaHang = Convert.ToDateTime(row.Cells["NgayMuaHang"].Value);
                this.dtp_dateNgayMH.Value = ngayMuaHang; // Gán giá trị vào DateTimePicker


                // Chuyển đổi kiểu dữ liệu cho các trường cần thiết
                this.txt_SoTienDaThanhToan.Text = Convert.ToInt32(row.Cells["SoTienThanhToan"].Value).ToString();


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

            try
            {
                myconn.openConnectionAdmin();
                SqlCommand cmd = new SqlCommand("proc_AddHoaDon", myconn.getConnectionAdmin);
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
                myconn.closeConnectionAdmin(); // Đảm bảo kết nối được đóng trong mọi trường hợp
            }
        }

        private void btn_TimKiem_HoaDon_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ DateTimePicker
            DateTime ngayBatDau = dtp_ngaybd.Value;
            DateTime ngayKetThuc = dtp_ngaykt.Value;

            // Tạo DataTable để lưu trữ kết quả
            DataTable table = new DataTable();

            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                myconn.openConnectionAdmin();

                // Tạo SqlCommand với thủ tục lưu trữ
                SqlCommand command = new SqlCommand("procedure_TimKiemHoaDon", myconn.getConnectionAdmin);
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
                myconn.closeConnectionAdmin();
            }
        }
    }

}
