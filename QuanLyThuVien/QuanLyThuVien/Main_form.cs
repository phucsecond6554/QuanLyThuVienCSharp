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
            string username = (string)Variable_Helper.get("Username");
            string permission = (string)Variable_Helper.get("Permission");
            string table = (string)Variable_Helper.get("Permission_table");


            Username.Text = username;
            Chucvu.Text = permission;
            permssion.Text = table;
        }
    }
}
