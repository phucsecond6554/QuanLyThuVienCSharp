using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyThuVien.Database;

namespace QuanLyThuVien.Bussiness
{
    class Category_BS
    {
        private Dictionary<string, object> return_data;
        private Category_DB category_db;

        public Category_BS() {
            this.return_data = new Dictionary<string, object>();
            this.category_db = new Category_DB();
        }

        public List<string> get_category() {
            DataTable data = this.category_db.get_category();
            List<string> category_list = new List<string>();

            foreach (DataRow row in data.Rows) {
                category_list.Add(row["category"].ToString());
            }

            category_list.Add("Tat ca");

            return category_list;
        }
    }
}
