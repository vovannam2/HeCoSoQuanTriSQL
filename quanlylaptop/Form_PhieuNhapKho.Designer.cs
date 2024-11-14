namespace quanlylaptop
{
    partial class Form_PhieuNhapKho
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_TimKiem_Laptop = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Add_PNK = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_PhieuNhapKho = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaNK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhapKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.dtp_ngaynhapkho = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_Sua_PNK = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Xoa_PNK = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Them_PNK = new Guna.UI2.WinForms.Guna2Button();
            this.txt_PTTT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_ThanhTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_MaNCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_MaNK = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuNhapKho)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1272, 860);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.guna2DateTimePicker1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btn_TimKiem_Laptop);
            this.tabPage1.Controls.Add(this.btn_Add_PNK);
            this.tabPage1.Controls.Add(this.dgv_PhieuNhapKho);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1264, 831);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(890, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nhập ngày nhập kho:";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(893, 92);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(244, 36);
            this.guna2DateTimePicker1.TabIndex = 41;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 10, 19, 13, 39, 20, 873);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(490, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 38);
            this.label4.TabIndex = 40;
            this.label4.Text = "Phiếu nhập kho";
            // 
            // btn_TimKiem_Laptop
            // 
            this.btn_TimKiem_Laptop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_TimKiem_Laptop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiem_Laptop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiem_Laptop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TimKiem_Laptop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TimKiem_Laptop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btn_TimKiem_Laptop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_TimKiem_Laptop.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem_Laptop.ImageSize = new System.Drawing.Size(52, 52);
            this.btn_TimKiem_Laptop.Location = new System.Drawing.Point(1173, 79);
            this.btn_TimKiem_Laptop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimKiem_Laptop.Name = "btn_TimKiem_Laptop";
            this.btn_TimKiem_Laptop.Size = new System.Drawing.Size(87, 49);
            this.btn_TimKiem_Laptop.TabIndex = 20;
            this.btn_TimKiem_Laptop.Text = "Tìm";
            // 
            // btn_Add_PNK
            // 
            this.btn_Add_PNK.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add_PNK.BorderColor = System.Drawing.Color.IndianRed;
            this.btn_Add_PNK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add_PNK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add_PNK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add_PNK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Add_PNK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btn_Add_PNK.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_PNK.ForeColor = System.Drawing.Color.White;
            this.btn_Add_PNK.Location = new System.Drawing.Point(8, 76);
            this.btn_Add_PNK.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add_PNK.Name = "btn_Add_PNK";
            this.btn_Add_PNK.Size = new System.Drawing.Size(240, 52);
            this.btn_Add_PNK.TabIndex = 18;
            this.btn_Add_PNK.Text = "+ Thêm phiếu nhập kho";
            this.btn_Add_PNK.Click += new System.EventHandler(this.btn_Add_PNK_Click);
            // 
            // dgv_PhieuNhapKho
            // 
            this.dgv_PhieuNhapKho.AllowUserToAddRows = false;
            this.dgv_PhieuNhapKho.AllowUserToDeleteRows = false;
            this.dgv_PhieuNhapKho.AllowUserToResizeColumns = false;
            this.dgv_PhieuNhapKho.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_PhieuNhapKho.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_PhieuNhapKho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_PhieuNhapKho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PhieuNhapKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_PhieuNhapKho.ColumnHeadersHeight = 80;
            this.dgv_PhieuNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_PhieuNhapKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNK,
            this.MaNCC,
            this.NgayNhapKho,
            this.ThanhTien,
            this.PTTT});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_PhieuNhapKho.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_PhieuNhapKho.Location = new System.Drawing.Point(16, 202);
            this.dgv_PhieuNhapKho.Name = "dgv_PhieuNhapKho";
            this.dgv_PhieuNhapKho.RowHeadersVisible = false;
            this.dgv_PhieuNhapKho.RowHeadersWidth = 62;
            this.dgv_PhieuNhapKho.RowTemplate.Height = 24;
            this.dgv_PhieuNhapKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
            this.dgv_PhieuNhapKho.ShowCellErrors = false;
            this.dgv_PhieuNhapKho.ShowCellToolTips = false;
            this.dgv_PhieuNhapKho.ShowEditingIcon = false;
            this.dgv_PhieuNhapKho.ShowRowErrors = false;
            this.dgv_PhieuNhapKho.Size = new System.Drawing.Size(1240, 630);
            this.dgv_PhieuNhapKho.TabIndex = 0;
            this.dgv_PhieuNhapKho.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_PhieuNhapKho.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_PhieuNhapKho.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_PhieuNhapKho.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_PhieuNhapKho.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_PhieuNhapKho.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_PhieuNhapKho.ThemeStyle.GridColor = System.Drawing.SystemColors.ControlDark;
            this.dgv_PhieuNhapKho.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_PhieuNhapKho.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_PhieuNhapKho.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_PhieuNhapKho.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_PhieuNhapKho.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_PhieuNhapKho.ThemeStyle.HeaderStyle.Height = 80;
            this.dgv_PhieuNhapKho.ThemeStyle.ReadOnly = false;
            this.dgv_PhieuNhapKho.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_PhieuNhapKho.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_PhieuNhapKho.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_PhieuNhapKho.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_PhieuNhapKho.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_PhieuNhapKho.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_PhieuNhapKho.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_PhieuNhapKho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhieuNhapKho_CellContentClick);
            // 
            // MaNK
            // 
            this.MaNK.FillWeight = 80F;
            this.MaNK.HeaderText = "Mã nhập kho";
            this.MaNK.MinimumWidth = 8;
            this.MaNK.Name = "MaNK";
            // 
            // MaNCC
            // 
            this.MaNCC.HeaderText = "Mã nhà cung cấp";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            // 
            // NgayNhapKho
            // 
            this.NgayNhapKho.HeaderText = "Ngày nhập kho";
            this.NgayNhapKho.MinimumWidth = 6;
            this.NgayNhapKho.Name = "NgayNhapKho";
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            // 
            // PTTT
            // 
            this.PTTT.HeaderText = "Phương thức thanh toán";
            this.PTTT.MinimumWidth = 6;
            this.PTTT.Name = "PTTT";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.btn_close);
            this.tabPage2.Controls.Add(this.dtp_ngaynhapkho);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.btn_Sua_PNK);
            this.tabPage2.Controls.Add(this.btn_Xoa_PNK);
            this.tabPage2.Controls.Add(this.btn_Them_PNK);
            this.tabPage2.Controls.Add(this.txt_PTTT);
            this.tabPage2.Controls.Add(this.txt_ThanhTien);
            this.tabPage2.Controls.Add(this.txt_MaNCC);
            this.tabPage2.Controls.Add(this.txt_MaNK);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1264, 831);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            // 
            // btn_close
            // 
            this.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_close.FillColor = System.Drawing.Color.Red;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(1200, 6);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(58, 25);
            this.btn_close.TabIndex = 29;
            this.btn_close.Text = "X";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // dtp_ngaynhapkho
            // 
            this.dtp_ngaynhapkho.Checked = true;
            this.dtp_ngaynhapkho.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngaynhapkho.FillColor = System.Drawing.Color.White;
            this.dtp_ngaynhapkho.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_ngaynhapkho.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaynhapkho.Location = new System.Drawing.Point(536, 227);
            this.dtp_ngaynhapkho.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_ngaynhapkho.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_ngaynhapkho.Name = "dtp_ngaynhapkho";
            this.dtp_ngaynhapkho.Size = new System.Drawing.Size(459, 42);
            this.dtp_ngaynhapkho.TabIndex = 28;
            this.dtp_ngaynhapkho.Value = new System.DateTime(2024, 10, 19, 13, 51, 4, 656);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label19.Location = new System.Drawing.Point(431, 37);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(499, 32);
            this.label19.TabIndex = 27;
            this.label19.Text = "TÙY CHỈNH THÔNG TIN PHIẾU NHẬP KHO";
            // 
            // btn_Sua_PNK
            // 
            this.btn_Sua_PNK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Sua_PNK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Sua_PNK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Sua_PNK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Sua_PNK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btn_Sua_PNK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Sua_PNK.ForeColor = System.Drawing.Color.White;
            this.btn_Sua_PNK.Location = new System.Drawing.Point(851, 475);
            this.btn_Sua_PNK.Name = "btn_Sua_PNK";
            this.btn_Sua_PNK.Size = new System.Drawing.Size(180, 45);
            this.btn_Sua_PNK.TabIndex = 26;
            this.btn_Sua_PNK.Text = "Sửa";
            this.btn_Sua_PNK.Click += new System.EventHandler(this.btn_Sua_PNK_Click);
            // 
            // btn_Xoa_PNK
            // 
            this.btn_Xoa_PNK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa_PNK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa_PNK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Xoa_PNK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Xoa_PNK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btn_Xoa_PNK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Xoa_PNK.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa_PNK.Location = new System.Drawing.Point(347, 475);
            this.btn_Xoa_PNK.Name = "btn_Xoa_PNK";
            this.btn_Xoa_PNK.Size = new System.Drawing.Size(180, 45);
            this.btn_Xoa_PNK.TabIndex = 26;
            this.btn_Xoa_PNK.Text = "Xóa";
            this.btn_Xoa_PNK.Click += new System.EventHandler(this.btn_Xoa_PNK_Click);
            // 
            // btn_Them_PNK
            // 
            this.btn_Them_PNK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them_PNK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them_PNK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Them_PNK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Them_PNK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btn_Them_PNK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Them_PNK.ForeColor = System.Drawing.Color.White;
            this.btn_Them_PNK.Location = new System.Drawing.Point(578, 568);
            this.btn_Them_PNK.Name = "btn_Them_PNK";
            this.btn_Them_PNK.Size = new System.Drawing.Size(180, 45);
            this.btn_Them_PNK.TabIndex = 26;
            this.btn_Them_PNK.Text = "Thêm";
            this.btn_Them_PNK.Click += new System.EventHandler(this.btn_Them_PNK_Click);
            // 
            // txt_PTTT
            // 
            this.txt_PTTT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PTTT.DefaultText = "";
            this.txt_PTTT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_PTTT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_PTTT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_PTTT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_PTTT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_PTTT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_PTTT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_PTTT.Location = new System.Drawing.Point(536, 326);
            this.txt_PTTT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_PTTT.Name = "txt_PTTT";
            this.txt_PTTT.PasswordChar = '\0';
            this.txt_PTTT.PlaceholderText = "";
            this.txt_PTTT.SelectedText = "";
            this.txt_PTTT.Size = new System.Drawing.Size(459, 42);
            this.txt_PTTT.TabIndex = 17;
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ThanhTien.DefaultText = "";
            this.txt_ThanhTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ThanhTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ThanhTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ThanhTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ThanhTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ThanhTien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ThanhTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ThanhTien.Location = new System.Drawing.Point(536, 276);
            this.txt_ThanhTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.PasswordChar = '\0';
            this.txt_ThanhTien.PlaceholderText = "";
            this.txt_ThanhTien.SelectedText = "";
            this.txt_ThanhTien.Size = new System.Drawing.Size(459, 42);
            this.txt_ThanhTien.TabIndex = 16;
            // 
            // txt_MaNCC
            // 
            this.txt_MaNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaNCC.DefaultText = "";
            this.txt_MaNCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MaNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MaNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaNCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaNCC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaNCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaNCC.Location = new System.Drawing.Point(536, 176);
            this.txt_MaNCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MaNCC.Name = "txt_MaNCC";
            this.txt_MaNCC.PasswordChar = '\0';
            this.txt_MaNCC.PlaceholderText = "";
            this.txt_MaNCC.SelectedText = "";
            this.txt_MaNCC.Size = new System.Drawing.Size(459, 42);
            this.txt_MaNCC.TabIndex = 14;
            // 
            // txt_MaNK
            // 
            this.txt_MaNK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaNK.DefaultText = "";
            this.txt_MaNK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MaNK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MaNK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaNK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaNK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaNK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaNK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaNK.Location = new System.Drawing.Point(536, 126);
            this.txt_MaNK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MaNK.Name = "txt_MaNK";
            this.txt_MaNK.PasswordChar = '\0';
            this.txt_MaNK.PlaceholderText = "";
            this.txt_MaNK.SelectedText = "";
            this.txt_MaNK.Size = new System.Drawing.Size(459, 42);
            this.txt_MaNK.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label10.Location = new System.Drawing.Point(281, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(225, 28);
            this.label10.TabIndex = 4;
            this.label10.Text = "Phương thức thanh toán";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(281, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 28);
            this.label9.TabIndex = 3;
            this.label9.Text = "Thành tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(281, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ngày nhập kho";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(281, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã nhà cung cấp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(281, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã nhập kho";
            // 
            // Form_PhieuNhapKho
            // 
            this.ClientSize = new System.Drawing.Size(1385, 892);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_PhieuNhapKho";
            this.Text = "8";
            this.Load += new System.EventHandler(this.Form_PhieuNhapKho_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuNhapKho)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_PhieuNhapKho;
        private Guna.UI2.WinForms.Guna2Button btn_TimKiem_Laptop;
        private Guna.UI2.WinForms.Guna2Button btn_Add_PNK;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txt_PTTT;
        private Guna.UI2.WinForms.Guna2TextBox txt_ThanhTien;
        private Guna.UI2.WinForms.Guna2TextBox txt_MaNCC;
        private Guna.UI2.WinForms.Guna2TextBox txt_MaNK;
        private Guna.UI2.WinForms.Guna2Button btn_Them_PNK;
        private System.Windows.Forms.Label label19;
        private Guna.UI2.WinForms.Guna2Button btn_Sua_PNK;
        private Guna.UI2.WinForms.Guna2Button btn_Xoa_PNK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_ngaynhapkho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhapKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTTT;
        private Guna.UI2.WinForms.Guna2Button btn_close;
    }
}