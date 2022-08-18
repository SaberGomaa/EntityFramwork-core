using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramwork.net5
{
    internal class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Department> Departments { get; set; }
    }
}
