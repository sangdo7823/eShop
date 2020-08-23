using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Configurations
{
    class ArticleInCategoryConfiguration : IEntityTypeConfiguration<ArticleInCategory>
    {
        public void Configure(EntityTypeBuilder<ArticleInCategory> builder)
        {
            builder.ToTable("ArticleInCategories").HasKey(t => new { t.CategoryId, t.ArticleId });
            builder.HasOne(pc => pc.Article).WithMany(pc => pc.ArticleInCategories).HasForeignKey(pc => pc.ArticleId);
            builder.HasOne(pc => pc.Category).WithMany(pc => pc.ArticleInCategories).HasForeignKey(pc => pc.CategoryId);
        }
    }
}
