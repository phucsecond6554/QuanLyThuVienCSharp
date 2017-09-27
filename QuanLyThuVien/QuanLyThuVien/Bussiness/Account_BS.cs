using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.Database;

namespace QuanLyThuVien.Bussiness
{
    class Account_BS
    {
        private Dictionary<string, object> return_data;
        private Account_DB account_db;

        public Account_BS() {
            this.return_data = new Dictionary<string, object>();
            this.account_db = new Account_DB();
        }

        public Dictionary<string, object> sign_up(string username, string password, string email) {
            if (this.account_db.existed_username(username))
            {
                // Neu user name da ton tai
                this.return_data.Add("Success", false); // Khong thanh cong
                this.return_data.Add("Error", "Ten tai khoan da ton tai");

                return this.return_data;
            }
            else { // Nguoc lai username chua ton tai
                if (this.account_db.sign_up(username, password, email)) {
                    this.return_data.Add("Success", true); // Thanh cong
                    return this.return_data;
                }
            }

            this.return_data.Add("Success", false);
            return this.return_data;
        } // Function signup
    }
}
