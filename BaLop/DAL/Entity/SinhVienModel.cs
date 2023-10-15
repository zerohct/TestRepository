using System.Data.Entity;

namespace DAL
{
    public partial class SinhVienModel : DbContext
    {
        public SinhVienModel()
            : base("name=SinhVienModel1")
        {
        }

        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<student> students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Major>()
                .HasMany(e => e.students)
                .WithOptional(e => e.Major)
                .HasForeignKey(e => e.MajorlId);
        }
    }
}
