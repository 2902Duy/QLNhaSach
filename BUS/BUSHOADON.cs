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

        public void themHD(string name, DateTime date)
        {
            try
            {
                var id = db.HOADONs.Max(s => s.IDHOADON);
                string maHD = "HD0" + (id + 1);
                HOADON hd = new HOADON
                {
                    IDHOADON = id,
                    MAHOADON = maHD,
                    KHACHHANG = name,
                    NGAYLAP = date,
                };
                db.HOADONs.Add(hd);
                db.SaveChanges();
            }
            catch (Exception ex) { }
        }

    }
}
