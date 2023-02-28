using DataBase.IRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Repository
{
    public class StudentRepository : Repository<Student> , IStudentRepository 
    {
        private DataBaseContext _context;
        public StudentRepository(DataBaseContext repositoryContext) : base(repositoryContext)
        {
            _context= repositoryContext;
        }

        public Student GetStudentBYaName(string name)
        {
            return _context.Students.Single(s => s.Name == name);
            
        }
    }
}
