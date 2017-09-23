using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
        }// Event khi click vao nut dang nhap
    }
}
