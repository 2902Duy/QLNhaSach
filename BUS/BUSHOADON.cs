using DAL;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSHOADON
    {
        dataBookStore db= new dataBookStore();
        
        public IEnumerable<CHITIETHOADON> dachSachHoaDon()
        {
            var dshd = from hd in db.CHITIETHOADONs
                       select hd;

            return dshd;
        }

        public IEnumerable<CHITIETHOADON> timkiemtheolich(DateTime NBD,DateTime NKT)
        {
        var dstn = from hd in db.CHITIETHOADONs
                   where hd.HOADON.NGAYLAP >NBD && hd.HOADON.NGAYLAP < NKT
                   select hd;
            return dstn;
        }

    }
}
