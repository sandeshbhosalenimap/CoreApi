using Crude.Api.Service.IService;
using DataBase.IRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crude.Api.Service.Service
{
    public class StudentServices : IStudentServices
    {
        private IStudentRepository _studentRepository;
        public StudentServices(IStudentRepository student)
        {
            _studentRepository = student;
        }
        public void AddNewStudent(Student student)
        {
            _studentRepository.Add(student);
        }

        public void Delete(int id)
        {
            _studentRepository.Delete(x => x.Id == id);
        }

        public void EditStudent(int id, Student student)
        {
            _studentRepository.Edit(id, student);
        }

        public IQueryable GetStudentDetails(int id)
        {
            return _studentRepository.Details(x => x.Id == id);
        }

        public IEnumerable<Student> StudentList()
        {
            return _studentRepository.AllList();    
        }

     
    }
}
