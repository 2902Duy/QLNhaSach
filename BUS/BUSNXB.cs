using DAL;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSNXB
    {
        dataBookStore db = new dataBookStore();

        public IEnumerable<NHAXUATBAN> DSNHAXUATBAN()
        {
            var dsnxb = from nxb in db.NHAXUATBANs
                        select nxb;
            return dsnxb;
        }


        public void ThemNhaXuatBan(string tenNXB)
        {
            try
            {
                
                var nxbExist = db.NHAXUATBANs.FirstOrDefault(n => n.TENNHAXUATBAN == tenNXB); // Tìm nhà xuất bản theo tên
                if (nxbExist != null)
                {
                    throw new Exception("Nhà xuất bản đã tồn tại.");
                }
                NHAXUATBAN nxbMoi = new NHAXUATBAN
                {
                    TENNHAXUATBAN = tenNXB
                };

                db.NHAXUATBANs.Add(nxbMoi);
                db.SaveChanges(); 
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra khi thêm nhà xuất bản: " + ex.Message);
            }
        }


        public void XoaNhaXuatBan(string tenNXB)
        {
            try
            {
                var nxb = db.NHAXUATBANs.FirstOrDefault(n => n.TENNHAXUATBAN == tenNXB);
                if (nxb == null)
                {
                    throw new Exception("Không tìm thấy nhà xuất bản.");
                }

                db.NHAXUATBANs.Remove(nxb);
                db.SaveChanges(); 
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra khi xóa nhà xuất bản: " + ex.Message);
            }
        }
    }
}
