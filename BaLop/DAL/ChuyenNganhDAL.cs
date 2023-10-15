using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChuyenNganhDAL
    {
        private SinhVienModel Context;
        public ChuyenNganhDAL()
        {
            Context = new SinhVienModel();
        }
        public List<Major> GetAllByFaculty(int facultyID)
        {
            return Context.Majors.Where(p=>p.FacultyId== facultyID).ToList();
        }
    }
}
