using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChuyenNganhBLL
    {
        SinhVienModel Context;
        private ChuyenNganhDAL cnDAL;
        public ChuyenNganhBLL()
        {
            cnDAL = new ChuyenNganhDAL();
        }

        public List<Major> GetAllByFaculty(int facultyID)
        {
            return cnDAL.GetAllByFaculty(facultyID);



        }
    }
}
