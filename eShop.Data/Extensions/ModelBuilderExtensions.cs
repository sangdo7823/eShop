using eShop.Data.Entities;
using eShop.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            // any guid
            var roleId = 1;
            var adminId = 1;
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "teamsoft91@gmail.com",
                NormalizedEmail = "sangdo.eng@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456"),
                SecurityStamp = string.Empty,
                FirstName = "Sang",
                LastName = "Do",
                BirthDay = new DateTime(1991, 10, 04)
            });

            modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>
            {
                RoleId = roleId,
                UserId = adminId
            });

            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShopSolution" },
               new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eShopSolution" },
               new AppConfig() { Key = "HomeDescription", Value = "This is description of eShopSolution" }
               );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    CategoryId = 1,
                    IsShowHome = true,
                    ParentId = null,
                    DisplayOrder = 1,
                    ReviewStatusId = ReviewStatus.Active,
                },
                 new Category()
                 {
                     CategoryId = 2,
                     IsShowHome = true,
                     ParentId = null,
                     DisplayOrder = 2,
                     ReviewStatusId = ReviewStatus.New
                 });

            modelBuilder.Entity<AppSeo>().HasData(
                  new AppSeo() { AppSeoId = 1, SeoTitle = "Áo nam", SeoDescription = "Áo nam", SeoKeyword = "ao, ao nam" },
                  new AppSeo() { AppSeoId = 2, SeoTitle = "Men Shirt", SeoDescription = "Men Shirt", SeoKeyword = "Men Shirt" },
                  new AppSeo() { AppSeoId = 3, SeoTitle = "Áo nữ", SeoDescription = "Áo nữ", SeoKeyword = "Áo nữ" },
                  new AppSeo() { AppSeoId = 4, SeoTitle = "Women Shirt", SeoDescription = "Women Shirt", SeoKeyword = "Women Shirt" },
                  new AppSeo() { AppSeoId = 5, SeoTitle = "Áo sơ mi nam trắng Việt Tiến", SeoDescription = "Áo sơ mi nam trắng Việt Tiến", SeoKeyword = "Áo sơ mi nam trắng Việt Tiến" },
                  new AppSeo() { AppSeoId = 6, SeoTitle = "Viet Tien Men T-Shirt", SeoDescription = "Viet Tien Men T-Shirt", SeoKeyword = "Viet Tien Men T-Shirt" }
                  );

            modelBuilder.Entity<CategoryTranslation>().HasData(
                  new CategoryTranslation() { CategoryTranslationId = 1, CategoryId = 1, CategoryName = "Áo nam", CategoryDesc = "Áo nam", LanguageId = "vi-VN", SeoAlias = "ao-nam", AppSeoId = 1 },
                  new CategoryTranslation() { CategoryTranslationId = 2, CategoryId = 1, CategoryName = "Men Shirt", CategoryDesc = "Men Shirt", LanguageId = "en-US", SeoAlias = "men-shirt", AppSeoId =2 },
                  new CategoryTranslation() { CategoryTranslationId = 3, CategoryId = 2, CategoryName = "Áo nữ", CategoryDesc = "Áo nữ", LanguageId = "vi-VN", SeoAlias = "ao-nu", AppSeoId = 3 },
                  new CategoryTranslation() { CategoryTranslationId = 4, CategoryId = 2, CategoryName = "Women Shirt", CategoryDesc = "Women Shirt", LanguageId = "en-US", SeoAlias = "women-shirt", AppSeoId = 4 }
                    );

            modelBuilder.Entity<Product>().HasData(
           new Product()
           {
               ProductId = 1,
               CrDateTime = DateTime.Now,
               OriginalPrice = 100000,
               Price = 200000,
               Stock = 0,
               ViewCount = 0,
           });
            modelBuilder.Entity<ProductTranslation>().HasData(
                 new ProductTranslation()
                 {
                     ProductTranslationId = 1,
                     ProductId = 1,
                     Name = "Áo sơ mi nam trắng Việt Tiến",
                     LanguageId = "vi-VN",
                     SeoAlias = "ao-so-mi-nam-trang-viet-tien",
                     AppSeoId = 5,
                     Details = "Áo sơ mi nam trắng Việt Tiến",
                     Description = "Áo sơ mi nam trắng Việt Tiến"
                 },
                    new ProductTranslation()
                    {
                        ProductTranslationId = 2,
                        ProductId = 1,
                        Name = "Viet Tien Men T-Shirt",
                        LanguageId = "en-US",
                        SeoAlias = "viet-tien-men-t-shirt",
                        AppSeoId = 6,
                        Details = "Viet Tien Men T-Shirt",
                        Description = "Viet Tien Men T-Shirt"
                    });
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );

        }
    }
}
