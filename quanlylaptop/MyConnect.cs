using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace quanlylaptop
{
    class MyConnect
    {

        private string connectionString;

        public MyConnect(bool isAdmin = false)
        {
            if (isAdmin)
            {
                // Kết nối với quyền admin
                connectionString = @"Data Source=LAPTOP-OQ5HTD48;Initial Catalog=QuanLyLapTop2;Integrated Security=True";
            }
            else
            {
                // Kết nối với quyền employee
                connectionString = @"Data Source=LAPTOP-OQ5HTD48;Initial Catalog=QuanLyLapTop2;User ID=emp1;Password=123";
            }

        }
        public SqlConnection getConnection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }

        //Mở kết nối
        public void openConnection(SqlConnection con)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void closeConnection(SqlConnection con)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

    }
}



