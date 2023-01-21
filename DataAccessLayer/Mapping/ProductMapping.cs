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
    internal class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products"); // Table name will be Users in the database

            builder.HasKey(x => x.Id); // Set as Primary Key

            builder.Property(x => x.Id)
                .UseIdentityColumn(1, 1)
                .HasColumnOrder(1); // Identity property was gained to the primary key. Column order was set.

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnType("nvarchar")
                .HasColumnOrder(2); // First Name is Required, max length can be 20 characters and data type will be nvarchar in the database

            builder.Property(x => x.ProductCategoryId)
                 .IsRequired()
                  .HasColumnOrder(3); // Data type will be smallint in the database 

            builder.Property(x => x.QuantityPerUnit)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnType("nvarchar")
                    .HasColumnOrder(4); // Data type will be smallint in the database 

            builder.Property(x => x.Calorie)
                .IsRequired()
                .HasColumnType("smallint")
                .HasColumnOrder(5); // Data type will be smallint in the database 

            builder.Property(x => x.CreatedDate)
                .IsRequired()
                .HasColumnType("smalldatetime")
                .HasColumnOrder(6); // Data type will be date, which means 'dd/mm/yyyy hh:mm:ss' in the database

            builder.Property(x => x.ModifiedDate)
                .IsRequired()
                .HasColumnType("smalldatetime")
                .HasColumnOrder(7)
                .HasDefaultValueSql("getdate()"); // Data type will be date, which means 'dd/mm/yyyy hh:mm:ss' in the database

            builder.HasOne<ProductCategory>(x => x.ProductCategory)
                   .WithMany(x => x.Products)
                   .HasForeignKey(x => x.ProductCategoryId);
        }
    }
}
