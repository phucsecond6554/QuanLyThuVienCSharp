using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyThuVien.Helper
{
    class Database_Helper
    {
        private SqlConnection connection;

        public Database_Helper() {
            string connect_cmd = "Data Source=ThanhPhuc;Initial Catalog=Quanlythuvien;User ID=sa;Password=123456";
            this.connection = new SqlConnection(connect_cmd);
        }

        public void open_connect() {
            if (this.connection.State == ConnectionState.Closed) { // Neu ket noi dang dong
                try
                {
                    this.connection.Open();
                }
                catch (Exception ex) { 
                    
                } // Thu mo ket noi csdl
            }
        } // Ham mo ket noi csdl

        public void close_connect() {
            if (this.connection.State == ConnectionState.Open) {
                this.connection.Close();
            }
        } // Ham dong ket noi csdl

        public bool writedata(string sql) {
            bool check = false;
            this.open_connect();

            try
            {
                SqlCommand command = new SqlCommand(sql, this.connection);
                command.ExecuteNonQuery();
                check = true;
            }
            catch (Exception ex) {
                check = false;
            }
            close_connect();
            return check;
        } // Ham writedata de ghi du lieu len csdl

        public DataTable readdata(string sql) {
            this.open_connect();
            DataTable datatable = new DataTable();

            try
            {
                SqlCommand command = new SqlCommand(sql, this.connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(datatable);

            }
            catch (Exception ex) {
                datatable = null;
            }
            this.close_connect();

            return datatable;
        } // Ham doc du lieu
    }
}
