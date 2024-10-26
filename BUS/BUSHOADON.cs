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

        public HOADON themHD( DateTime date)
        {
            
                var id = db.HOADONs.Max(s => s.IDHOADON)+1;
                string maHD = "HD0"+id;
                HOADON hd = new HOADON
                {
                    IDHOADON = id,
                    MAHOADON = maHD,
                    NGAYLAP = date,
                };
                db.HOADONs.Add(hd);
                db.SaveChanges();
                return hd;
        }
        public HOADON TimHD(string mahd)
        {
            return db.HOADONs.Find(mahd);
        }

        public void themcthd(CHITIETHOADON ct)
        {
            db.CHITIETHOADONs.Add(ct);
            db.SaveChanges();
        }
        public void tongtienhd(int sumMoney,string mahd)
        {
            var hd = db.HOADONs.Find(mahd);
            hd.TONGTIEN = sumMoney;
            db.SaveChanges();
        }

    }
}
