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
    public partial class Form_HoatDongBH : Form
    {
        public Form_HoatDongBH()
        {
            InitializeComponent();
        }

        private void dgv_HĐBH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_HoatDongBH_Load(object sender, EventArgs e)
        {
            ClassDAL classDAL = new ClassDAL();
            classDAL.loadData("select * from v_infBaoHanh", dgv_HĐBH);
        }
    }
}
