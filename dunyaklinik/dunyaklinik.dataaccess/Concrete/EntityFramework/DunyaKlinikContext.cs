using dunyaklinik.entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.dataaccess.Concrete.EntityFramework
{
    public class DunyaKlinikContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=77.92.97.2;User ID=db_admin;Password=^4k648awD;Database=dunyaklinik_main");
        }
        public DbSet<User> users { get; set; }
        public DbSet<nesne> deneme { get; set; }
    }
}
