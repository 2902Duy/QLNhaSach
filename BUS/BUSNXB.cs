using DAL;
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

    }
}
