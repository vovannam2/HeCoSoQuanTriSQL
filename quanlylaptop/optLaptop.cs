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
using System.Windows.Controls;
using System.Windows.Forms;

namespace quanlylaptop
{
    public partial class optLaptop : Form
    {
        public string maNK1;
        bool isNK;
        public optLaptop(string ma, bool isNK)
        {
            maNK1 = ma;
            InitializeComponent();
            this.isNK = isNK;
        }
        MyConnect myconn = new MyConnect(Properties.Settings.Default.IsAdmin);
        ClassDAL classDAL = new ClassDAL();

        private void optLaptop_Load(object sender, EventArgs e)
        {
            classDAL.loadData("select * from v_infLaptopNhap", dgv_Laptop);
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                HeaderText = "Chọn",
                Width = 50,
                Name = "CheckBoxColumn"
            };
            dgv_Laptop.Columns.Insert(0, checkBoxColumn);
            if (isNK==false)
            {
                DataGridViewTextBoxColumn Khuyenmai = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Khuyến mãi",
                    Width = 50,
                    Name = "KhuyenMai",
                    //AutoSizeMode = DataGridViewAutoSizeColumnMode.None // Không tự động điều chỉnh kích thước
                };

                // Thêm cột vào DataGridView
                dgv_Laptop.Columns.Insert(6,Khuyenmai);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form hiện tại
        }

