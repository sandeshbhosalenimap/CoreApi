using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.DataBase.IRepository
{
    public  interface ICategoryRepository
    {

        List<Category> GetAll();
        void Delete(int id);
        void Update(int id, Category category);
        Category Details(int id);
    }
}
