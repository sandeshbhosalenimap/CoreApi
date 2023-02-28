using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.IRepository
{
    public interface IRepository<T> where T : class
    {
        void Add(T Entity);
        void Delete(Expression<Func<T, bool>> experssion);
        void Edit(int id, T Entity);
        IQueryable<T> AllList();
        IQueryable<T> Details(Expression<Func<T, bool>> experssion);
    }
}
