using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyThuVien.Database;

namespace QuanLyThuVien.Bussiness
{
    class Book_BS
    {
        private Dictionary<string, object> return_data;
        private Book_DB book_db;

        public Book_BS() {
            this.return_data = new Dictionary<string, object>();
            this.book_db = new Book_DB();
        }

        public DataTable get_all_book() {
            return this.book_db.get_all_book();
        }
    }
}
