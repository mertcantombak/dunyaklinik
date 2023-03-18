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
            //optionsBuilder.UseMySQL("Server=77.92.97.2;User ID=db_admin;Password=^4k648awD;Database=dunyaklinik_main");
            optionsBuilder.UseMySQL("Server=localhost; Port=3306;User ID=db_admin;Password=^4k648awD; Database=dunyaklinik_main");
        }
        public DbSet<User> users { get; set; }
        public DbSet<nesne> deneme { get; set; }
        public DbSet<Appointment> appoitments { get; set; }
        public DbSet<Client_Users> client_users { get; set; }
        public DbSet<Log_Login> log_Sogins { get; set; }
        public DbSet<Service_Branch_Documents> service_branch_documents { get; set; }
        public DbSet<Service_Branch_General> service_branch_generals { get; set; }
        public DbSet<Service_Organisation> service_organisations { get; set; }
        public DbSet<Service_Organisation_Documents> service_oganisation_documents { get; set; }
        public DbSet<Service_User_Documents> service_user_documents { get; set; }
        public DbSet<Service_User_Professions> service_user_professions { get; set; }
        public DbSet<Service_User_Title_Names> service_user_title_names { get; set; }
        public DbSet<Service_Users> service_users { get; set; }
        public DbSet<Treatment> treatments { get; set; }
        public DbSet<Treatment_Client_Rating> treatment_client_ratings { get; set; }
        public DbSet<Treatment_Documents> treatment_documents { get; set; }
        public DbSet<Treatment_Exercises> treatment_exercises { get; set; }
        public DbSet<Treatment_Service_Rating> treatment_service_ratings { get; set; }
        public DbSet<Treatment_Type> treatment_types { get; set; }
    }
}
