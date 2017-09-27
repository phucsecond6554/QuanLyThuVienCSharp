using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.Bussiness;

namespace QuanLyThuVien
{
    public partial class SignUpForm : Form
    {
        private Account_BS account_bs;
        public SignUpForm()
        {
            InitializeComponent();

            this.account_bs = new Account_BS();
        }

        private bool check_form() {
            bool check = false;

            if (Username.Text != "" && Pass.Text != "" && PassConf.Text != "" && Email.Text != "" && Pass.Text == PassConf.Text) { 
                check = true;
            }

            return check;
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            if (this.check_form()) // Neu form hop le
            {
                string username = Username.Text;
                string pass = Pass.Text;
                string email = Email.Text;
                Dictionary<string, object> return_data = this.account_bs.sign_up(username, pass, email);

                if ((bool)return_data["Success"])
                { // Neu dang ky thanh cong
                    MessageBox.Show("Dang ky thanh cong", "Success");
                }
                else {
                    MessageBox.Show((string)return_data["Error"], "Error");
                }
            }
            else {
                MessageBox.Show("Thong tin khong hop le", "Error");
            } // Form khong hop le
        }
    }
}
