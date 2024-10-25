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
    public partial class Form_TraGop : Form
    {
        public Form_TraGop()
        {
            InitializeComponent();
        }
        MyConnect db = new MyConnect();
        ClassDAL classDAL = new ClassDAL();



        private void dgv_TraGop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_TraGop.Rows[e.RowIndex];
                this.txt_MaHD.Text = row.Cells[0].Value?.ToString();
                this.txt_LaiSuatHangThang.Text = row.Cells[2].Value?.ToString();
                this.txt_TienTraTruoc.Text = row.Cells[3].Value?.ToString();
                this.txt_TienConLai.Text = row.Cells[4].Value?.ToString();
                this.guna2DateTimePicker1.Value = Convert.ToDateTime(row.Cells[6].Value); // Ngày bắt đầu
                this.guna2DateTimePicker2.Value = Convert.ToDateTime(row.Cells[7].Value); // Ngày đáo hạn
                tabControl1.SelectedTab = this.tabPage2; // Chuyển tab
            }
        }

        private void Form_TraGop_Load(object sender, EventArgs e)
        {
            classDAL.loadData("select * from v2_infTraGop", dgv_TraGop);
        }

        public bool AddTraGop(string maHD, int laiSuatHangThang, int tienTraTruoc, int tienConLai, DateTime ngayBatDau, DateTime ngayDaoHan)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("EXEC pro_AddTraGop @MaHD, @LaiSuatHangThang, @TienTraTruoc, @TienConLai, @NgayBatDau, @NgayDaoHan", db.getConnectionAdmin);

                // Thêm tham số vào SqlCommand
                cmd.Parameters.Add("@MaHD", SqlDbType.VarChar, 50).Value = maHD;
                cmd.Parameters.Add("@LaiSuatHangThang", SqlDbType.Int).Value = laiSuatHangThang;
                cmd.Parameters.Add("@TienTraTruoc", SqlDbType.Int).Value = tienTraTruoc;
                cmd.Parameters.Add("@TienConLai", SqlDbType.Int).Value = tienConLai;
                cmd.Parameters.Add("@NgayBatDau", SqlDbType.Date).Value = ngayBatDau;
                cmd.Parameters.Add("@NgayDaoHan", SqlDbType.Date).Value = ngayDaoHan;

                db.openConnectionAdmin();
                cmd.ExecuteNonQuery();
                db.closeConnectionAdmin();

                MessageBox.Show("Đã thêm thành công", "Thành công", MessageBoxButtons.OK);
                classDAL.loadData("select * from v2_infTraGop ", dgv_TraGop);
                tabControl1.SelectedTab = this.tabPage1;
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.closeConnectionAdmin();
                return false;
            }
        }

        private void btn_Them_TraGop_Click(object sender, EventArgs e)
        {
            String maHD = this.txt_MaHD.Text; // Dùng MaHD thay cho MaGBH
            int laiSuatHangThang;
            int tienTraTruoc;
            int tienConLai;
            DateTime ngayBatDau = guna2DateTimePicker1.Value;
            DateTime ngayDaoHan = guna2DateTimePicker2.Value; // Bạn cần xác định `thoiGianBH`

            // Kiểm tra giá trị nhập vào
            if (string.IsNullOrWhiteSpace(maHD) ||
                !int.TryParse(this.txt_LaiSuatHangThang.Text, out laiSuatHangThang) ||
                !int.TryParse(this.txt_TienTraTruoc.Text, out tienTraTruoc) ||
                !int.TryParse(this.txt_TienConLai.Text, out tienConLai))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin hợp lệ.", "Lỗi", MessageBoxButtons.OK);
                return;
            }

            AddTraGop(maHD, laiSuatHangThang, tienTraTruoc, tienConLai, ngayBatDau, ngayDaoHan);
        }
        private void RemoveTraGop(string maHD)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hoạt động bảo hành này không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("EXEC pro_DeleteTraGop @MaHD", db.getConnectionAdmin);
                    cmd.Parameters.Add("@MaHD", SqlDbType.VarChar, 50).Value = maHD;

                    db.openConnectionAdmin();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Xóa thành công!", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        classDAL.loadData("select * from v2_infTraGop", dgv_TraGop);
                        tabControl1.SelectedTab = this.tabPage1;
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    db.closeConnectionAdmin();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại, hoạt động này có thể đang được sử dụng!", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_TraGop_Click(object sender, EventArgs e)
        {
            String maHD = this.txt_MaHD.Text; // Dùng MaHD thay cho MaGBH
            RemoveTraGop(maHD);
        }
        public bool UpdateTraGop(string maHD, int laiSuatHangThang, int tienTraTruoc, int tienConLai, DateTime ngayBatDau, DateTime ngayDaoHan)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("EXEC pro_UpdateTraGop @MaHD, @LaiSuatHangThang, @TienTraTruoc, @TienConLai, @NgayBatDau, @NgayDaoHan", db.getConnectionAdmin);

                // Thêm tham số vào SqlCommand
                cmd.Parameters.Add("@MaHD", SqlDbType.VarChar, 50).Value = maHD;
                cmd.Parameters.Add("@LaiSuatHangThang", SqlDbType.Int).Value = laiSuatHangThang;
                cmd.Parameters.Add("@TienTraTruoc", SqlDbType.Int).Value = tienTraTruoc;
                cmd.Parameters.Add("@TienConLai", SqlDbType.Int).Value = tienConLai;
                cmd.Parameters.Add("@NgayBatDau", SqlDbType.Date).Value = ngayBatDau;
                cmd.Parameters.Add("@NgayDaoHan", SqlDbType.Date).Value = ngayDaoHan;

                db.openConnectionAdmin();
                cmd.ExecuteNonQuery();
                db.closeConnectionAdmin();

                MessageBox.Show("Đã cập nhật thành công", "Thành công", MessageBoxButtons.OK);
                classDAL.loadData("select * from v1_infTraGop", dgv_TraGop);
                tabControl1.SelectedTab = this.tabPage1;
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.closeConnectionAdmin();
                return false;
            }
        }

        private void btn_Sua_TraGop_Click(object sender, EventArgs e)
        {
            String maHD = this.txt_MaHD.Text; // Dùng MaHD thay cho MaGBH
            int laiSuatHangThang;
            int tienTraTruoc;
            int tienConLai;
            DateTime ngayBatDau = guna2DateTimePicker1.Value;
            DateTime ngayDaoHan = guna2DateTimePicker2.Value;

            // Kiểm tra giá trị nhập vào
            if (string.IsNullOrWhiteSpace(maHD) ||
                !int.TryParse(this.txt_LaiSuatHangThang.Text, out laiSuatHangThang) ||
                !int.TryParse(this.txt_TienTraTruoc.Text, out tienTraTruoc) ||
                !int.TryParse(this.txt_TienConLai.Text, out tienConLai))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin hợp lệ.", "Lỗi", MessageBoxButtons.OK);
                return;
            }

            UpdateTraGop(maHD, laiSuatHangThang, tienTraTruoc, tienConLai, ngayBatDau, ngayDaoHan);
        }

        private void btn_TimKiem_TraGop_Click(object sender, EventArgs e)
        {
            string maHD = txt_search_MHD.Text.Trim(); // Sử dụng txt_search_MaHD cho tìm kiếm

            // Nếu textbox rỗng, tải lại toàn bộ dữ liệu
            if (string.IsNullOrEmpty(maHD))
            {
                classDAL.loadData("select * from v2_infTraGop", dgv_TraGop);
            }
            else
            {
                // Tạo SqlCommand để gọi procedure tìm kiếm
                SqlCommand command = new SqlCommand("pro_GetTraGopByMaHD", db.getConnectionAdmin);
                command.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                command.Parameters.Add("@MaHD", SqlDbType.VarChar, 50).Value = maHD;

                db.openConnectionAdmin();

                DataTable table = new DataTable();

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(table);
                }

                // Hiển thị dữ liệu tìm kiếm lên DataGridView
                dgv_TraGop.Rows.Clear();
                foreach (DataRow row in table.Rows)
                {
                    dgv_TraGop.Rows.Add(row.ItemArray);
                }
                db.closeConnectionAdmin();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
