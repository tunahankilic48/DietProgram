﻿using EntityLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    internal class MealContentMapping : IEntityTypeConfiguration<MealContent>
    {
        public void Configure(EntityTypeBuilder<MealContent> builder)
        {
            builder.ToTable("MealContents"); // Table name will be Users in the database

            builder.HasKey(x => new {x.MealId, x.ProductId}); // Composite Key

            builder.Property(x => x.MealId)  
                .HasColumnOrder(1); // Column order was set.

            builder.Property(x => x.MealId)
                .HasColumnOrder(2); // Column order was set.

            builder.Property(x => x.Quantity)
                .IsRequired()
                .HasColumnType("smallint")
                .HasColumnOrder(3); // Data type will be smallint in the database 

            builder.Property(x => x.TotalCalorie)
                .IsRequired()
                .HasColumnType("smallint")
                .HasColumnOrder(4); // Data type will be smallint in the database 
        }
    }
}
