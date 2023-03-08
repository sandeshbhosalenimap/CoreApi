using API.DataBase.IRepository;
using API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.DataBase.Repository
{
    public class CategoryRepositoty : ICategoryRepository
    {
        DataBaseContext db = new DataBaseContext();
        public void Delete(int id)
        {
            var data= db.categories.Where(c=>c.CategoryId==id).FirstOrDefault();
            db.categories.Remove(data); 
            db.SaveChanges();
        }

        public Category Details(int id)
        {
            return  db.categories.Single(c => c.CategoryId == id);
        }

        public List<Category> GetAll()
        {   
            return db.categories.ToList();  
        }

        public void Update(int id, Category category)
        {
            var data = db.categories.Where(c => c.CategoryId == id).FirstOrDefault();
            if(data != null)
            {
                data.CategoryName = category.CategoryName;
            }
            db.SaveChanges();

        }
    }
}
