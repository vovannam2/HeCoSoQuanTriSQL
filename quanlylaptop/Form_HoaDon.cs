using quanlylaptop.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlylaptop
{
    public partial class Form_HoaDon : Form
    {
        public Form_HoaDon()
        {
            InitializeComponent();
        }

        private void Form_HoaDon_Load(object sender, EventArgs e)
        {
            ClassDAL classDAL = new ClassDAL();
            classDAL.loadData("select * from v1_infThongTinHoaDon", dgv_HoaDon);
            //foreach (DataGridViewColumn column in this.dgv_HoaDon.Columns)
            //{
            //    Console.WriteLine(column.Name);
            //}
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
                this.guna2DateTimePicker3.Value = ngayMuaHang; // Gán giá trị vào DateTimePicker


                // Chuyển đổi kiểu dữ liệu cho các trường cần thiết
                this.txt_SoTienDaThanhToan.Text = Convert.ToInt32(row.Cells["SoTienDaThanhToan"].Value).ToString();


                // Chuyển sang tab Options
                this.tabControl1.SelectedTab = this.tabPage2;
            }
        }
    }
}
