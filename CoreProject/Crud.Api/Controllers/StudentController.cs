
using AutoMapper;
using Crude.Api.Service.IService;
using Crude.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Crude.Api.Controllers
{

    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentServices _studentService;
      private IMapper _mapper;
        public StudentController(IStudentServices student, IMapper mapper)
        {
            _studentService = student;
            _mapper = mapper;   
        }

        [HttpGet]
        [Route("Student/StudentList")]
        public async Task<IActionResult> StudentList()
        {
            var data = await _studentService.StudentList();
            if(data != null)
            {
                throw new ArgumentNullException(nameof(data));  
            }
            return Ok(data);

        }

        [HttpGet]
        [Route("Student/GetStudentByID/{id}")]
        public async Task<IActionResult> GetStudentByID([FromRoute] int id)
        {
            var student = await _studentService.GetStudentDetails(id);
            var DTOModel = _mapper.Map<IEnumerable<StudentDTO>>(student);
                return Ok(DTOModel);     
        }

        [HttpPut]
        [Route("Student/EditStudent/{id}")]
        public async Task<IActionResult> EditStudent([FromRoute] int id, [FromBody] Student student)
        {
            await _studentService.EditStudent(id, student);
            return Ok();
        }

        [HttpDelete]
        [Route("Student/DeleteStudent{id}")]
        public async Task<IActionResult> DeleteStudent([FromRoute] int id)
        {
            await _studentService.Delete(id);
            return Ok();
        }

        [HttpPost]
        [Route("Student/CreateStudent")]
        public async Task<IActionResult> CreateStudent([FromBody] Student student)
        {
            await _studentService.AddNewStudent(student);
            return Ok();
        }

    }
}
