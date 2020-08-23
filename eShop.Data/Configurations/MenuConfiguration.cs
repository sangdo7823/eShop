using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Configurations
{
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.ToTable("Menus");

            builder.HasKey(x => x.MenuId);
            builder.Property(x => x.MenuId).UseIdentityColumn(); 
            builder.Property(x => x.MenuName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.MenuDesc).HasMaxLength(255);
            builder.Property(x => x.CrDateTime).HasDefaultValue(DateTime.Now);
        }
    }
}
