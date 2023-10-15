namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("student")]
    public partial class student
    {
        public int StudentId { get; set; }

        [Required]
        [StringLength(30)]
        public string FullName { get; set; }

        public double? AverageScore { get; set; }

        public int? FacultyId { get; set; }

        public int? MajorlId { get; set; }

        [StringLength(255)]
        public string Avatar { get; set; }

        public virtual Faculty Faculty { get; set; }

        public virtual Major Major { get; set; }
    }
}
