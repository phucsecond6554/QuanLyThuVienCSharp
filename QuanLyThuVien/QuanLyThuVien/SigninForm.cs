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
    public partial class SigninForm : Form
    {
        public SigninForm()
        {
            InitializeComponent();
        }

        private bool checkform() {
            bool check = false;

            if (UserName.Text != "" && Password.Text != "")
            {
                // Neu khung dang nhap da duoc dien day du
                check = true;
            }
            else {
                MessageBox.Show("Dien day du thong tin", "Error");
                check = false;
            }

            return check;
        }// Ham nay dung de kiem tra form nhap vao co hop le  

        private void SigninBtn_Click(object sender, EventArgs e)
        {
            if (this.checkform()) {
                string username = UserName.Text;
                string pass = Password.Text;

                Account_BS account_bs = new Account_BS();

                Dictionary<string, object> return_data = account_bs.sign_in(username, pass); // Dang nhap

                if ((bool)return_data["Success"])
                {
                    MessageBox.Show("Dang nhap thanh cong", "Success");
                }
                else
                {
                    MessageBox.Show((string)return_data["Error"], "Error");
                }
            }
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm signup_form = new SignUpForm();
            signup_form.ShowDialog();
            this.Close();
                        
        }// Event khi click vao nut dang nhap
    }
}
