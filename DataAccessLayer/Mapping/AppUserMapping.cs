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
                .UseIdentityColumn(1,1); // Identity property was gained to the primary key

            builder.Property(x=>x.FirstName)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnType("nvarchar"); // First Name is Required, max length can be 20 characters and data type will be nvarchar in the database

            builder.Property(x => x.MiddleName)
                .HasMaxLength(20)
                .HasColumnType("nvarchar"); // Middle Name max length can be 20 characters and data type will be nvarchar in the database

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnType("nvarchar"); // Last Name is Required, max length can be 30 characters and data type will be nvarchar in the database

            builder.Property(x => x.Length)
                .IsRequired()
                .HasColumnType("smallint"); // Data type will be smallint in the database 

            builder.Property(x => x.Weigth)
                .IsRequired()
                .HasColumnType("decimal(4,1)"); // Data type will be decimal(4,1), which means '000,0' in the database

            builder.Property(x => x.BirtDate)
                .IsRequired()
                .HasColumnType("date"); // Data type will be date, which means 'dd/mm/yyyy' in the database

            builder.Property(x => x.CreatedDate)
                .IsRequired()
                .HasColumnType("smalldatetime"); // Data type will be date, which means 'dd/mm/yyyy hh:mm:ss' in the database

            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("nvarchar"); // Email is Required, max length can be 100 characters and data type will be nvarchar in the database
            builder.HasIndex(x => x.Email)
                .IsUnique(); // Email must be unique which means an email can be used for an account

            builder.Property(x=>x.Password)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnType("nvarchar"); // Password is Required, max length can be 100 characters and data type will be nvarchar in the database

            builder.Property(x => x.IsActive)
                .IsRequired()
                .HasColumnType("bit"); // IsActive will be used for email validation. It is required and data type will be bit in the database
        }
    }
}
