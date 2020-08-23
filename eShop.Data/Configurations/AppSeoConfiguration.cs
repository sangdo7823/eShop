using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace eShop.Data.Configurations
{
    public class AppSeoConfiguration : IEntityTypeConfiguration<AppSeo>
    {
        public void Configure(EntityTypeBuilder<AppSeo> builder)
        {
            builder.ToTable("AppSeos").HasKey(x => x.AppSeoId);
            builder.Property(x=>x.AppSeoId).UseIdentityColumn();
            builder.Property(x => x.SeoTitle).IsRequired().HasMaxLength(200); 
            builder.Property(x => x.SeoDescription).HasMaxLength(200);  
            builder.Property(x => x.SeoKeyword).HasMaxLength(200);
            builder.Property(x => x.Canonical).HasMaxLength(200);
            builder.Property(x => x.ImagePath).HasMaxLength(200);
        }
    }
}
