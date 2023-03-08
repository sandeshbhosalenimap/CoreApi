using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Service.IServices
{
    public interface ICategoryService
    {
        List<Category> GetCategory();
        void Delete(int id);
        void Update(int id, Category category);
        Category Details(int id);
    }
}
