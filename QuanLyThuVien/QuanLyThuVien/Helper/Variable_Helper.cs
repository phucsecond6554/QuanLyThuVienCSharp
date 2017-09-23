using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Helper
{
    class Variable_Helper
    {
        private static Dictionary<string, int> number = new Dictionary<string,int>(); // Luu bien so
        private static Dictionary<string, string> str = new Dictionary<string,string>(); // Luu bien chuoi

        public static void set_number(string key, int val) {
            number.Add(key, val);
        }

        public static int get_number(string key) {
            return number[key];
        }

        public static void set_string(string key, string val) {
            str.Add(key, val);
        }

        public static string get_string(string key) {
            return str[key];
        }
    }
}
