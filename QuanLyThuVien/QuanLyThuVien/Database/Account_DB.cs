using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyThuVien.Helper;

namespace QuanLyThuVien.Database
{
    class Account_DB
    {
        private Database_Helper db_helper; // Bien ket noi database

        public Account_DB() {
            this.db_helper = new Database_Helper();
        }

        public bool existed_username(string username) {
            string sql = String.Format("select dbo.ExistedUsername('{0}')", username);

            return this.db_helper.execScalar(sql);
        } // Kiem tra username co ton tai hay chua (True la roi, false la chua)

        public DataTable get_user_info(string username) {
            DataTable data = new DataTable();

            string sql = String.Format("exec get_user_info '{0}'", username);

            data = this.db_helper.readdata(sql);

            return data;
        } // Lay thong tin nguoi dung theo ten 

        public bool sign_up(string username, string pass, string email) {
            //string sql = ;

            string sql = String.Format("exec insert_account '{0}', '{1}' , '{2}'", username, pass, email);

            return this.db_helper.writedata(sql);
        } // Ham sign up 
    }
}
