using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; // подключение БД

// Подключение к БД 

namespace UsersApp
{
    class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; } // список элементов из табл.Users

        public AppContext() : base("DefaultConnection") { }

    }
}
