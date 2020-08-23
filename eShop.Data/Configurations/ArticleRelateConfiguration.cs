using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Configurations
{
    class ArticleRelateConfiguration : IEntityTypeConfiguration<ArticleRelate>
    {
        public void Configure(EntityTypeBuilder<ArticleRelate> builder)
        {
            builder.ToTable("ArticleRelates");
            builder.HasKey(x => x.ArticleRelateId); 
            builder.Property(x => x.ArticleRelateId).UseIdentityColumn(); 
            builder.Property(x => x.CrDateTime).HasDefaultValue(DateTime.Now); 
            builder.HasOne(x => x.ArticleReference).WithMany(x => x.ArticleRelates).HasForeignKey(x => x.ArticleReferenceId);
        }
    }
}
