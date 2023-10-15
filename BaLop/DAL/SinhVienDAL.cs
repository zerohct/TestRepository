using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class SinhVienDAL
    {
        private SinhVienModel context;

        public SinhVienDAL()
        {
            context = new SinhVienModel();
        }

        public void AddSinhVien(student sv)
        {
            context.students.Add(sv);
            context.SaveChanges();
        }

        public void UpdateSinhVien(student sv)
        {
            student sinhVien = context.students.Find(sv.StudentId);

            if (sinhVien != null)
            {
                sinhVien.FullName = sv.FullName;
                sinhVien.FacultyId = sv.FacultyId;
                sinhVien.AverageScore = sv.AverageScore;
                context.SaveChanges();
            }
        }

        public void DeleteSinhVien(student sv)
        {
            student sinhVien = context.students.Find(sv.StudentId);

            if (sinhVien != null)
            {
                context.students.Remove(sinhVien);
                context.SaveChanges();
            }
        }

        public student GetSinhVienByMSSV(int mssv)
        {
            return context.students.FirstOrDefault(sv => sv.StudentId == mssv);
        }

        public List<student> GetAllSinhVien()
        {
            return context.students.ToList();
        }
    }
}
