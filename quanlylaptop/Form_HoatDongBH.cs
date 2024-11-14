using FontAwesome.Sharp;
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
    public partial class Form_HoatDongBH : Form
    {
        public Form_HoatDongBH()
        {
            InitializeComponent();
        }
        MyConnect db = new MyConnect(Properties.Settings.Default.IsAdmin);
        ClassDAL classDAL = new ClassDAL();
        private void dgv_HĐBH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                this.btn_Them_HDBH.Visible = false;
                DataGridViewRow row = this.dgv_HĐBH.Rows[e.RowIndex];
                this.txt_MaGBH.Text = row.Cells[0].Value?.ToString();
                this.txt_MaKH.Text = row.Cells[1].Value?.ToString();
                this.txt_ChiPhiSuaChua.Text = row.Cells[2].Value?.ToString();
                this.txt_ThoiGianBaoHanh.Text = row.Cells[4].Value?.ToString();
                this.dtp_NgayBatDau.Value = Convert.ToDateTime(row.Cells[3].Value);
                tabControl1.SelectedTab = this.tabPage2;
            }
        }
        public bool AddHoatDongBaoHanh(string maKH, string maGoiBH, int chiPhiSuaChua, int thoiGianBH, DateTime ngayBatDauBH)
        {
            SqlConnection con = db.getConnection;
            try
            {
                SqlCommand cmd = new SqlCommand("EXEC pro_KiemTraRangBuocTruocKhiThem @MaKH, @MaGoiBH, @ChiPhiSuaChua, @ThoiGianBH, @NgayBatDauBH", db.getConnectionAdmin);

                // Thêm tham số vào SqlCommand
                cmd.Parameters.Add("@MaKH", SqlDbType.VarChar, 50).Value = maKH;
                cmd.Parameters.Add("@MaGoiBH", SqlDbType.VarChar, 50).Value = maGoiBH;
                cmd.Parameters.Add("@ChiPhiSuaChua", SqlDbType.Int).Value = chiPhiSuaChua;
                cmd.Parameters.Add("@ThoiGianBH", SqlDbType.Int).Value = thoiGianBH;
                cmd.Parameters.Add("@NgayBatDauBH", SqlDbType.Date).Value = ngayBatDauBH;

                db.openConnection(con);
                cmd.ExecuteNonQuery();
                db.closeConnection(con);




                classDAL.loadData("select * from v_infBaoHanh", dgv_HĐBH);
                tabControl1.SelectedTab = this.tabPage1;
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.closeConnection(con);
                return false;
            }
        }

        private void Form_HoatDongBH_Load(object sender, EventArgs e)
        {
            dgv_HĐBH.Columns["NgayBatDauBH"].DefaultCellStyle.Format = "dd/MM/yyyy"; // Định dạng ngày
            classDAL.loadData("select * from v_infBaoHanh", dgv_HĐBH);
        }

        private void btn_Them_HDBH_Click(object sender, EventArgs e)
        {
            String maKH = this.txt_MaKH.Text;
            String maGoiBH = this.txt_MaGBH.Text;
            int chiPhiSuaChua;
            int thoiGianBH;
            DateTime selectedDate = dtp_NgayBatDau.Value;
            // Kiểm tra giá trị nhập vào
            if (string.IsNullOrWhiteSpace(maKH) || string.IsNullOrWhiteSpace(maGoiBH) ||
                !int.TryParse(this.txt_ChiPhiSuaChua.Text, out chiPhiSuaChua) ||
                !int.TryParse(this.txt_ThoiGianBaoHanh.Text, out thoiGianBH))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin hợp lệ.", "Lỗi", MessageBoxButtons.OK);
                return;
            }

            AddHoatDongBaoHanh(maKH, maGoiBH, chiPhiSuaChua, thoiGianBH, selectedDate);
        }

        private void btn_Add_HoatDongBaoHanh_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage2;
            this.label19.Text = "THÊM BẢO HÀNH";
            this.btn_Sua_HDBH.Visible = false; // Ẩn nút "Thêm"
            this.btn_Xoa_HDBH.Visible = false; // Ẩn nút "Thêm"
            this.btn_Them_HDBH.Visible = true;
        }
        private void RemoveHoatDongBaoHanh(String maKH, String maGoiBH)
        {
            SqlConnection con = db.getConnection;
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hoạt động bảo hành này không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("EXEC pro_DeleteHoatDongBaoHanh @MaKH, @MaGoiBH", db.getConnection);
                    cmd.Parameters.Add("@MaKH", SqlDbType.VarChar, 50).Value = maKH;
                    cmd.Parameters.Add("@MaGoiBH", SqlDbType.VarChar, 50).Value = maGoiBH;

                    db.openConnection(con);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Xóa thành công!", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        classDAL.loadData("select * from v_infBaoHanh", dgv_HĐBH);
                        tabControl1.SelectedTab = this.tabPage1;
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    db.closeConnection(con);
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại, hoạt động này có thể đang được sử dụng!", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_HDBH_Click(object sender, EventArgs e)
        {
            String maKH = this.txt_MaKH.Text;
            String maGoiBH = this.txt_MaGBH.Text;
            RemoveHoatDongBaoHanh(maKH, maGoiBH);
        }
        public bool UpdateHoatDongBaoHanh(string maKH, string maGoiBH, int chiPhiSuaChua, int thoiGianBH)
        {
            SqlConnection con = db.getConnection;
            try
            {
                               
                db.openConnection(con);
                SqlCommand cmd = new SqlCommand("EXEC pro_UpdateHoatDongBaoHanh @MaKH, @MaGoiBH, @ChiPhiSuaChua, @ThoiGianBH", con);

                // Thêm tham số vào SqlCommand
                cmd.Parameters.Add("@MaKH", SqlDbType.VarChar, 50).Value = maKH;
                cmd.Parameters.Add("@MaGoiBH", SqlDbType.VarChar, 50).Value = maGoiBH;
                cmd.Parameters.Add("@ChiPhiSuaChua", SqlDbType.Int).Value = chiPhiSuaChua;
                cmd.Parameters.Add("@ThoiGianBH", SqlDbType.Int).Value = thoiGianBH;

                
                cmd.ExecuteNonQuery();
                

                MessageBox.Show("Đã cập nhật thành công", "Thành công", MessageBoxButtons.OK);
                classDAL.loadData("select * from v_infBaoHanh", dgv_HĐBH);
                tabControl1.SelectedTab = this.tabPage1;
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.closeConnection(con);
                return false;
            }
        }

        private void btn_Sua_HDBH_Click(object sender, EventArgs e)
        {
            String maKH = this.txt_MaKH.Text;
            String maGoiBH = this.txt_MaGBH.Text;
            int chiPhiSuaChua;
            int thoiGianBH;
            // Kiểm tra giá trị nhập vào
            if (string.IsNullOrWhiteSpace(maKH) || string.IsNullOrWhiteSpace(maGoiBH) ||
                !int.TryParse(this.txt_ChiPhiSuaChua.Text, out chiPhiSuaChua) ||
                !int.TryParse(this.txt_ThoiGianBaoHanh.Text, out thoiGianBH))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin hợp lệ.", "Lỗi", MessageBoxButtons.OK);
                return;
            }

            UpdateHoatDongBaoHanh(maKH, maGoiBH, chiPhiSuaChua, thoiGianBH);
        }

        private void btn_TimKiem_HoatDongBaoHanh_Click(object sender, EventArgs e)
        {
            string maKH = txt_search_MKH.Text.Trim();
            string maGoiBH = txt_search_MGBH.Text.Trim();
            SqlConnection con = db.getConnection;

            // Nếu cả hai textbox đều rỗng, tải lại toàn bộ dữ liệu
            if (string.IsNullOrEmpty(maKH) && string.IsNullOrEmpty(maGoiBH))
            {
                classDAL.loadData("select * from v_infBaoHanh", dgv_HĐBH);
            }
            else
            {
                // Tạo SqlCommand để gọi procedure tìm kiếm
                SqlCommand command = new SqlCommand("proc_SearchHoatDongBaoHanh", db.getConnection);
                command.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                command.Parameters.AddWithValue("@MaKH", string.IsNullOrEmpty(maKH) ? (object)DBNull.Value : maKH);
                command.Parameters.AddWithValue("@MaGoiBH", string.IsNullOrEmpty(maGoiBH) ? (object)DBNull.Value : maGoiBH);

                db.openConnection(con);

                DataTable table = new DataTable();

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(table);
                }

                // Hiển thị dữ liệu tìm kiếm lên DataGridView
                dgv_HĐBH.Rows.Clear();
                foreach (DataRow row in table.Rows)
                {
                    dgv_HĐBH.Rows.Add(row.ItemArray);
                }
                db.closeConnection(con);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.txt_MaGBH.Text = string.Empty;
            this.txt_MaKH.Text = string.Empty;
            this.txt_ChiPhiSuaChua.Text = string.Empty;
            this.txt_ThoiGianBaoHanh.Text = string.Empty;


            this.tabControl1.SelectedTab = this.tabPage1;
            this.label19.Text = "TÙY CHỈNH THÔNG TIN TRẢ GÓP";
            this.btn_Sua_HDBH.Visible = true;
            this.btn_Xoa_HDBH.Visible = true;
            this.btn_Them_HDBH.Visible = false;
        }
    }
}
