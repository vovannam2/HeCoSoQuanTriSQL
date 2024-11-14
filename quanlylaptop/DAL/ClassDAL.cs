using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlylaptop.DAL
{
    public class ClassDAL
    {
        MyConnect myconn = new MyConnect(Properties.Settings.Default.IsAdmin);
        //Read Items to Table
        public DataTable LoadDatas(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, myconn.getConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }

        public void loadData(String query , DataGridView dgv)
        {
            DataTable data = LoadDatas(query);
            dgv.Rows.Clear();
            foreach (DataRow row in data.Rows)
            {
                dgv.Rows.Add(row.ItemArray);
            }
        }
        public void ThucThi(string sql)
        {
            DialogResult result = MessageBox.Show(
               "Bạn có chắc chắn muốn xóa không?",
               "Xác nhận xóa",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            // Nếu người dùng chọn "No", dừng thực hiện
            if (result == DialogResult.No)
            {
                return;
            }
            // Tạo đối tượng MyConnect
            MyConnect myconn = new MyConnect(Properties.Settings.Default.IsAdmin); // Thay đổi nếu cần quyền admin

            // Lấy đối tượng SqlConnection từ MyConnect
            SqlConnection con = myconn.getConnection;

            try
            {
                // Mở kết nối
                myconn.openConnection(con);

                // Tạo SqlCommand và thực thi
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Xóa thành công !", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                // Hiển thị thông báo lỗi chi tiết
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                // Đóng kết nối
                myconn.closeConnection(con);
            }
        }
        public void loadDataWithStoredProcedure(string procedureName, string paramName, object paramValue, DataGridView dgv)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-OQ5HTD48;Initial Catalog=QuanLyLapTop2;Integrated Security=True"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(procedureName, conn);
                    cmd.CommandType = CommandType.StoredProcedure;  // Chỉ định đây là stored procedure

                    // Thêm tham số và giá trị cho stored procedure
                    cmd.Parameters.AddWithValue(paramName, paramValue);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Ràng buộc DataTable vào DataGridView
                    dgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            
        }


    }
}
