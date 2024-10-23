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
    public partial class Form_PhieuNhapKho : Form
    {
        public Form_PhieuNhapKho()
        {
            InitializeComponent();
        }

        private void Form_PhieuNhapKho_Load(object sender, EventArgs e)
        {
            ClassDAL classDAL = new ClassDAL();
            classDAL.loadData("select * from v_infThongTinNhapKho", dgv_PhieuNhapKho);
        }

        private void dgv_PhieuNhapKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
