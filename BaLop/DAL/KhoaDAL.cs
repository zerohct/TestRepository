using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class KhoaDAL
    {
        private SinhVienModel Context;

        public KhoaDAL()
        {
            Context = new SinhVienModel();
        }

        public List<Faculty> GetAllKhoa()
        {
            return Context.Faculties.ToList();
        }
    }
}
