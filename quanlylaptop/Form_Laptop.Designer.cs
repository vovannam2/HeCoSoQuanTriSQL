namespace quanlylaptop
{
    partial class Form_Laptop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cb1_dungluong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb1_mausac = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb1_KichThuocManHinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb1_HangLaptop = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb_giaMax = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TimKiem_Laptop = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Add_Laptop = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_Laptop = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHangLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhoiLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBaoHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBanGoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mausac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DungLuongBoNho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuaTangKem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cb2_manhinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb2_mausac = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb2_dungluong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb2_hanglaptop = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_updateLaptop = new Guna.UI2.WinForms.Guna2Button();
            this.btn_xoaLaptop = new Guna.UI2.WinForms.Guna2Button();
            this.btn_addLapTop = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Pin = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_QuaTangKem = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_CPU = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_GiaBanGoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_ThoiGianBaoHanh = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_KhoiLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_SoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_TenLT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_MaLT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Laptop)).BeginInit();
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
            this.tabPage1.Controls.Add(this.cb1_dungluong);
            this.tabPage1.Controls.Add(this.cb1_mausac);
            this.tabPage1.Controls.Add(this.cb1_KichThuocManHinh);
            this.tabPage1.Controls.Add(this.cb1_HangLaptop);
            this.tabPage1.Controls.Add(this.cb_giaMax);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.guna2TextBox1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_TimKiem_Laptop);
            this.tabPage1.Controls.Add(this.btn_Add_Laptop);
            this.tabPage1.Controls.Add(this.dgv_Laptop);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1264, 831);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Information";
            // 
            // cb1_dungluong
            // 
            this.cb1_dungluong.BackColor = System.Drawing.Color.Transparent;
            this.cb1_dungluong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb1_dungluong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb1_dungluong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb1_dungluong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb1_dungluong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb1_dungluong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb1_dungluong.ItemHeight = 30;
            this.cb1_dungluong.Items.AddRange(new object[] {
            "256GB",
            "512GB",
            "1TB"});
            this.cb1_dungluong.Location = new System.Drawing.Point(519, 202);
            this.cb1_dungluong.Name = "cb1_dungluong";
            this.cb1_dungluong.Size = new System.Drawing.Size(176, 36);
            this.cb1_dungluong.TabIndex = 47;
            this.cb1_dungluong.SelectedIndexChanged += new System.EventHandler(this.cb1_dungluong_SelectedIndexChanged);
            // 
            // cb1_mausac
            // 
            this.cb1_mausac.BackColor = System.Drawing.Color.Transparent;
            this.cb1_mausac.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb1_mausac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb1_mausac.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb1_mausac.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb1_mausac.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb1_mausac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb1_mausac.ItemHeight = 30;
            this.cb1_mausac.Items.AddRange(new object[] {
            "Đen",
            "Bạc",
            "Xám",
            "Trắng"});
            this.cb1_mausac.Location = new System.Drawing.Point(781, 202);
            this.cb1_mausac.Name = "cb1_mausac";
            this.cb1_mausac.Size = new System.Drawing.Size(184, 36);
            this.cb1_mausac.TabIndex = 46;
            this.cb1_mausac.SelectedIndexChanged += new System.EventHandler(this.cb1_mausac_SelectedIndexChanged);
            // 
            // cb1_KichThuocManHinh
            // 
            this.cb1_KichThuocManHinh.BackColor = System.Drawing.Color.Transparent;
            this.cb1_KichThuocManHinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb1_KichThuocManHinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb1_KichThuocManHinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb1_KichThuocManHinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb1_KichThuocManHinh.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.cb1_KichThuocManHinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb1_KichThuocManHinh.ItemHeight = 30;
            this.cb1_KichThuocManHinh.Items.AddRange(new object[] {
            "14.7",
            "15.6"});
            this.cb1_KichThuocManHinh.Location = new System.Drawing.Point(1039, 202);
            this.cb1_KichThuocManHinh.Name = "cb1_KichThuocManHinh";
            this.cb1_KichThuocManHinh.Size = new System.Drawing.Size(193, 36);
            this.cb1_KichThuocManHinh.TabIndex = 45;
            this.cb1_KichThuocManHinh.SelectedIndexChanged += new System.EventHandler(this.cb1_KichThuocManHinh_SelectedIndexChanged);
            // 
            // cb1_HangLaptop
            // 
            this.cb1_HangLaptop.BackColor = System.Drawing.Color.Transparent;
            this.cb1_HangLaptop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb1_HangLaptop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb1_HangLaptop.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb1_HangLaptop.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb1_HangLaptop.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb1_HangLaptop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb1_HangLaptop.ItemHeight = 30;
            this.cb1_HangLaptop.Items.AddRange(new object[] {
            "MacBook",
            "Lenovo",
            "Dell",
            "Asus",
            "HP",
            "MSI"});
            this.cb1_HangLaptop.Location = new System.Drawing.Point(280, 202);
            this.cb1_HangLaptop.Name = "cb1_HangLaptop";
            this.cb1_HangLaptop.Size = new System.Drawing.Size(193, 36);
            this.cb1_HangLaptop.TabIndex = 44;
            this.cb1_HangLaptop.SelectedIndexChanged += new System.EventHandler(this.cb1_HangLaptop_SelectedIndexChanged);
            // 
            // cb_giaMax
            // 
            this.cb_giaMax.BackColor = System.Drawing.Color.Transparent;
            this.cb_giaMax.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_giaMax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_giaMax.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_giaMax.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_giaMax.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_giaMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_giaMax.ItemHeight = 30;
            this.cb_giaMax.Items.AddRange(new object[] {
            "50000000",
            "10000000",
            "15000000",
            "20000000"});
            this.cb_giaMax.Location = new System.Drawing.Point(32, 202);
            this.cb_giaMax.Name = "cb_giaMax";
            this.cb_giaMax.Size = new System.Drawing.Size(176, 36);
            this.cb_giaMax.TabIndex = 43;
            this.cb_giaMax.SelectedIndexChanged += new System.EventHandler(this.cb_giaMax_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label20.Location = new System.Drawing.Point(499, 5);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(235, 32);
            this.label20.TabIndex = 39;
            this.label20.Text = "Thông tin laptop";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(809, 76);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(353, 49);
            this.guna2TextBox1.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1036, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "Nhập kích thước màn hình:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(778, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nhập màu sắc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(516, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nhập dung lượng bộ nhớ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nhập tên hãng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nhập giá max:";
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
            this.btn_TimKiem_Laptop.Location = new System.Drawing.Point(1169, 76);
            this.btn_TimKiem_Laptop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimKiem_Laptop.Name = "btn_TimKiem_Laptop";
            this.btn_TimKiem_Laptop.Size = new System.Drawing.Size(87, 49);
            this.btn_TimKiem_Laptop.TabIndex = 20;
            this.btn_TimKiem_Laptop.Text = "Tìm";
            // 
            // btn_Add_Laptop
            // 
            this.btn_Add_Laptop.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add_Laptop.BorderColor = System.Drawing.Color.IndianRed;
            this.btn_Add_Laptop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add_Laptop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add_Laptop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add_Laptop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Add_Laptop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btn_Add_Laptop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Laptop.ForeColor = System.Drawing.Color.White;
            this.btn_Add_Laptop.Location = new System.Drawing.Point(8, 76);
            this.btn_Add_Laptop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add_Laptop.Name = "btn_Add_Laptop";
            this.btn_Add_Laptop.Size = new System.Drawing.Size(240, 52);
            this.btn_Add_Laptop.TabIndex = 18;
            this.btn_Add_Laptop.Text = "+ Thêm laptop";
            this.btn_Add_Laptop.Click += new System.EventHandler(this.btn_Add_Laptop_Click);
            // 
            // dgv_Laptop
            // 
            this.dgv_Laptop.AllowUserToAddRows = false;
            this.dgv_Laptop.AllowUserToDeleteRows = false;
            this.dgv_Laptop.AllowUserToResizeColumns = false;
            this.dgv_Laptop.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgv_Laptop.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Laptop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Laptop.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Laptop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Laptop.ColumnHeadersHeight = 80;
            this.dgv_Laptop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Laptop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLT,
            this.TenLT,
            this.TenHangLT,
            this.SoLuong,
            this.KhoiLuong,
            this.ThoiGianBaoHanh,
            this.GiaBanGoc,
            this.Mausac,
            this.DungLuongBoNho,
            this.ManHinh,
            this.CPU,
            this.Pin,
            this.QuaTangKem});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Laptop.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Laptop.Location = new System.Drawing.Point(16, 250);
            this.dgv_Laptop.Name = "dgv_Laptop";
            this.dgv_Laptop.RowHeadersVisible = false;
            this.dgv_Laptop.RowHeadersWidth = 62;
            this.dgv_Laptop.RowTemplate.Height = 24;
            this.dgv_Laptop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
            this.dgv_Laptop.ShowCellErrors = false;
            this.dgv_Laptop.ShowCellToolTips = false;
            this.dgv_Laptop.ShowEditingIcon = false;
            this.dgv_Laptop.ShowRowErrors = false;
            this.dgv_Laptop.Size = new System.Drawing.Size(1240, 582);
            this.dgv_Laptop.TabIndex = 0;
            this.dgv_Laptop.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Laptop.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Laptop.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Laptop.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Laptop.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Laptop.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Laptop.ThemeStyle.GridColor = System.Drawing.SystemColors.ControlDark;
            this.dgv_Laptop.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Laptop.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Laptop.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Laptop.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Laptop.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Laptop.ThemeStyle.HeaderStyle.Height = 80;
            this.dgv_Laptop.ThemeStyle.ReadOnly = false;
            this.dgv_Laptop.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Laptop.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Laptop.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Laptop.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Laptop.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_Laptop.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Laptop.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Laptop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Laptop_CellContentClick);
            // 
            // MaLT
            // 
            this.MaLT.HeaderText = "Mã Laptop";
            this.MaLT.MinimumWidth = 8;
            this.MaLT.Name = "MaLT";
            // 
            // TenLT
            // 
            this.TenLT.HeaderText = "Tên Laptop";
            this.TenLT.MinimumWidth = 6;
            this.TenLT.Name = "TenLT";
            // 
            // TenHangLT
            // 
            this.TenHangLT.HeaderText = "Tên hãng Laptop";
            this.TenHangLT.MinimumWidth = 6;
            this.TenHangLT.Name = "TenHangLT";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // KhoiLuong
            // 
            this.KhoiLuong.HeaderText = "Khối lượng";
            this.KhoiLuong.MinimumWidth = 6;
            this.KhoiLuong.Name = "KhoiLuong";
            // 
            // ThoiGianBaoHanh
            // 
            this.ThoiGianBaoHanh.HeaderText = "Thời gian bảo hành";
            this.ThoiGianBaoHanh.MinimumWidth = 6;
            this.ThoiGianBaoHanh.Name = "ThoiGianBaoHanh";
            // 
            // GiaBanGoc
            // 
            this.GiaBanGoc.HeaderText = "Giá bán gốc";
            this.GiaBanGoc.MinimumWidth = 6;
            this.GiaBanGoc.Name = "GiaBanGoc";
            // 
            // Mausac
            // 
            this.Mausac.HeaderText = "Màu sắc";
            this.Mausac.MinimumWidth = 6;
            this.Mausac.Name = "Mausac";
            // 
            // DungLuongBoNho
            // 
            this.DungLuongBoNho.HeaderText = "Dung lượng bộ nhớ";
            this.DungLuongBoNho.MinimumWidth = 6;
            this.DungLuongBoNho.Name = "DungLuongBoNho";
            // 
            // ManHinh
            // 
            this.ManHinh.HeaderText = "Màn hình";
            this.ManHinh.MinimumWidth = 6;
            this.ManHinh.Name = "ManHinh";
            // 
            // CPU
            // 
            this.CPU.HeaderText = "CPU";
            this.CPU.MinimumWidth = 6;
            this.CPU.Name = "CPU";
            // 
            // Pin
            // 
            this.Pin.HeaderText = "Pin";
            this.Pin.MinimumWidth = 6;
            this.Pin.Name = "Pin";
            // 
            // QuaTangKem
            // 
            this.QuaTangKem.HeaderText = "Quà tặng kèm";
            this.QuaTangKem.MinimumWidth = 6;
            this.QuaTangKem.Name = "QuaTangKem";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.btn_close);
            this.tabPage2.Controls.Add(this.cb2_manhinh);
            this.tabPage2.Controls.Add(this.cb2_mausac);
            this.tabPage2.Controls.Add(this.cb2_dungluong);
            this.tabPage2.Controls.Add(this.cb2_hanglaptop);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.btn_updateLaptop);
            this.tabPage2.Controls.Add(this.btn_xoaLaptop);
            this.tabPage2.Controls.Add(this.btn_addLapTop);
            this.tabPage2.Controls.Add(this.txt_Pin);
            this.tabPage2.Controls.Add(this.txt_QuaTangKem);
            this.tabPage2.Controls.Add(this.txt_CPU);
            this.tabPage2.Controls.Add(this.txt_GiaBanGoc);
            this.tabPage2.Controls.Add(this.txt_ThoiGianBaoHanh);
            this.tabPage2.Controls.Add(this.txt_KhoiLuong);
            this.tabPage2.Controls.Add(this.txt_SoLuong);
            this.tabPage2.Controls.Add(this.txt_TenLT);
            this.tabPage2.Controls.Add(this.txt_MaLT);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
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
            // cb2_manhinh
            // 
            this.cb2_manhinh.BackColor = System.Drawing.Color.Transparent;
            this.cb2_manhinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb2_manhinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb2_manhinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb2_manhinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb2_manhinh.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.cb2_manhinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb2_manhinh.ItemHeight = 30;
            this.cb2_manhinh.Items.AddRange(new object[] {
            "14.7",
            "15.6"});
            this.cb2_manhinh.Location = new System.Drawing.Point(428, 543);
            this.cb2_manhinh.Name = "cb2_manhinh";
            this.cb2_manhinh.Size = new System.Drawing.Size(459, 36);
            this.cb2_manhinh.TabIndex = 50;
            // 
            // cb2_mausac
            // 
            this.cb2_mausac.BackColor = System.Drawing.Color.Transparent;
            this.cb2_mausac.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb2_mausac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb2_mausac.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb2_mausac.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb2_mausac.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb2_mausac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb2_mausac.ItemHeight = 30;
            this.cb2_mausac.Items.AddRange(new object[] {
            "Đen",
            "Bạc",
            "Xám",
            "Trắng"});
            this.cb2_mausac.Location = new System.Drawing.Point(428, 442);
            this.cb2_mausac.Name = "cb2_mausac";
            this.cb2_mausac.Size = new System.Drawing.Size(459, 36);
            this.cb2_mausac.TabIndex = 49;
            // 
            // cb2_dungluong
            // 
            this.cb2_dungluong.BackColor = System.Drawing.Color.Transparent;
            this.cb2_dungluong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb2_dungluong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb2_dungluong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb2_dungluong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb2_dungluong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb2_dungluong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb2_dungluong.ItemHeight = 30;
            this.cb2_dungluong.Items.AddRange(new object[] {
            "256GB",
            "512GB",
            "1TB"});
            this.cb2_dungluong.Location = new System.Drawing.Point(428, 492);
            this.cb2_dungluong.Name = "cb2_dungluong";
            this.cb2_dungluong.Size = new System.Drawing.Size(459, 36);
            this.cb2_dungluong.TabIndex = 48;
            // 
            // cb2_hanglaptop
            // 
            this.cb2_hanglaptop.BackColor = System.Drawing.Color.Transparent;
            this.cb2_hanglaptop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb2_hanglaptop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb2_hanglaptop.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb2_hanglaptop.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb2_hanglaptop.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb2_hanglaptop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb2_hanglaptop.ItemHeight = 30;
            this.cb2_hanglaptop.Items.AddRange(new object[] {
            "MacBook",
            "Lenovo",
            "Dell",
            "Asus",
            "HP",
            "MSI"});
            this.cb2_hanglaptop.Location = new System.Drawing.Point(428, 192);
            this.cb2_hanglaptop.Name = "cb2_hanglaptop";
            this.cb2_hanglaptop.Size = new System.Drawing.Size(459, 36);
            this.cb2_hanglaptop.TabIndex = 45;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label19.Location = new System.Drawing.Point(462, 37);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(384, 32);
            this.label19.TabIndex = 27;
            this.label19.Text = "TÙY CHỈNH THÔNG TIN LAPTOP";
            // 
            // btn_updateLaptop
            // 
            this.btn_updateLaptop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_updateLaptop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_updateLaptop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_updateLaptop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_updateLaptop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btn_updateLaptop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_updateLaptop.ForeColor = System.Drawing.Color.White;
            this.btn_updateLaptop.Location = new System.Drawing.Point(824, 766);
            this.btn_updateLaptop.Name = "btn_updateLaptop";
            this.btn_updateLaptop.Size = new System.Drawing.Size(180, 45);
            this.btn_updateLaptop.TabIndex = 26;
            this.btn_updateLaptop.Text = "Sửa";
            this.btn_updateLaptop.Click += new System.EventHandler(this.btn_updateLaptop_Click);
            // 
            // btn_xoaLaptop
            // 
            this.btn_xoaLaptop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoaLaptop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoaLaptop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoaLaptop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xoaLaptop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btn_xoaLaptop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_xoaLaptop.ForeColor = System.Drawing.Color.White;
            this.btn_xoaLaptop.Location = new System.Drawing.Point(268, 766);
            this.btn_xoaLaptop.Name = "btn_xoaLaptop";
            this.btn_xoaLaptop.Size = new System.Drawing.Size(180, 45);
            this.btn_xoaLaptop.TabIndex = 26;
            this.btn_xoaLaptop.Text = "Xóa";
            this.btn_xoaLaptop.Click += new System.EventHandler(this.btn_xoaLaptop_Click);
            // 
            // btn_addLapTop
            // 
            this.btn_addLapTop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addLapTop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addLapTop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addLapTop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addLapTop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btn_addLapTop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_addLapTop.ForeColor = System.Drawing.Color.White;
            this.btn_addLapTop.Location = new System.Drawing.Point(538, 766);
            this.btn_addLapTop.Name = "btn_addLapTop";
            this.btn_addLapTop.Size = new System.Drawing.Size(180, 45);
            this.btn_addLapTop.TabIndex = 26;
            this.btn_addLapTop.Text = "Thêm";
            this.btn_addLapTop.Click += new System.EventHandler(this.btn_addLapTop_Click);
            // 
            // txt_Pin
            // 
            this.txt_Pin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Pin.DefaultText = "";
            this.txt_Pin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Pin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Pin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Pin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Pin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Pin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Pin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Pin.Location = new System.Drawing.Point(428, 686);
            this.txt_Pin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Pin.Name = "txt_Pin";
            this.txt_Pin.PasswordChar = '\0';
            this.txt_Pin.PlaceholderText = "";
            this.txt_Pin.SelectedText = "";
            this.txt_Pin.Size = new System.Drawing.Size(459, 42);
            this.txt_Pin.TabIndex = 25;
            // 
            // txt_QuaTangKem
            // 
            this.txt_QuaTangKem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QuaTangKem.DefaultText = "";
            this.txt_QuaTangKem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QuaTangKem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QuaTangKem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QuaTangKem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QuaTangKem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QuaTangKem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_QuaTangKem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QuaTangKem.Location = new System.Drawing.Point(428, 586);
            this.txt_QuaTangKem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_QuaTangKem.Name = "txt_QuaTangKem";
            this.txt_QuaTangKem.PasswordChar = '\0';
            this.txt_QuaTangKem.PlaceholderText = "";
            this.txt_QuaTangKem.SelectedText = "";
            this.txt_QuaTangKem.Size = new System.Drawing.Size(459, 42);
            this.txt_QuaTangKem.TabIndex = 24;
            // 
            // txt_CPU
            // 
            this.txt_CPU.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CPU.DefaultText = "";
            this.txt_CPU.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_CPU.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_CPU.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CPU.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CPU.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CPU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_CPU.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CPU.Location = new System.Drawing.Point(428, 636);
            this.txt_CPU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CPU.Name = "txt_CPU";
            this.txt_CPU.PasswordChar = '\0';
            this.txt_CPU.PlaceholderText = "";
            this.txt_CPU.SelectedText = "";
            this.txt_CPU.Size = new System.Drawing.Size(459, 42);
            this.txt_CPU.TabIndex = 23;
            // 
            // txt_GiaBanGoc
            // 
            this.txt_GiaBanGoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_GiaBanGoc.DefaultText = "";
            this.txt_GiaBanGoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_GiaBanGoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_GiaBanGoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_GiaBanGoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_GiaBanGoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_GiaBanGoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_GiaBanGoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_GiaBanGoc.Location = new System.Drawing.Point(428, 386);
            this.txt_GiaBanGoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_GiaBanGoc.Name = "txt_GiaBanGoc";
            this.txt_GiaBanGoc.PasswordChar = '\0';
            this.txt_GiaBanGoc.PlaceholderText = "";
            this.txt_GiaBanGoc.SelectedText = "";
            this.txt_GiaBanGoc.Size = new System.Drawing.Size(459, 42);
            this.txt_GiaBanGoc.TabIndex = 19;
            // 
            // txt_ThoiGianBaoHanh
            // 
            this.txt_ThoiGianBaoHanh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ThoiGianBaoHanh.DefaultText = "";
            this.txt_ThoiGianBaoHanh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ThoiGianBaoHanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ThoiGianBaoHanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ThoiGianBaoHanh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ThoiGianBaoHanh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ThoiGianBaoHanh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ThoiGianBaoHanh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ThoiGianBaoHanh.Location = new System.Drawing.Point(428, 336);
            this.txt_ThoiGianBaoHanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ThoiGianBaoHanh.Name = "txt_ThoiGianBaoHanh";
            this.txt_ThoiGianBaoHanh.PasswordChar = '\0';
            this.txt_ThoiGianBaoHanh.PlaceholderText = "";
            this.txt_ThoiGianBaoHanh.SelectedText = "";
            this.txt_ThoiGianBaoHanh.Size = new System.Drawing.Size(459, 42);
            this.txt_ThoiGianBaoHanh.TabIndex = 18;
            // 
            // txt_KhoiLuong
            // 
            this.txt_KhoiLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_KhoiLuong.DefaultText = "";
            this.txt_KhoiLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_KhoiLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_KhoiLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_KhoiLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_KhoiLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_KhoiLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_KhoiLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_KhoiLuong.Location = new System.Drawing.Point(428, 286);
            this.txt_KhoiLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_KhoiLuong.Name = "txt_KhoiLuong";
            this.txt_KhoiLuong.PasswordChar = '\0';
            this.txt_KhoiLuong.PlaceholderText = "";
            this.txt_KhoiLuong.SelectedText = "";
            this.txt_KhoiLuong.Size = new System.Drawing.Size(459, 42);
            this.txt_KhoiLuong.TabIndex = 17;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SoLuong.DefaultText = "";
            this.txt_SoLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SoLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SoLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SoLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SoLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SoLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SoLuong.Location = new System.Drawing.Point(428, 236);
            this.txt_SoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.PasswordChar = '\0';
            this.txt_SoLuong.PlaceholderText = "";
            this.txt_SoLuong.SelectedText = "";
            this.txt_SoLuong.Size = new System.Drawing.Size(459, 42);
            this.txt_SoLuong.TabIndex = 16;
            // 
            // txt_TenLT
            // 
            this.txt_TenLT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenLT.DefaultText = "";
            this.txt_TenLT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TenLT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TenLT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenLT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenLT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenLT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TenLT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenLT.Location = new System.Drawing.Point(428, 136);
            this.txt_TenLT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TenLT.Name = "txt_TenLT";
            this.txt_TenLT.PasswordChar = '\0';
            this.txt_TenLT.PlaceholderText = "";
            this.txt_TenLT.SelectedText = "";
            this.txt_TenLT.Size = new System.Drawing.Size(459, 42);
            this.txt_TenLT.TabIndex = 14;
            // 
            // txt_MaLT
            // 
            this.txt_MaLT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaLT.DefaultText = "";
            this.txt_MaLT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MaLT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MaLT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaLT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaLT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaLT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaLT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaLT.Location = new System.Drawing.Point(428, 86);
            this.txt_MaLT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MaLT.Name = "txt_MaLT";
            this.txt_MaLT.PasswordChar = '\0';
            this.txt_MaLT.PlaceholderText = "";
            this.txt_MaLT.SelectedText = "";
            this.txt_MaLT.Size = new System.Drawing.Size(459, 42);
            this.txt_MaLT.TabIndex = 13;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label18.Location = new System.Drawing.Point(173, 700);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 28);
            this.label18.TabIndex = 12;
            this.label18.Text = "Pin";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label17.Location = new System.Drawing.Point(173, 650);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(144, 28);
            this.label17.TabIndex = 11;
            this.label17.Text = "Quà Tặng Kèm";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label16.Location = new System.Drawing.Point(173, 601);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 28);
            this.label16.TabIndex = 10;
            this.label16.Text = "CPU";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label15.Location = new System.Drawing.Point(173, 550);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 28);
            this.label15.TabIndex = 9;
            this.label15.Text = "Màn Hình";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label14.Location = new System.Drawing.Point(173, 500);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(190, 28);
            this.label14.TabIndex = 8;
            this.label14.Text = "Dung Lượng Bộ Nhớ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label13.Location = new System.Drawing.Point(173, 450);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 28);
            this.label13.TabIndex = 7;
            this.label13.Text = "Màu Sắc";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label12.Location = new System.Drawing.Point(173, 400);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 28);
            this.label12.TabIndex = 6;
            this.label12.Text = "Giá Bán Gốc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label11.Location = new System.Drawing.Point(173, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 28);
            this.label11.TabIndex = 5;
            this.label11.Text = "Thời Gian Bảo Hành";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label10.Location = new System.Drawing.Point(173, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 28);
            this.label10.TabIndex = 4;
            this.label10.Text = "Khối Lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(173, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 28);
            this.label9.TabIndex = 3;
            this.label9.Text = "Số Lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(173, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tên Hãng Laptop";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(173, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên Laptop";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(173, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã Laptop";
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
            this.btn_close.Location = new System.Drawing.Point(1203, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(58, 34);
            this.btn_close.TabIndex = 51;
            this.btn_close.Text = "X";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form_Laptop
            // 
            this.ClientSize = new System.Drawing.Size(1385, 892);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Laptop";
            this.Load += new System.EventHandler(this.Form_Laptop_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Laptop)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Laptop;
        private Guna.UI2.WinForms.Guna2Button btn_TimKiem_Laptop;
        private Guna.UI2.WinForms.Guna2Button btn_Add_Laptop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHangLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhoiLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBaoHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBanGoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mausac;
        private System.Windows.Forms.DataGridViewTextBoxColumn DungLuongBoNho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pin;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuaTangKem;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2TextBox txt_Pin;
        private Guna.UI2.WinForms.Guna2TextBox txt_QuaTangKem;
        private Guna.UI2.WinForms.Guna2TextBox txt_CPU;
        private Guna.UI2.WinForms.Guna2TextBox txt_GiaBanGoc;
        private Guna.UI2.WinForms.Guna2TextBox txt_ThoiGianBaoHanh;
        private Guna.UI2.WinForms.Guna2TextBox txt_KhoiLuong;
        private Guna.UI2.WinForms.Guna2TextBox txt_SoLuong;
        private Guna.UI2.WinForms.Guna2TextBox txt_TenLT;
        private Guna.UI2.WinForms.Guna2TextBox txt_MaLT;
        private Guna.UI2.WinForms.Guna2Button btn_addLapTop;
        private System.Windows.Forms.Label label19;
        private Guna.UI2.WinForms.Guna2Button btn_updateLaptop;
        private Guna.UI2.WinForms.Guna2Button btn_xoaLaptop;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label20;
        private Guna.UI2.WinForms.Guna2ComboBox cb1_HangLaptop;
        private Guna.UI2.WinForms.Guna2ComboBox cb_giaMax;
        private Guna.UI2.WinForms.Guna2ComboBox cb1_KichThuocManHinh;
        private Guna.UI2.WinForms.Guna2ComboBox cb1_mausac;
        private Guna.UI2.WinForms.Guna2ComboBox cb1_dungluong;
        private Guna.UI2.WinForms.Guna2ComboBox cb2_hanglaptop;
        private Guna.UI2.WinForms.Guna2ComboBox cb2_mausac;
        private Guna.UI2.WinForms.Guna2ComboBox cb2_dungluong;
        private Guna.UI2.WinForms.Guna2ComboBox cb2_manhinh;
        private Guna.UI2.WinForms.Guna2Button btn_close;
    }
}