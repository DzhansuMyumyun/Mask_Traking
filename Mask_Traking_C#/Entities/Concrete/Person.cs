﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public long Nationality { get; set; }
        public int DateOfBirthYear { get; set; }

        public string FatherName { get; set; }

    }
}
