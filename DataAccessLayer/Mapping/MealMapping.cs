using EntityLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    internal class MealCategoryMapping : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.ToTable("Meal"); // Table name will be Users in the database

            builder.HasKey(x => x.Id); // Set as Primary Key

            builder.Property(x => x.Id)
                .UseIdentityColumn(1, 1)
                .HasColumnOrder(1); // Identity property was gained to the primary key. Column order was set.

            builder.Property(x=>x.UserId)
                .IsRequired()
                .HasColumnOrder(2);

            builder.Property(x=>x.MealCategoryId)
                .IsRequired()
                .HasColumnOrder(3);

            builder.Property(x => x.CreatedDate)
                .IsRequired()
                .HasColumnType("smalldatetime")
                .HasColumnOrder(4); // Data type will be date, which means 'dd/mm/yyyy hh:mm:ss' in the database

            builder.Property(x => x.ModifiedDate)
                .IsRequired()
                .HasColumnType("smalldatetime")
                .HasColumnOrder(5); // Data type will be date, which means 'dd/mm/yyyy hh:mm:ss' in the database

            builder.HasOne<AppUser>(x=>x.User)
                .WithMany(x=>x.Meals)
                .HasForeignKey(x=>x.UserId); // One to Many Releation with Users

            builder.HasOne<MealCategory>(x => x.MealCategory)
                .WithMany(x => x.Meals)
                .HasForeignKey(x => x.MealCategoryId); // One to Many Reletion with MealCategory
        }
    }
}
