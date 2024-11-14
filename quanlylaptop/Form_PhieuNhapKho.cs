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
    public partial class Form_PhieuNhapKho : Form
    {
        public Form_PhieuNhapKho()
        {
            InitializeComponent();
            
        }
        MyConnect myconn = new MyConnect(Properties.Settings.Default.IsAdmin);
        ClassDAL classDAL = new ClassDAL();
        private void Form_PhieuNhapKho_Load(object sender, EventArgs e)
        {
            dgv_PhieuNhapKho.Columns["NgayNhapKho"].DefaultCellStyle.Format = "dd/MM/yyyy"; // Định dạng ngày
            ClassDAL classDAL = new ClassDAL();
            classDAL.loadData("select * from v_infThongTinNhapKho", dgv_PhieuNhapKho);
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "hoạt động ",
                Text = "Thêm laptop",
                UseColumnTextForButtonValue = true, // This allows you to have the same text for all buttons
            
                Name = "ButtonColumn"
            };
            
            if (!dgv_PhieuNhapKho.Columns.Contains("ButtonColumn")) // Kiểm tra xem cột đã tồn tại chưa
            {
                dgv_PhieuNhapKho.Columns.Add(buttonColumn); // Thêm cột vào DataGridView
            }
            

        }

        private void dgv_PhieuNhapKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào cột "Action" hay không
            if (e.RowIndex >= 0 && dgv_PhieuNhapKho.Columns[e.ColumnIndex].Name == "ButtonColumn")
            {
                // Lấy thông tin của dòng hiện tại
                int rowIndex = e.RowIndex;
                DataGridViewRow selectedRow = dgv_PhieuNhapKho.Rows[rowIndex];

                // Giả sử bạn có các cột chứa thông tin cần thiết như "MaNK" trong DataGridView
                string maNK = selectedRow.Cells["MaNK"].Value.ToString();

                // Thực hiện các thao tác khi nhấn nút, chẳng hạn như mở form chọn laptop
                optLaptop formThemLaptop = new optLaptop(maNK,true); // Truyền mã phiếu nhập kho nếu cần
                formThemLaptop.ShowDialog();

                // Sau khi thêm xong, bạn có thể gọi lại load dữ liệu
                Form_PhieuNhapKho_Load(sender, e);
            }
            if (e.RowIndex >= 0 && dgv_PhieuNhapKho.Columns[e.ColumnIndex].Name == "MaNK")
            {
                // Lấy thông tin của dòng hiện tại
                int rowIndex = e.RowIndex;
                DataGridViewRow selectedRow = dgv_PhieuNhapKho.Rows[rowIndex];

                // Giả sử bạn có các cột chứa thông tin cần thiết như "MaNK" trong DataGridView
                string maNK = selectedRow.Cells["MaNK"].Value.ToString();

                // Thực hiện các thao tác khi nhấn nút, chẳng hạn như mở form chọn laptop
                Form_ChiTietPhieuNhap form = new Form_ChiTietPhieuNhap(maNK); // Truyền mã phiếu nhập kho nếu cần
                form.ShowDialog();

                // Sau khi thêm xong, bạn có thể gọi lại load dữ liệu
                Form_PhieuNhapKho_Load(sender, e);
            }
            if (e.RowIndex >= 0 && dgv_PhieuNhapKho.Columns[e.ColumnIndex].Name == "MaNCC")
            {
                // Lấy hàng hiện tại
                DataGridViewRow row = this.dgv_PhieuNhapKho.Rows[e.RowIndex];

                // Gán giá trị vào các Guna2TextBox và Guna2DateTimePicker tương ứng
                this.txt_PTTT.Text = row.Cells["PTTT"].Value.ToString();
                this.txt_ThanhTien.Text = row.Cells["ThanhTien"].Value.ToString();
                this.txt_MaNCC.Text = row.Cells["MaNCC"].Value.ToString();
                this.txt_MaNK.Text = row.Cells["MaNK"].Value.ToString();

                // Chuyển đổi giá trị ô thành kiểu DateTime và gán cho Guna2DateTimePicker
                this.dtp_ngaynhapkho.Value = Convert.ToDateTime(row.Cells["NgayNhapKho"].Value);

                // Ẩn nút "Thêm"
                this.btn_Them_PNK.Visible = false;

                // Chuyển sang tab Options
                this.tabControl1.SelectedTab = this.tabPage2;
            }

        }

        private void btn_Them_PNK_Click(object sender, EventArgs e)
        {
            // Thu thập dữ liệu từ các trường nhập liệu
            string MaNK = txt_MaNK.Text.Trim(); // Mã phiếu nhập kho
            string MaNCC = txt_MaNCC.Text.Trim(); // Mã nhà cung cấp
            DateTime NgayNhapKho = dtp_ngaynhapkho.Value; // Ngày nhập kho
            string PhuongThucThanhToan = txt_PTTT.Text.Trim(); // Phương thức thanh toán
            SqlConnection con = myconn.getConnection;
            
            try
            {
                // Mở kết nối đến cơ sở dữ liệu
               
                myconn.openConnection(con);

                // Thiết lập SqlCommand để gọi thủ tục ThemPhieuNhapKho
                SqlCommand cmd = new SqlCommand("ThemPhieuNhapKho", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số vào thủ tục
                cmd.Parameters.Add("@MaNK", SqlDbType.NVarChar).Value = MaNK;
                cmd.Parameters.Add("@MaNCC", SqlDbType.NVarChar).Value = MaNCC;
                cmd.Parameters.Add("@NgayNhapKho", SqlDbType.Date).Value = NgayNhapKho;
                cmd.Parameters.Add("@PhuongThucThanhToan", SqlDbType.NVarChar).Value = PhuongThucThanhToan;
               

                // Thực thi thủ tục
                cmd.ExecuteNonQuery();

                // Nếu thành công, thông báo cho người dùng
                MessageBox.Show("Thêm phiếu nhập kho thành công!", "Add Import Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật lại form hoặc các thành phần cần thiết
                Form_PhieuNhapKho_Load(sender, e);

                // Chuyển về tab hiển thị danh sách phiếu nhập kho nếu cần
                tabControl1.SelectedIndex = 0;
            }
            catch (SqlException ex) // Bắt lỗi SqlException
            {
                // Hiển thị thông báo lỗi từ trigger hoặc lỗi SQL
                MessageBox.Show($"Thêm thất bại: {ex.Message}", "Add Import Receipt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đảm bảo kết nối được đóng trong mọi trường hợp
                myconn.closeConnection(con);
            }
        }

        private void btn_Add_PNK_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage2;
            this.label19.Text = "THÊM PHIẾU NHẬP KHO";
            this.btn_Sua_PNK.Visible = false; // Ẩn nút "Thêm"
            this.btn_Xoa_PNK.Visible = false; // Ẩn nút "Thêm"
            this.btn_Them_PNK.Visible = true;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.txt_MaNCC.Text = string.Empty;
            this.txt_MaNK.Text = string.Empty;
            this.txt_PTTT.Text = string.Empty;
            this.txt_ThanhTien.Text = string.Empty;
            this.dtp_ngaynhapkho.Text = string.Empty;
            
            this.tabControl1.SelectedTab = this.tabPage1;
            this.label19.Text = "TÙY CHỈNH THÔNG TIN PHIẾU NHẬP KHO";
            this.btn_Sua_PNK.Visible = true; 
            this.btn_Xoa_PNK.Visible = true; 
            this.btn_Them_PNK.Visible = false; 
        }

        private void btn_Xoa_PNK_Click(object sender, EventArgs e)
        {
            ClassDAL dal = new ClassDAL();
            string maNK = txt_MaNK.Text.Trim();
            dal.ThucThi("EXEC XoaPhieuNhapKho @MaNK = " + maNK + "");
            Form_PhieuNhapKho_Load(sender, e);
            tabControl1.SelectedIndex = 0;
        }

        private void btn_Sua_PNK_Click(object sender, EventArgs e)
        {
            string MaNK = txt_MaNK.Text.Trim(); // Mã phiếu nhập kho
            string MaNCC = txt_MaNCC.Text.Trim(); // Mã nhà cung cấp
            DateTime NgayNhapKho = dtp_ngaynhapkho.Value; // Ngày nhập kho
            string PhuongThucThanhToan = txt_PTTT.Text.Trim(); // Phương thức thanh toán
            SqlConnection con = myconn.getConnection;

            try
            {
                // Mở kết nối đến cơ sở dữ liệu

                myconn.openConnection(con);

                // Thiết lập SqlCommand để gọi thủ tục ThemPhieuNhapKho
                SqlCommand cmd = new SqlCommand("SuaPhieuNhapKho", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số vào thủ tục
                cmd.Parameters.Add("@MaNK", SqlDbType.NVarChar).Value = MaNK;
                cmd.Parameters.Add("@MaNCC", SqlDbType.NVarChar).Value = MaNCC;
                cmd.Parameters.Add("@NgayNhapKho", SqlDbType.Date).Value = NgayNhapKho;
                cmd.Parameters.Add("@PhuongThucThanhToan", SqlDbType.NVarChar).Value = PhuongThucThanhToan;


                // Thực thi thủ tục
                cmd.ExecuteNonQuery();

                // Nếu thành công, thông báo cho người dùng
                MessageBox.Show("Cập nhật phiếu nhập kho thành công!", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật lại form hoặc các thành phần cần thiết
                Form_PhieuNhapKho_Load(sender, e);

                // Chuyển về tab hiển thị danh sách phiếu nhập kho nếu cần
                tabControl1.SelectedIndex = 0;
            }
            catch (SqlException ex) // Bắt lỗi SqlException
            {
                // Hiển thị thông báo lỗi từ trigger hoặc lỗi SQL
                MessageBox.Show($"Cập nhật thất bại: {ex.Message}", "Action", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đảm bảo kết nối được đóng trong mọi trường hợp
                myconn.closeConnection(con);
            }
        }
    }
}
