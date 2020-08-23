using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Configurations
{
    public class AppMediaConfiguration : IEntityTypeConfiguration<AppMedia>
    {
        public void Configure(EntityTypeBuilder<AppMedia> builder)
        {
            builder.ToTable("AppMedias").HasKey(x => x.MediaId);
            builder.Property(x => x.MediaId).UseIdentityColumn();
            builder.Property(x => x.MediaName).IsRequired().HasMaxLength(255);
            builder.Property(x => x.MediaDesc).HasMaxLength(500);
            builder.Property(x => x.FilePath).HasMaxLength(200);
            builder.Property(x => x.CrDateTime).HasDefaultValue(DateTime.Now);
        }
    }
}
