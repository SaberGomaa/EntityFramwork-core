using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramwork.net5
{
    internal class Department
    {
        public int ID { get; set; } // by conventions 
        public string Name { get; set; }

        public int BranchID { get; set; }

        public Branch Branchs { get; set; }
        //Navigation proprety
        public virtual ICollection<Empolyee> Empolyees { get; set; }
        public virtual ICollection<Project> projects { get; set; }
    }
}
