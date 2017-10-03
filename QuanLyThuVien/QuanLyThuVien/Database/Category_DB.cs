using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyThuVien.Helper;

namespace QuanLyThuVien.Database
{
    class Category_DB
    {
        private Database_Helper db_helper;

        public Category_DB() {
            this.db_helper = new Database_Helper();
        }

        public DataTable get_category() {
            DataTable data = new DataTable();

            string sql = "exec get_category";

            data = this.db_helper.readdata(sql);

            return data;
        } // Lay toan bo category
    }
}
