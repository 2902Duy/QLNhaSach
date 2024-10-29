using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public IEnumerable<THELOAI> DSTHELOAI()
        {
            return db.THELOAIs.ToList();
        }

        public void themSach(string tenSach ,string tacGia, string theLoai, string tenNhaSX, int giaNhap, int giaBan, int namXB)
        {
            var id = db.SACHes.Max(s => s.IDMASACH) + 1;
            string maSach= "SS00" + (id + 1);

            var tacGiaObj = db.TACGIAs.FirstOrDefault(t => t.TENTACGIA == tacGia);
            if (tacGiaObj == null)
            {
                tacGiaObj = new TACGIA { TENTACGIA = tacGia };
                db.TACGIAs.Add(tacGiaObj); 
            }

            SACH sach = new SACH
            {
                IDMASACH = id,
                MASACH = maSach,
                TENSACH = tenSach,
                TACGIA = tacGiaObj,
                TENTHELOAI = theLoai,
                TENNHAXUATBAN = tenNhaSX,
                GIANHAP = giaNhap,
                GIABAN = giaBan,
                NAMXUATBAN = namXB
            };
            db.SACHes.Add(sach);
            db.SaveChanges();
        }

        public void xoaSach(int idMaSach)
        {
            var sach = db.SACHes.FirstOrDefault(s => s.IDMASACH == idMaSach);

            if (sach != null) 
            {
                db.SACHes.Remove(sach); 
                db.SaveChanges(); 
            }
        }

        public void suaSach(int idMaSach, string tenSach, string tacGia, string theLoai, string tenNhaSX, int giaNhap, int giaBan, int namXB)
        {
            var sach = db.SACHes.FirstOrDefault(s => s.IDMASACH == idMaSach);

            if (sach != null)
            {
                sach.TENSACH = tenSach;
                var tacGiaObj = db.TACGIAs.FirstOrDefault(t => t.TENTACGIA == tacGia);
                if (tacGiaObj == null)
                {
                    tacGiaObj = new TACGIA { TENTACGIA = tacGia };
                    db.TACGIAs.Add(tacGiaObj);
                }

                sach.TACGIA = tacGiaObj;
                sach.TENTHELOAI = theLoai;
                sach.TENNHAXUATBAN = tenNhaSX;
                sach.GIANHAP = giaNhap;
                sach.GIABAN = giaBan;
                sach.NAMXUATBAN = namXB;

                db.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Sách không tồn tại.");
            }
        }

        public SACH timSachTheoMa(string MaSach)
        {
            
            SACH sach = db.SACHes.Where(s=>s.MASACH.Equals(MaSach)).FirstOrDefault();
            return sach;
        }
        public void ThemTheLoai(string tenTheLoai)
        {
            try
            {

                var TheLoaiExist = db.THELOAIs.FirstOrDefault(t => t.TENTHELOAI == tenTheLoai); 
                if (TheLoaiExist != null)
                {
                    throw new Exception("Tên thể loại sách đã tồn tại.");
                }
                THELOAI theLoaiMoi = new THELOAI
                {
                    TENTHELOAI = tenTheLoai
                };

                db.THELOAIs.Add(theLoaiMoi);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra khi thêm thể loại sách: " + ex.Message);
            }
        }

        public void XoaTheLoai(string tenTheLoai)
        {
            try
            {
                var theLoai = db.THELOAIs.FirstOrDefault(t => t.TENTHELOAI == tenTheLoai);
                if (theLoai != null)
                {
                    db.THELOAIs.Remove(theLoai);
                    db.SaveChanges(); 
                }
                else
                {
                    throw new Exception("Thể loại không tồn tại!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa thể loại: {ex.Message}");
            }
        }


        public List<TACGIA> DSSACH_TACGIA()
        {
            using (var db = new dataBookStore())
            {

                return db.TACGIAs.ToList(); // Lấy tất cả tác giả
            }
        }

        public void themTacGia(string tenTacGia, string Quequan)
        {
            var id = db.TACGIAs.Max(s => s.IDTACGIA) + 1;
            string maTacGia = "TG00" + (id + 1);

            TACGIA tg = new TACGIA
            {
                IDTACGIA = id,
                MATACGIA = maTacGia,
                TENTACGIA = tenTacGia,
                QUEQUAN = Quequan,
               
            };
            db.TACGIAs.Add(tg);
            db.SaveChanges();
        }

        public void xoaTacGia(int idTacGia)
        {
            var tacgia = db.TACGIAs.FirstOrDefault(s => s.IDTACGIA == idTacGia);

            if (tacgia != null)
            {     
           
                db.TACGIAs.Remove(tacgia);
                db.SaveChanges();
            }
        }

        public void suaTacGia(int idTacGia, string tenTacGIa, string Quequan)
        {
            var tacgia = db.TACGIAs.FirstOrDefault(s => s.IDTACGIA == idTacGia);

            if (tacgia != null)
            {
                tacgia.TENTACGIA = tenTacGIa ;
                tacgia.QUEQUAN = Quequan ;
                db.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Tác giả không tồn tại.");
            }
        }
        public bool kiemTraTenSach(string tenSach)
        {
            var lsSach = from s in db.SACHes
                         select s.TENSACH;
            foreach (var s in lsSach.ToList())
            {
                if (s.Equals(tenSach))
                    return true;
            }
            return false;
        }
    }

}
