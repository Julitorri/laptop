﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseC_ex01.Entities
{
    internal class Department
    {
        public string Name { get; set; }
        public Department()
        {

        }
        public Department(string name)
        {
            Name = name;
        }

    }
}