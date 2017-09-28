using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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

        public Dictionary<string, object> sign_in(string username, string password) {
            DataTable data = this.account_db.get_user_info(username); // Lay thong tin 

            if (data.Rows.Count != 1)
            {
                //Neu rows tra ve khac 1 tuc la khong co tai khoan
                this.return_data.Add("Success", false);
                this.return_data.Add("Error", "Ten tai khoan khong ton tai");
                return this.return_data;
            }
            else {
                string pass_in_db =(string) data.Rows[0]["pass"]; // Lay password luu trong db

                if (password != pass_in_db)
                {
                    //Neu password khong trung khop
                    this.return_data.Add("Success", false);
                    this.return_data.Add("Error", "Mat khau khong dung");
                    return this.return_data;
                }
                else {
                    this.return_data.Add("Success", true);
                    return this.return_data;
                } // Mat khau chinh xac
            } // Neu ten tai khoan ton tai
        } // Function sign in
    }
}
