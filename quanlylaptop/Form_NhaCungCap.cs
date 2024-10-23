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
    public partial class Form_NhaCungCap : Form
    {
        public Form_NhaCungCap()
        {
            InitializeComponent();
        }

        private void Form_NhaCungCap_Load(object sender, EventArgs e)
        {
            ClassDAL classDAL = new ClassDAL();
            classDAL.loadData("select * from v_infNhaCungCap", dgv_NhaCungCap);
        }

        private void dgv_NhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
