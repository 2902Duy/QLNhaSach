using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DANGNHAPBUS
    {
        dataBookStore db=  new dataBookStore();
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
