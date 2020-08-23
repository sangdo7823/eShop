using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Configurations
{
    public class ArticleTranslationConfiguration : IEntityTypeConfiguration<ArticleTranslation>
    {
        public void Configure(EntityTypeBuilder<ArticleTranslation> builder)
        {
            builder.ToTable("ArticleTranslations").HasKey(x => x.ArticleTranslationId);
            builder.Property(x => x.ArticleTranslationId).UseIdentityColumn();
            builder.Property(x => x.ArticleTitle).IsRequired().HasMaxLength(255);
            builder.Property(x => x.ArticleSummary).HasMaxLength(2000);

            builder.Property(x => x.SeoAlias).IsRequired().HasMaxLength(200);

            builder.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.Language).WithMany(x => x.ArticleTranslations).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.Article).WithMany(x => x.ArticleTranslations).HasForeignKey(x => x.ArticleId);

        }
    }
}
