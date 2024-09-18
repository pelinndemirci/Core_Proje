using Core_Proje_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core_Proje_Api.DAL.ApiContext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-KP77UQ6;database=CoreProjeDB2;integrated security=true"); //Bağlantı adresini tutacak olan method

        }

        public DbSet<Category> Categories { get; set; }
    }
}
