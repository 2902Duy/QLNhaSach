using DAL;
using System;
using System.Collections.Generic;
using System.Data.Common;
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
        public bool kiemTraTaiKhoan(string username)
        {
           foreach(var tk in db.TAIKHOANs)
            {
                if(tk.USERNAME==username)
                    return true;
            }
           return false;
        }
        public void themTaiKhoan(string username, string password) 
        {
            TAIKHOAN tk = new TAIKHOAN 
            {
                USERNAME = username,
                PASSWORD = password 
            };
            db.TAIKHOANs.Add(tk);
            db.SaveChanges();
        }
        public void xoaTaiKhoan(string username)
        {
            TAIKHOAN tk=db.TAIKHOANs.Find(username);
            db.TAIKHOANs.Remove(tk);
            db.SaveChanges();

        }

        public void doiMatKhau(string username, string password)
        {
            TAIKHOAN tk = db.TAIKHOANs.Find(username);
            tk.PASSWORD = password;
            db.SaveChanges();
        }
    }
}
