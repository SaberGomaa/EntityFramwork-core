﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramwork.net5
{
    internal class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }
    }
}
