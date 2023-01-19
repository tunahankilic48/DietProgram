using DataAccessLayer.Mapping;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DietContext : DbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealCategory> MealCategories { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<WeightsAndHeights> UsersWeightsAndHeights { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-A10URF2\\SQLEXPRESS;Database=DietProgramDb;Encrypt=false;Trusted_Connection=True;"); // Change connection string !!!
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserMapping());
            modelBuilder.ApplyConfiguration(new MealCategoryMapping());
            modelBuilder.ApplyConfiguration(new MealMapping());
            modelBuilder.ApplyConfiguration(new ProductMapping());
            modelBuilder.ApplyConfiguration(new MealContentMapping());
            modelBuilder.ApplyConfiguration(new CountryMapping());
            modelBuilder.ApplyConfiguration(new CityMapping());
            modelBuilder.ApplyConfiguration(new AddressMapping());
            modelBuilder.ApplyConfiguration(new ProductCategoryMapping());
            modelBuilder.ApplyConfiguration(new WeightsAndHeightsMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
