using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUSSACH
    {
        dataBookStore db = new dataBookStore();
        public IEnumerable<CHITIETSACH> DSSACH()
        {
            var dss = from sach in db.SACHes
                      select new CHITIETSACH
                      { 
                      SACH = sach,
                      NHAXUATBAN = sach.NHAXUATBAN,
                      TACGIA = sach.TACGIA,
                      THELOAI = sach.THELOAI,
                      };
            return dss;

        }

    }
}
