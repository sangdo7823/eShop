using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CrDateTime",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 23, 15, 41, 18, 641, DateTimeKind.Local).AddTicks(4607),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 8, 23, 15, 19, 21, 967, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CrDateTime",
                table: "Contacts",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 23, 15, 41, 18, 627, DateTimeKind.Local).AddTicks(4457),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 8, 23, 15, 19, 21, 953, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "HomeTitle", "This is home page of eShopSolution" },
                    { "HomeKeyword", "This is keyword of eShopSolution" },
                    { "HomeDescription", "This is description of eShopSolution" }
                });

            migrationBuilder.InsertData(
                table: "AppSeos",
                columns: new[] { "AppSeoId", "Canonical", "ImagePath", "SeoDescription", "SeoKeyword", "SeoTitle" },
                values: new object[,]
                {
                    { 1, null, null, "Áo nam", "ao, ao nam", "Áo nam" },
                    { 2, null, null, "Men Shirt", "Men Shirt", "Men Shirt" },
                    { 3, null, null, "Áo nữ", "Áo nữ", "Áo nữ" },
                    { 4, null, null, "Women Shirt", "Women Shirt", "Women Shirt" },
                    { 5, null, null, "Áo sơ mi nam trắng Việt Tiến", "Áo sơ mi nam trắng Việt Tiến", "Áo sơ mi nam trắng Việt Tiến" },
                    { 6, null, null, "Viet Tien Men T-Shirt", "Viet Tien Men T-Shirt", "Viet Tien Men T-Shirt" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "DisplayOrder", "IsShowHome", "ParentId", "ReviewStatusId" },
                values: new object[] { 1, 1, true, null, 2 });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "DisplayOrder", "IsShowHome", "ParentId" },
                values: new object[] { 2, 2, true, null });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "IsDefault", "Name" },
                values: new object[,]
                {
                    { "vi-VN", true, "Tiếng Việt" },
                    { "en-US", false, "English" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CrDateTime", "CrUserId", "OriginalPrice", "Price", "ReviewStatusId", "UpDateTime", "UpUserId" },
                values: new object[] { 1, new DateTime(2020, 8, 23, 15, 41, 18, 655, DateTimeKind.Local).AddTicks(7466), 0, 100000m, 200000m, 0, null, 0 });

            migrationBuilder.InsertData(
                table: "CategoryTranslations",
                columns: new[] { "CategoryTranslationId", "AppSeoId", "CategoryDesc", "CategoryId", "CategoryName", "LanguageId", "SeoAlias" },
                values: new object[,]
                {
                    { 1, 1, "Áo nam", 1, "Áo nam", "vi-VN", "ao-nam" },
                    { 3, 3, "Áo nữ", 2, "Áo nữ", "vi-VN", "ao-nu" },
                    { 2, 2, "Men Shirt", 1, "Men Shirt", "en-US", "men-shirt" },
                    { 4, 4, "Women Shirt", 2, "Women Shirt", "en-US", "women-shirt" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "ProductTranslations",
                columns: new[] { "ProductTranslationId", "AppSeoId", "Description", "Details", "LanguageId", "Name", "ProductId", "SeoAlias" },
                values: new object[,]
                {
                    { 1, 5, "Áo sơ mi nam trắng Việt Tiến", "Áo sơ mi nam trắng Việt Tiến", "vi-VN", "Áo sơ mi nam trắng Việt Tiến", 1, "ao-so-mi-nam-trang-viet-tien" },
                    { 2, 6, "Viet Tien Men T-Shirt", "Viet Tien Men T-Shirt", "en-US", "Viet Tien Men T-Shirt", 1, "viet-tien-men-t-shirt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeDescription");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeKeyword");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeTitle");

            migrationBuilder.DeleteData(
                table: "AppSeos",
                keyColumn: "AppSeoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AppSeos",
                keyColumn: "AppSeoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AppSeos",
                keyColumn: "AppSeoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AppSeos",
                keyColumn: "AppSeoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AppSeos",
                keyColumn: "AppSeoId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AppSeos",
                keyColumn: "AppSeoId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "CategoryTranslationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "CategoryTranslationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "CategoryTranslationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "CategoryTranslationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "ProductTranslationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "ProductTranslationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "en-US");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "vi-VN");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CrDateTime",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 23, 15, 19, 21, 967, DateTimeKind.Local).AddTicks(6554),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 8, 23, 15, 41, 18, 641, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CrDateTime",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 23, 15, 19, 21, 953, DateTimeKind.Local).AddTicks(7063),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 8, 23, 15, 41, 18, 627, DateTimeKind.Local).AddTicks(4457));
        }
    }
}
