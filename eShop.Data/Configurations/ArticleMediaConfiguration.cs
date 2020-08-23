using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Configurations
{
   public class ArticleMediaConfiguration : IEntityTypeConfiguration<ArticleMedia>
    {
        public void Configure(EntityTypeBuilder<ArticleMedia> builder)
        {
            builder.ToTable("ArticleMedias");
            builder.HasKey(x => x.ArticleMediaId);

            builder.Property(x => x.ArticleMediaId).UseIdentityColumn();

            builder.Property(x => x.FilePath).HasMaxLength(200).IsRequired(true);
            builder.Property(x => x.Caption).HasMaxLength(200);

            builder.HasOne(x => x.Article).WithMany(x => x.ArticleMedias).HasForeignKey(x => x.ArticleId);

        }
    }
}
