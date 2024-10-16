using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSTAIKHOAN
    {
        dataBookStore db=  new dataBookStore();
        public IEnumerable<TAIKHOAN> DSTAIKHOAN()
        {
            var dstk = from tk in db.TAIKHOANs
                      select tk;
            return dstk;
        }
        public bool kiemTraDangNhap(string username, string password)
        {
            foreach (var tk in db.TAIKHOANs)
            {
                if (tk.USERNAME == username && tk.PASSWORD == password)
                    return true;
            }
            return false;
        }
    }
}