        private void dgv_Laptop_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Laptop.Columns[e.ColumnIndex].Name == "KhuyenMai")
            {
                int rowIndex = e.RowIndex;
                // Lấy các giá trị từ dòng hiện tại (Số lượng, Đơn giá, Thuế VAT và Khuyến mãi)
                if (int.TryParse(dgv_Laptop.Rows[rowIndex].Cells["SoLuong"].Value?.ToString(), out int quantity) &&
                    int.TryParse(dgv_Laptop.Rows[rowIndex].Cells["DonGia"].Value?.ToString(), out int unitPrice) &&
                    double.TryParse(dgv_Laptop.Rows[rowIndex].Cells["ThueVat"].Value?.ToString(), out double vat) &&
                    double.TryParse(dgv_Laptop.Rows[rowIndex].Cells["KhuyenMai"].Value?.ToString(), out double discount))
                {
                    // Tính lại tổng tiền dựa trên công thức khuyến mãi
                    double totalPrice = (quantity * unitPrice) * (1 + vat / 100) * (1 - discount / 100);


                    // Cập nhật cột "Tổng tiền" của dòng hiện tại
                    dgv_Laptop.Rows[rowIndex].Cells["Tongtien"].Value = totalPrice;
                }
                else
                {
                    // Nếu giá trị không hợp lệ, đặt tổng tiền là 0 hoặc thông báo lỗi
                    dgv_Laptop.Rows[rowIndex].Cells["Tongtien"].Value = 0;
                }


            }
                // Kiểm tra xem ô được chỉnh sửa có phải là cột "Số lượng" không
            if (dgv_Laptop.Columns[e.ColumnIndex].Name == "SoLuong" && isNK==true) // Giả sử cột "Số lượng" có tên là QuantityColumn
            {
                int rowIndex = e.RowIndex;

                // Lấy số lượng và đơn giá từ dòng hiện tại
                if (int.TryParse(dgv_Laptop.Rows[rowIndex].Cells["SoLuong"].Value?.ToString(), out int quantity) &&
                    int.TryParse(dgv_Laptop.Rows[rowIndex].Cells["DonGia"].Value?.ToString(), out int unitPrice) &&
                    double.TryParse(dgv_Laptop.Rows[rowIndex].Cells["ThueVat"].Value?.ToString(), out double vat))
                {
                    // Gọi hàm SQL để tính tổng tiền
                    int totalPrice = CalculateTotalPriceFromSql(quantity, unitPrice,vat);

                    // Hiển thị kết quả vào cột "Tổng tiền"
                    dgv_Laptop.Rows[rowIndex].Cells["Tongtien"].Value = totalPrice;
                }
                else
                {
                    // Nếu giá trị không hợp lệ, đặt tổng tiền là 0 hoặc thông báo lỗi
                    dgv_Laptop.Rows[rowIndex].Cells["Tongtien"].Value = 0;
                }
            }
        }
        // Hàm gọi SQL function để tính tổng tiền
        private int CalculateTotalPriceFromSql(int quantity, int unitPrice, double vat)
        {
            SqlConnection con = myconn.getConnection;
            myconn.openConnection(con);
            using (SqlCommand command = new SqlCommand("SELECT dbo.CalculateTotalPrice(@Quantity, @UnitPrice,@Vat)", con))
            {
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@UnitPrice", unitPrice);
                command.Parameters.AddWithValue("@Vat", vat);
                
              
                try
                {
                   // myconn.openConnection(con);
                    // Thực thi lệnh SQL và lấy kết quả
                    return (int)command.ExecuteScalar();
                }
                finally
                {
                    // Đảm bảo kết nối luôn được đóng sau khi hoàn tất
                    myconn.closeConnection(con);
                }
            }
           
            
        }

        private void btn_chon_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn lưu các sản phẩm được chọn vào phiếu nhập?",
                                                  "Xác nhận lưu",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            // Nếu người dùng chọn "Yes"
            if (result == DialogResult.Yes)
            {
                
                SqlConnection con = myconn.getConnection;
                myconn.openConnection(con);
                bool isSuccess = true; // Biến để theo dõi trạng thái thành công
                List<string> errorMessages = new List<string>(); // Danh sách lưu thông báo lỗi
                if(isNK == true)
                {
                    foreach (DataGridViewRow row in dgv_Laptop.Rows)
                    {
                        // Kiểm tra nếu checkbox được chọn
                        if (Convert.ToBoolean(row.Cells["CheckBoxColumn"].Value) == true)
                        {
                            string maLT = row.Cells["MaLT"].Value.ToString();
                            string maNK = maNK1; // Đảm bảo `maNK1` đã được khai báo và có giá trị trước
                            int soLuongSP = Convert.ToInt32(row.Cells["SoLuong"].Value); // Lấy số lượng từ ô nhập
                            int giaNhap = Convert.ToInt32(row.Cells["DonGia"].Value);
                            int thueVAT = Convert.ToInt32(row.Cells["ThueVat"].Value); // Chuyển thành `int` nếu lưu VAT là phần trăm
                            int thanhTien = Convert.ToInt32(row.Cells["Tongtien"].Value);

                            try
                            {
                                SqlCommand cmd = new SqlCommand("ThemChiTietPhieuNhap", con);
                                cmd.CommandType = CommandType.StoredProcedure;

                                // Thêm tham số vào thủ tục
                                cmd.Parameters.Add("@MaLT", SqlDbType.NVarChar).Value = maLT;
                                cmd.Parameters.Add("@MaNK", SqlDbType.NVarChar).Value = maNK;
                                cmd.Parameters.Add("@SoLuongSP", SqlDbType.Int).Value = soLuongSP;
                                cmd.Parameters.Add("@GiaNhapTungSP", SqlDbType.Int).Value = giaNhap;
                                cmd.Parameters.Add("@ThueVAT", SqlDbType.Int).Value = thueVAT;
                                cmd.Parameters.Add("@ThanhTienTungSP", SqlDbType.Int).Value = thanhTien;

                                // Thực thi thủ tục
                                cmd.ExecuteNonQuery();
                            }
                            catch (SqlException ex) // Bắt lỗi SqlException
                            {
                                isSuccess = false; // Đánh dấu rằng có lỗi
                                errorMessages.Add($"Thêm chi tiết cho sản phẩm {maLT} thất bại: {ex.Message}");
                            }
                        }
                    }

                    // Đóng kết nối
                    myconn.closeConnection(con);

                    // Hiển thị thông báo tổng quát
                    if (isSuccess)
                    {
                        MessageBox.Show("Thêm tất cả chi tiết phiếu nhập thành công!", "Add Invoice Detail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Nếu có lỗi, hiển thị tất cả các lỗi
                        MessageBox.Show(string.Join(Environment.NewLine, errorMessages), "Add Invoice Detail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dgv_Laptop.Rows)
                    {
                        // Kiểm tra nếu checkbox được chọn
                        if (Convert.ToBoolean(row.Cells["CheckBoxColumn"].Value) == true)
                        {
                            string maLT = row.Cells["MaLT"].Value.ToString();
                            string maHD = maNK1; // Đảm bảo `maNK1` đã được khai báo và có giá trị trước
                            int soLuongSP = Convert.ToInt32(row.Cells["SoLuong"].Value); // Lấy số lượng từ ô nhập
                            int giaban = Convert.ToInt32(row.Cells["DonGia"].Value);
                            int thueVAT = Convert.ToInt32(row.Cells["ThueVat"].Value); // Chuyển thành `int` nếu lưu VAT là phần trăm
                            int Khuyenmai = Convert.ToInt32(row.Cells["KhuyenMai"].Value); // Chuyển thành `int` nếu lưu VAT là phần trăm
                            int thanhTien = Convert.ToInt32(row.Cells["Tongtien"].Value);

                            try
                            {
                                SqlCommand cmd = new SqlCommand("ThemChiTietHoaDon", con);
                                cmd.CommandType = CommandType.StoredProcedure;

                                // Thêm tham số vào thủ tục
                                cmd.Parameters.Add("@MaLT", SqlDbType.NVarChar).Value = maLT;
                                cmd.Parameters.Add("@MaHD", SqlDbType.NVarChar).Value = maHD;
                                cmd.Parameters.Add("@SoLuongSP", SqlDbType.Int).Value = soLuongSP;
                                cmd.Parameters.Add("@GiaBanTungSP", SqlDbType.Int).Value = giaban;
                                cmd.Parameters.Add("@KhuyenMai", SqlDbType.Int).Value = Khuyenmai;
                                cmd.Parameters.Add("@ThueVAT", SqlDbType.Int).Value = thueVAT;
                                cmd.Parameters.Add("@ThanhTienSauthue", SqlDbType.Int).Value = thanhTien;

                                // Thực thi thủ tục
                                cmd.ExecuteNonQuery();
                            }
                            catch (SqlException ex) // Bắt lỗi SqlException
                            {
                                isSuccess = false; // Đánh dấu rằng có lỗi
                                errorMessages.Add($"Thêm chi tiết cho sản phẩm {maLT} thất bại: {ex.Message}");
                            }
                        }
                    }

                    // Đóng kết nối
                    myconn.closeConnection(con);

                    // Hiển thị thông báo tổng quát
                    if (isSuccess)
                    {
                        MessageBox.Show("Thêm tất cả chi tiết phiếu nhập thành công!", "Add Invoice Detail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Nếu có lỗi, hiển thị tất cả các lỗi
                        MessageBox.Show(string.Join(Environment.NewLine, errorMessages), "Add Invoice Detail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                
            }
            else
            {
                // Nếu người dùng chọn "No"
                MessageBox.Show("Dữ liệu không được lưu.");
            }
        }
    }
}
