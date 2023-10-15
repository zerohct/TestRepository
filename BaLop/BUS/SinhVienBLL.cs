using DAL;
using System.Collections.Generic;

namespace BUS
{
    public class SinhVienBLL
    {
        private SinhVienDAL sinhVienDAL;

        public SinhVienBLL()
        {
            sinhVienDAL = new SinhVienDAL();
        }

        public void AddSinhVien(student sv)
        {
            sinhVienDAL.AddSinhVien(sv);
        }

        public void UpdateSinhVien(student sv)
        {
            sinhVienDAL.UpdateSinhVien(sv);
        }

        public void DeleteSinhVien(student sv)
        {
            sinhVienDAL.DeleteSinhVien(sv);
        }

        public student GetSinhVienByMSSV(int mssv)
        {
            return sinhVienDAL.GetSinhVienByMSSV(mssv);
        }

        public List<student> GetAllSinhVien()
        {
            return sinhVienDAL.GetAllSinhVien();
        }
    }
}
