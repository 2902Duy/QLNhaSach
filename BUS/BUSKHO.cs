using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSKHO
    {
        dataBookStore db = new dataBookStore();
        public IEnumerable<CHITIETKHO> DSKHOSACH()
        {
            var dskho = from kho in db.KHOSACHes
                        select new CHITIETKHO{ 
                        KHOSACH = kho,
                        SACH = kho.SACH,
                        };
            return dskho;

        }
        public void themSachKho(string maSach, byte soluong)
        {
            /*
            var id = db.KHOSACHes.Max(s => s.ID) + 1;
            string maKho = "KS00" + (id + 1);
            KHOSACH ks = new KHOSACH
            {
                ID = id,
                IDKHO = maKho,
                MASACH = maSach,
                SL = soluong
            };
            db.KHOSACHes.Add(ks);
            db.SaveChanges();
            */
        }

        public void xoaSachKho(int id)
        {
            var kho = db.KHOSACHes.FirstOrDefault(s => s.ID == id);

            if (kho != null)
            {

                db.KHOSACHes.Remove(kho);
                db.SaveChanges();
            }
        }

        public void SuaSachKho(int id, string MaSach, byte soluong)
        {
            var kho = db.KHOSACHes.FirstOrDefault(s => s.ID == id);

            if (kho != null)
            {
                kho.MASACH = MaSach;
                kho.SL = soluong;
                db.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Không tồn tại.");
            }
        }

        public bool KiemtraSLSach(int sl, string masach)
        {
            var sach = db.KHOSACHes.Where(s=> s.MASACH.Equals(masach)).FirstOrDefault();
            if (sl > sach.SL)
                return false;
            return true;
        }
        public void capNhapSoLuongSach(int sl, string masach)
        {
            var sach = db.KHOSACHes.Where(s=>s.MASACH.Equals (masach)).FirstOrDefault();
            sach.SL = (byte?)(sach.SL-sl);
            db.SaveChanges();
        }
    }
}
