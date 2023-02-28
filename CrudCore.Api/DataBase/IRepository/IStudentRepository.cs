﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.IRepository
{
    public interface IStudentRepository  : IRepository<Student>
    {
         Student GetStudentBYaName(string name);



    }
}
