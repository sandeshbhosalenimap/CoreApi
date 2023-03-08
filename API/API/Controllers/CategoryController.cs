using API.DataBase;
using API.Models;
using API.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class CategoryController : ApiController
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService _categoryService)
        {
            categoryService = _categoryService;
        }

        [HttpGet]
        public IHttpActionResult GetList()
        {
           List<Category> data = categoryService.GetCategory();
            return Ok(data);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
           categoryService.Delete(id);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Update(int id , Category category)
        {
           categoryService.Update(id ,category);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult Details(int id)
        {
            Category data = categoryService.Details(id);
            return Ok(data);
        }
    }
}
