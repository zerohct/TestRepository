using DAL;
using System.Collections.Generic;

namespace BUS
{
    public class KhoaBLL
    {
        SinhVienModel Context;
        private KhoaDAL khoaDAL;

        public KhoaBLL()
        {
            khoaDAL = new KhoaDAL();
        }

        public List<Faculty> GetAllKhoa()
        {
           return  khoaDAL.GetAllKhoa();
          

          
        }
    }
}
