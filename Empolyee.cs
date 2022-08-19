using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramwork.net5
{
    [Table("Empolyees")]// Data annotation
    internal class Empolyee
    {
        [Required] // Data Annotations
        public   int   ID { get; set; }
        [Column("FullName")]
        public string Name { get; set; }

        public double Salary { get; set; }

        public int DepartmentID { get; set; }

        public bool Deleted { get; set; }
        public virtual Department Department { get; set; } // Navigation property
        public virtual ICollection<Attendance> Attendances { get; set; }

    }
}
