using API.DataBase.IRepository;
using API.Models;
using API.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Service.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        public CategoryService (ICategoryRepository _categoryRepository)
        {
            categoryRepository = _categoryRepository;
        }

        public void Delete(int id)
        {
            categoryRepository.Delete(id);
        }

        public Category Details(int id)
        {
            return categoryRepository.Details(id);
        }

        public List<Category> GetCategory()
        {
            return categoryRepository.GetAll();
        }

        public void Update(int id, Category category)
        {
             categoryRepository.Update(id, category); 
        }
    }
}
