using DataBase.IRepository;
using Microsoft.EntityFrameworkCore;
using Models;
using Octopus.Client.Model.Accounts.Usages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DataBaseContext _context;
        public Repository(DataBaseContext AppDbContext)
        {
            _context = AppDbContext;
        }   
        public void Add(T Entity)
        {
            _context.Set<T>().Add(Entity);
            _context.SaveChanges();
        }

      

        public void Delete(Expression<Func<T, bool>> experssion)
        {
           var data = _context.Set<T>().Where(experssion).FirstOrDefault();
           

            _context.Set<T>().Remove((T)data);
            _context.SaveChanges(); 
        }

        public IQueryable<T> Details(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression).AsNoTracking();
           
            
        }

        public void Edit(int id, T Entity)
        {
            _context.Update(Entity);
            _context.SaveChanges();
        }

        IQueryable<T> IRepository<T>.AllList()
        {
            return _context.Set<T>().AsNoTracking();
        }

       
    }
}
