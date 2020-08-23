using eShop.Data.Entities;
using eShop.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Configurations
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("Articles").HasKey(x => x.ArticleId); 
            builder.Property(x => x.ArticleId).UseIdentityColumn(); 
            builder.Property(x => x.CrDateTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.ReviewStatusId).HasDefaultValue(ReviewStatus.New);

        }
    }
}
