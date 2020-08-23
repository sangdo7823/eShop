using eShop.Data.Entities;
using eShop.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Configurations
{
    public class MenuItemConfiguration : IEntityTypeConfiguration<MenuItem>
    {
        public void Configure(EntityTypeBuilder<MenuItem> builder)
        {
            builder.ToTable("MenuItems"); 
            builder.HasKey(x => x.MenuItemId);
            builder.Property(x => x.MenuItemId).UseIdentityColumn();
            builder.Property(x => x.ItemName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.ItemDesc).HasMaxLength(255);
            builder.Property(x => x.IconPath).HasMaxLength(255);
            builder.Property(x => x.Url).HasMaxLength(255);
            builder.Property(x => x.ReviewStatusId).HasDefaultValue(ReviewStatus.Active);
            builder.Property(x => x.CrDateTime).HasDefaultValue(DateTime.Now);
            builder.HasOne(x => x.Menu).WithMany(x => x.MenuItems).HasForeignKey(x => x.MenuId);

        }
    }
}
