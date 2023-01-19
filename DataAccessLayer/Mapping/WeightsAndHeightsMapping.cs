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


    internal class WeightsAndHeightsMapping : IEntityTypeConfiguration<WeightsAndHeights>
    {
        public void Configure(EntityTypeBuilder<WeightsAndHeights> builder)
        {
            builder.ToTable("UsersHeightsAndWeights"); // Table name will be Users in the database

            builder.HasKey(x => x.Id); // Set as Primary Key

            builder.Property(x => x.CreatedDate)
                   .IsRequired()
                   .HasColumnType("smalldatetime")
                   .HasColumnOrder(3); // Data type will be date, which means 'dd/mm/yyyy hh:mm:ss' in the database

            builder.Property(x => x.ModifiedDate)
                   .IsRequired()
                   .HasColumnType("smalldatetime")
                   .HasColumnOrder(4); // Data type will be date, which means 'dd/mm/yyyy hh:mm:ss' in the database

            builder.Property(x => x.Weight)
                   .IsRequired()
                   .HasColumnType("smallint")
                   .HasColumnOrder(5);
            builder.Property(x => x.Height)
                   .IsRequired()
                   .HasColumnType("smallint")
                   .HasColumnOrder(6);

            builder.HasOne<AppUser>(x => x.AppUsers)
                   .WithMany(x => x.WeightsAndHeights)
                   .HasForeignKey(x => x.AppUserId);
        }

    }
}

