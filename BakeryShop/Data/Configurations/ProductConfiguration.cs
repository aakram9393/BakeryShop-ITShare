using BakeryShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryShop.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Products>
    {
        //Fluent API
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.Property(p => p.ImageName).HasColumnName("ImageFileName");
        }
    }
}
