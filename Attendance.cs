using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramwork.net5
{
    internal class Attendance
    {
        public int EmployeeID { get; set; }
        public DateTime Date { get; set; }
        
        public virtual Empolyee Empolyee { get; set; }
    }
}
