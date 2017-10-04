using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.Helper;

namespace QuanLyThuVien.Database
{
    class Bill_DB
    {
        private Database_Helper data_helper;

        public Bill_DB() {
            this.data_helper = new Database_Helper();
        }

        public bool create_bill(string id) {
            string sql = String.Format("exec insert_borrow_bill {0}", id);

            return this.data_helper.writedata(sql);
        } // Tao ra mot hoa don moi
    }
}
