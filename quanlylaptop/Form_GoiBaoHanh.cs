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
    public partial class Form_GoiBaoHanh : Form
    {
        public Form_GoiBaoHanh()
        {
            InitializeComponent();
        }

       
        private void dgv_GoiBaoHanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 )
            {
                // Lấy hàng hiện tại
                DataGridViewRow row = this.dgv_GoiBaoHanh.Rows[e.RowIndex];

                // Gán giá trị vào các Guna2TextBox hoặc điều khiển khác
                this.txt_MaGBH.Text = row.Cells["MaGoiBH"].Value?.ToString();  // Mã gói bảo hiểm
                this.txt_TenGoiBH.Text = row.Cells["TenGoiBH"].Value?.ToString();  // Tên gói bảo hiểm
                this.txt_MoTaChiTiet.Text = row.Cells["MoTaChiTiet"].Value?.ToString();  // Mô tả chi tiết

                // Ẩn nút "Thêm"
                this.btn_Them_GoiBH.Visible = false;

                // Chuyển sang tab Options
                this.tabControl1.SelectedTab = this.tabPage2;
            }
        }

        private void Form_GoiBaoHanh_Load(object sender, EventArgs e)
        {
            ClassDAL classDAL = new ClassDAL();
            classDAL.loadData("select * from v_GoiBaoHanh", dgv_GoiBaoHanh);
        }

        private void btn_Add_GoiBaoHanh_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage2;
            this.label19.Text = "THÊM GÓI BẢO HÀNH";
            this.btn_Sua_GoiBH.Visible = false; // Ẩn nút "Thêm"
            this.btn_Xoa_GoiBH.Visible = false; // Ẩn nút "Thêm"
            this.btn_Them_GoiBH.Visible = true;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.txt_MaGBH.Text = string.Empty;
            this.txt_TenGoiBH.Text = string.Empty;
            this.txt_MoTaChiTiet.Text = string.Empty;
           

            this.tabControl1.SelectedTab = this.tabPage1;
            this.label19.Text = "TÙY CHỈNH THÔNG TIN ";
            this.btn_Sua_GoiBH.Visible = true;
            this.btn_Xoa_GoiBH.Visible = true;
            this.btn_Them_GoiBH.Visible = false;
        }
    }
}
