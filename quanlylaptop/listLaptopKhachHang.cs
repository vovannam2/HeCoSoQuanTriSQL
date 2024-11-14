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
    public partial class listLaptopKhachHang : Form
    {
        private string maKH;

        public listLaptopKhachHang(string maKH)
        {
            InitializeComponent();
            this.maKH = maKH;
            LoadLaptopData();
        }
        MyConnect myconn = new MyConnect();
        ClassDAL classDAL = new ClassDAL();
        private void listLaptopKhachHang_Load(object sender, EventArgs e)
        {
            LoadLaptopData();
        }
        private void LoadLaptopData()
        {
            // Tên của stored procedure
            dgv_ListLaptop.Columns.Clear();
            string procedureName = "LayDanhSachLaptopBaoHanh";

            // Tên tham số trong stored procedure
            string paramName = "@MaKH";

            // Gọi phương thức loadDataWithStoredProcedure để thực thi stored procedure và hiển thị dữ liệu
            classDAL.loadDataWithStoredProcedure(procedureName, paramName, maKH, dgv_ListLaptop);
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Laptop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
