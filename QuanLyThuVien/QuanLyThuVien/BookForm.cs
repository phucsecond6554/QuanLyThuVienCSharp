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
    public partial class BookForm : Form
    {
        private Category_BS category_bs;
        public BookForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;

            this.category_bs = new Category_BS();

            List<string> category_list = this.category_bs.get_category();

            this.CategoryList.DataSource = category_list;
        }
    }
}
