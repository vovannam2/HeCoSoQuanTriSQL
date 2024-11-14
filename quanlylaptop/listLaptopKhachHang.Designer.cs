namespace quanlylaptop
{
    partial class listLaptopKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_ListLaptop = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHangLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mausac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DungLuongBoNho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayMuaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianBaoHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiBaoHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListLaptop)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ListLaptop
            // 
            this.dgv_ListLaptop.AllowUserToAddRows = false;
            this.dgv_ListLaptop.AllowUserToDeleteRows = false;
            this.dgv_ListLaptop.AllowUserToResizeColumns = false;
            this.dgv_ListLaptop.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_ListLaptop.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ListLaptop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_ListLaptop.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ListLaptop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ListLaptop.ColumnHeadersHeight = 80;
            this.dgv_ListLaptop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_ListLaptop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLT,
            this.TenLT,
            this.TenHangLT,
            this.Mausac,
            this.DungLuongBoNho,
            this.ManHinh,
            this.CPU,
            this.Pin,
            this.ngayMuaHang,
            this.thoiGianBaoHang,
            this.ngayHetHan,
            this.trangThaiBaoHanh});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ListLaptop.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ListLaptop.Location = new System.Drawing.Point(12, 81);
            this.dgv_ListLaptop.Name = "dgv_ListLaptop";
            this.dgv_ListLaptop.ReadOnly = true;
            this.dgv_ListLaptop.RowHeadersVisible = false;
            this.dgv_ListLaptop.RowHeadersWidth = 62;
            this.dgv_ListLaptop.RowTemplate.Height = 24;
            this.dgv_ListLaptop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
            this.dgv_ListLaptop.ShowCellErrors = false;
            this.dgv_ListLaptop.ShowCellToolTips = false;
            this.dgv_ListLaptop.ShowEditingIcon = false;
            this.dgv_ListLaptop.ShowRowErrors = false;
            this.dgv_ListLaptop.Size = new System.Drawing.Size(1339, 441);
            this.dgv_ListLaptop.TabIndex = 1;
            this.dgv_ListLaptop.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_ListLaptop.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_ListLaptop.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_ListLaptop.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_ListLaptop.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_ListLaptop.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_ListLaptop.ThemeStyle.GridColor = System.Drawing.SystemColors.ControlDark;
            this.dgv_ListLaptop.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_ListLaptop.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_ListLaptop.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_ListLaptop.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_ListLaptop.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_ListLaptop.ThemeStyle.HeaderStyle.Height = 80;
            this.dgv_ListLaptop.ThemeStyle.ReadOnly = true;
            this.dgv_ListLaptop.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_ListLaptop.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_ListLaptop.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_ListLaptop.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_ListLaptop.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_ListLaptop.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_ListLaptop.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_ListLaptop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Laptop_CellContentClick);
            // 
            // MaLT
            // 
            this.MaLT.HeaderText = "Mã Laptop";
            this.MaLT.MinimumWidth = 8;
            this.MaLT.Name = "MaLT";
            this.MaLT.ReadOnly = true;
            // 
            // TenLT
            // 
            this.TenLT.HeaderText = "Tên Laptop";
            this.TenLT.MinimumWidth = 6;
            this.TenLT.Name = "TenLT";
            this.TenLT.ReadOnly = true;
            // 
            // TenHangLT
            // 
            this.TenHangLT.HeaderText = "Tên hãng Laptop";
            this.TenHangLT.MinimumWidth = 6;
            this.TenHangLT.Name = "TenHangLT";
            this.TenHangLT.ReadOnly = true;
            // 
            // Mausac
            // 
            this.Mausac.HeaderText = "Màu sắc";
            this.Mausac.MinimumWidth = 6;
            this.Mausac.Name = "Mausac";
            this.Mausac.ReadOnly = true;
            // 
            // DungLuongBoNho
            // 
            this.DungLuongBoNho.HeaderText = "Dung lượng bộ nhớ";
            this.DungLuongBoNho.MinimumWidth = 6;
            this.DungLuongBoNho.Name = "DungLuongBoNho";
            this.DungLuongBoNho.ReadOnly = true;
            // 
            // ManHinh
            // 
            this.ManHinh.HeaderText = "Màn hình";
            this.ManHinh.MinimumWidth = 6;
            this.ManHinh.Name = "ManHinh";
            this.ManHinh.ReadOnly = true;
            // 
            // CPU
            // 
            this.CPU.HeaderText = "CPU";
            this.CPU.MinimumWidth = 6;
            this.CPU.Name = "CPU";
            this.CPU.ReadOnly = true;
            // 
            // Pin
            // 
            this.Pin.HeaderText = "Pin";
            this.Pin.MinimumWidth = 6;
            this.Pin.Name = "Pin";
            this.Pin.ReadOnly = true;
            // 
            // ngayMuaHang
            // 
            this.ngayMuaHang.HeaderText = "Ngày Mua Hàng";
            this.ngayMuaHang.MinimumWidth = 6;
            this.ngayMuaHang.Name = "ngayMuaHang";
            this.ngayMuaHang.ReadOnly = true;
            // 
            // thoiGianBaoHang
            // 
            this.thoiGianBaoHang.HeaderText = "Thời gian bảo hành";
            this.thoiGianBaoHang.MinimumWidth = 6;
            this.thoiGianBaoHang.Name = "thoiGianBaoHang";
            this.thoiGianBaoHang.ReadOnly = true;
            // 
            // ngayHetHan
            // 
            this.ngayHetHan.HeaderText = "Ngày hết hạn bảo hành";
            this.ngayHetHan.MinimumWidth = 6;
            this.ngayHetHan.Name = "ngayHetHan";
            this.ngayHetHan.ReadOnly = true;
            // 
            // trangThaiBaoHanh
            // 
            this.trangThaiBaoHanh.HeaderText = "Trạng thái bảo hành";
            this.trangThaiBaoHanh.MinimumWidth = 6;
            this.trangThaiBaoHanh.Name = "trangThaiBaoHanh";
            this.trangThaiBaoHanh.ReadOnly = true;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 24;
            this.iconButton1.Location = new System.Drawing.Point(1192, 12);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(37, 27);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // listLaptopKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 574);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.dgv_ListLaptop);
            this.Name = "listLaptopKhachHang";
            this.Text = "listLaptopKhachHang";
            this.Load += new System.EventHandler(this.listLaptopKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListLaptop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv_ListLaptop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHangLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mausac;
        private System.Windows.Forms.DataGridViewTextBoxColumn DungLuongBoNho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayMuaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianBaoHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHetHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiBaoHanh;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}