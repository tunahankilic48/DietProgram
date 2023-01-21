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
            builder.Property(x => x.Id)
                   .HasColumnOrder(1);

            builder.Property(x => x.Height)
                   .IsRequired()
                   .HasColumnType("smallint")
                   .HasColumnOrder(2); // Data type will be smallint in the database 

            builder.Property(x => x.Weight)
                   .IsRequired()
                   .HasColumnType("decimal(4,1)")
                   .HasColumnOrder(3); // Data type will be decimal(4,1), which means '000,0' in the database

            builder.Property(x => x.UserId)
                .HasColumnOrder(4);

            builder.Property(x => x.CreatedDate)
                   .IsRequired()
                   .HasColumnType("smalldatetime")
                   .HasColumnOrder(5); // Data type will be date, which means 'dd/mm/yyyy hh:mm:ss' in the database

            builder.HasOne<AppUser>(x => x.AppUser)
                   .WithMany(x => x.WeightsAndHeights)
                   .HasForeignKey(x => x.UserId);

            builder.Ignore(x => x.BodyMassIndex);
            builder.Ignore(x => x.DailyRequiredCalori);
        }

    }
}

