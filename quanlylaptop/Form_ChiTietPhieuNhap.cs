﻿using quanlylaptop.DAL;
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
    public partial class Form_ChiTietPhieuNhap : Form
    {
        public Form_ChiTietPhieuNhap()
        {
            InitializeComponent();
        }

        private void dgv_ChiTietPhieuNhapKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_ChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            ClassDAL classDAL = new ClassDAL();
            classDAL.loadData("select * from ChiTietPhieuNhap", dgv_ChiTietPhieuNhapKho);
        }
    }
}
