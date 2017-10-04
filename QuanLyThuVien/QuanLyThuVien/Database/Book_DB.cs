using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyThuVien.Helper;

namespace QuanLyThuVien.Database
{
    class Book_DB
    {
        private Database_Helper db_helper;

        public Book_DB() {
            this.db_helper = new Database_Helper();
        }

        public DataTable get_all_book() {
            string sql = "exec get_all_book";

            return this.db_helper.readdata(sql);
        }
    }
}
