using Microsoft.EntityFrameworkCore;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Mapping
{
    internal class AppUserMapping : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("Users"); // Table name will be Users in the database

            builder.HasKey(x => x.Id); // Set as Primary Key

            builder.Property(x => x.Id)
                .UseIdentityColumn(1, 1)
                .HasColumnOrder(1); // Identity property was gained to the primary key. Column order was set.

            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnType("nvarchar")
                .HasColumnOrder(2); // First Name is Required, max length can be 20 characters and data type will be nvarchar in the database

            builder.Property(x => x.MiddleName)
                .HasMaxLength(20)
                .HasColumnType("nvarchar")
                .HasColumnOrder(3); // Middle Name max length can be 20 characters and data type will be nvarchar in the database

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnType("nvarchar")
                .HasColumnOrder(4); // Last Name is Required, max length can be 30 characters and data type will be nvarchar in the database

            builder.Property(x => x.BirtDate)
                .IsRequired()
                .HasColumnType("date")
                .HasColumnOrder(5); // Data type will be date, which means 'dd/mm/yyyy' in the database

            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("nvarchar")
                .HasColumnOrder(6); // Email is Required, max length can be 100 characters and data type will be nvarchar in the database
            builder.HasIndex(x => x.Email)
                .IsUnique(); // Email must be unique which means an email can be used for an account

            builder.Property(x => x.Password)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnType("nvarchar")
                .HasColumnOrder(7); // Password is Required, max length can be 100 characters and data type will be nvarchar in the database

            builder.Property(x => x.IsMale)
                .IsRequired()
                .HasColumnType("bit")
                .HasColumnOrder(8);

            builder.Property(x => x.AddressId)
                .HasColumnOrder(9);

            builder.Property(x => x.IsActive)
                .IsRequired()
                .HasColumnType("bit")
                .HasColumnOrder(10); // IsActive will be used for email validation. It is required and data type will be bit in the database

            builder.Property(x => x.CreatedDate)
                .IsRequired()
                .HasColumnType("smalldatetime")
                .HasColumnOrder(11); // Data type will be date, which means 'dd/mm/yyyy hh:mm:ss' in the database

            builder.Property(x => x.ModifiedDate)
                .IsRequired()
                .HasColumnType("smalldatetime")
                .HasColumnOrder(12)
                .HasDefaultValueSql("getdate()"); // Data type will be date, which means 'dd/mm/yyyy hh:mm:ss' in the database. Default value set as now.

            builder.Property(x => x.ProfilePhoto)
                   .HasColumnType("varbinary")
                   .HasColumnOrder(13);

            builder.Ignore(x => x.Name); // Not mapped in the database


        }
    }
}
