using API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.DataBase
{
    public class DataBaseContext : DbContext
    {
       public DbSet<Category> categories { get; set; }

        public DbSet<Product> products { get; set; }
    }
}
