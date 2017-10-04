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
        private Book_BS book_bs;

        private void Init() {
            // In danh sach category
            this.category_bs = new Category_BS();
            List<string> category_list = this.category_bs.get_category();
            this.CategoryList.DataSource = category_list;

            //In toan bo sach
            this.book_bs = new Book_BS();
            DataTable book_data = this.book_bs.get_all_book();
            this.BookTable.DataSource = book_data;

        } // Khoi tao du lieu
        
        public BookForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.Init();  
        }
    }
}
