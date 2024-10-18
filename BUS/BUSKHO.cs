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
    }
}
