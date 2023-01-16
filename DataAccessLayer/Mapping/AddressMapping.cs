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
    internal class AddressMapping : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresses"); // Table name will be Users in the database

            builder.HasKey(x => x.Id); // Set as Primary Key

            builder.Property(x => x.Id)
                .UseIdentityColumn(1, 1)
                .HasColumnOrder(1); // Identity property was gained to the primary key. Column order was set.

            builder.Property(x => x.CountryId)
                .IsRequired()
                .HasColumnOrder(2);

            builder.Property(x => x.UserId)
                .IsRequired()
                .HasColumnOrder(3);

            builder.Property(x => x.CreatedDate)
                .IsRequired()
                .HasColumnType("smalldatetime")
                .HasColumnOrder(4); // Data type will be date, which means 'dd/mm/yyyy hh:mm:ss' in the database

            builder.Property(x => x.ModifiedDate)
                .IsRequired()
                .HasColumnType("smalldatetime")
                .HasColumnOrder(5)
                .HasDefaultValueSql("getdate()"); // Data type will be date, which means 'dd/mm/yyyy hh:mm:ss' in the database. Default value set as now.

            builder.HasOne(x => x.Country)
                .WithMany(x => x.Addresses); // one to many Relation

            builder.HasOne<AppUser>(x => x.AppUser)
                .WithOne(x => x.Address)
                .HasForeignKey<AppUser>(x => x.AddressId); // Foreign key set with AppUser
        }
    }
}
