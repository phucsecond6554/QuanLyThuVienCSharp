using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.Helper;

namespace QuanLyThuVien
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Thiet lap form cha chua form con
            UserData.Text = (string)Variable_Helper.get("Username"); // Dien thong tin nguoi dung
            CareerData.Text = (string)Variable_Helper.get("Permission");
        }

        private void SignoutBtn_Click(object sender, EventArgs e)
        {
            // Thuc hien dang xuat
            this.Hide();
            SigninForm signin_form = new SigninForm();
            signin_form.ShowDialog();

            Variable_Helper.clear_all(); // Xoa tat ca bien chung
            this.Close();
        }// Nut sign out

        private void BookBtn_Click(object sender, EventArgs e)
        {
            string formname = "BookForm";

            if (this.checkExistedForm(formname))
            {
                this.ActivateForm(formname);
            }
            else {
                BookForm bookform = new BookForm();
                bookform.MdiParent = this;
                bookform.Show();
            }           
        } 

        private bool checkExistedForm(string formname){
            bool check = false;
            foreach (Form form in this.MdiChildren) {
                if (form.Name == formname) {
                    check = true;
                    break;
                }
            }

            return check;
        } // Kiem tra form da mo chua (true la roi, false la chua)

        private void ActivateForm(string formname)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == formname)
                {
                    form.Activate();
                    break;
                }
            }
        } // Dung de hien thi form con len tren
    }
}
