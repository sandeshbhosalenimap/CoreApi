﻿using System;
using System.Collections.Generic;

namespace Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public static implicit operator Student(List<Student> v)
        {
            throw new NotImplementedException();
        }
    }
}
