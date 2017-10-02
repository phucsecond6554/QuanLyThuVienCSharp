using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Helper
{
    class Variable_Helper
    {
        private static Dictionary<string, object> variable = new Dictionary<string,object>();

        public static void set(string key, object val) {
            variable.Add(key, val);
        }

        public static void update(string key, object val) {
            variable[key] = val;
        }

        public static object get(string key) {
            return variable[key];
        }

        public static void remove(string key) {
            variable.Remove(key);
        }

        public static void clear_all() {
            variable.Clear();
        }
    }
}
