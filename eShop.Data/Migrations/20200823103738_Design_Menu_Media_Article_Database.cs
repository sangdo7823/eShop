using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class Design_Menu_Media_Article_Database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CrDateTime",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 23, 17, 37, 37, 369, DateTimeKind.Local).AddTicks(2473),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 8, 23, 15, 58, 45, 790, DateTimeKind.Local).AddTicks(9595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CrDateTime",
                table: "Contacts",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 23, 17, 37, 37, 348, DateTimeKind.Local).AddTicks(2857),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 8, 23, 15, 58, 45, 777, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.AddColumn<int>(
                name: "CategoryLevel",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataTypeId",
                table: "Categories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TreeOrder",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UrlRewriteType",
                table: "Categories",
                maxLength: 20,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    ArticleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ViewCount = table.Column<int>(nullable: false),
                    CrDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 8, 23, 17, 37, 37, 323, DateTimeKind.Local).AddTicks(1028)),
                    CrUserId = table.Column<int>(nullable: false),
                    UpDateTime = table.Column<DateTime>(nullable: true),
                    UpUserId = table.Column<int>(nullable: false),
                    DataTypeId = table.Column<int>(nullable: false),
                    PublishTime = table.Column<DateTime>(nullable: true),
                    DisplayOrder = table.Column<int>(nullable: false),
                    ShowTop = table.Column<int>(nullable: false),
                    ReviewStatusId = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.ArticleId);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuName = table.Column<string>(maxLength: 200, nullable: false),
                    MenuDesc = table.Column<string>(maxLength: 255, nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    CrUserId = table.Column<int>(nullable: false),
                    CrDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 8, 23, 17, 37, 37, 356, DateTimeKind.Local).AddTicks(8239))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuId);
                });

            migrationBuilder.CreateTable(
                name: "ProductMedias",
                columns: table => new
                {
                    ProductMediaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    MediaId = table.Column<int>(nullable: false),
                    FilePath = table.Column<string>(maxLength: 200, nullable: false),
                    MediaTypeId = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DisplayOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMedias", x => x.ProductMediaId);
                    table.ForeignKey(
                        name: "FK_ProductMedias_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticleInCategories",
                columns: table => new
                {
                    ArticleId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleInCategories", x => new { x.CategoryId, x.ArticleId });
                    table.ForeignKey(
                        name: "FK_ArticleInCategories_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleInCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticleMedias",
                columns: table => new
                {
                    ArticleMediaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleId = table.Column<int>(nullable: false),
                    MediaId = table.Column<int>(nullable: false),
                    MediaTypeId = table.Column<int>(nullable: true),
                    DisplayOrder = table.Column<int>(nullable: false),
                    FilePath = table.Column<int>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    CrUserId = table.Column<int>(nullable: false),
                    CrDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleMedias", x => x.ArticleMediaId);
                    table.ForeignKey(
                        name: "FK_ArticleMedias_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticleRelates",
                columns: table => new
                {
                    ArticleRelateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleId = table.Column<int>(nullable: false),
                    DisplayOrder = table.Column<int>(nullable: false),
                    ArticleReferenceId = table.Column<int>(nullable: false),
                    CrUserId = table.Column<int>(nullable: false),
                    CrDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 8, 23, 17, 37, 37, 335, DateTimeKind.Local).AddTicks(7521))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleRelates", x => x.ArticleRelateId);
                    table.ForeignKey(
                        name: "FK_ArticleRelates_Articles_ArticleReferenceId",
                        column: x => x.ArticleReferenceId,
                        principalTable: "Articles",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticleTranslations",
                columns: table => new
                {
                    ArticleTranslationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleId = table.Column<int>(nullable: false),
                    ArticleTitle = table.Column<string>(maxLength: 255, nullable: false),
                    ArticleSummary = table.Column<string>(maxLength: 2000, nullable: true),
                    ArticleContent = table.Column<string>(nullable: true),
                    AppSeoId = table.Column<int>(nullable: false),
                    SeoAlias = table.Column<string>(maxLength: 200, nullable: false),
                    LanguageId = table.Column<string>(unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleTranslations", x => x.ArticleTranslationId);
                    table.ForeignKey(
                        name: "FK_ArticleTranslations_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    MenuItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuId = table.Column<int>(nullable: false),
                    ItemName = table.Column<string>(maxLength: 200, nullable: false),
                    ItemDesc = table.Column<string>(maxLength: 255, nullable: true),
                    IconPath = table.Column<string>(maxLength: 255, nullable: true),
                    Url = table.Column<string>(maxLength: 255, nullable: true),
                    TreeOrder = table.Column<int>(nullable: false),
                    ParentItemId = table.Column<int>(nullable: false),
                    ItemLevel = table.Column<int>(nullable: false),
                    DisplayOrder = table.Column<int>(nullable: false),
                    ReviewStatusId = table.Column<int>(nullable: false, defaultValue: 2),
                    CrUserId = table.Column<int>(nullable: false),
                    CrDateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 8, 23, 17, 37, 37, 359, DateTimeKind.Local).AddTicks(2484))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.MenuItemId);
                    table.ForeignKey(
                        name: "FK_MenuItems_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { 1, "04fc2f20-f0be-4829-9636-410899438aad", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppSeos",
                columns: new[] { "AppSeoId", "Canonical", "ImagePath", "SeoDescription", "SeoKeyword", "SeoTitle" },
                values: new object[,]
                {
                    { 7, null, null, "Xin chào", "Xin chào", "Xin chào" },
                    { 8, null, null, "Wellcome", "Wellcome", "Wellcome" }
                });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDay", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, new DateTime(1991, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "2e0e3866-b520-41bd-a6de-5405fae8304c", "teamsoft91@gmail.com", true, "Sang", "Do", false, null, "sangdo.eng@gmail.com", "admin", "AQAAAAEAACcQAAAAELAArSh/6G4gp++HvZFZRjmlocw4qO69g7XWZC98TygMOnsEoLl5YMaLDF8VNHolXQ==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "CrDateTime", "CrUserId", "DataTypeId", "DisplayOrder", "PublishTime", "ShowTop", "UpDateTime", "UpUserId", "ViewCount" },
                values: new object[] { 1, new DateTime(2020, 8, 23, 17, 37, 37, 415, DateTimeKind.Local).AddTicks(5646), 0, 0, 0, null, 0, null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DataTypeId", "ReviewStatusId", "UrlRewriteType" },
                values: new object[] { 1, 2, "product" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DataTypeId", "UrlRewriteType" },
                values: new object[] { 1, "product" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryLevel", "DataTypeId", "DisplayOrder", "IsShowHome", "ParentId", "TreeOrder", "UrlRewriteType" },
                values: new object[] { 3, null, 0, 3, true, null, null, "article" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CrDateTime",
                value: new DateTime(2020, 8, 23, 17, 37, 37, 414, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.InsertData(
                table: "ArticleInCategories",
                columns: new[] { "CategoryId", "ArticleId" },
                values: new object[] { 3, 1 });

            migrationBuilder.InsertData(
                table: "ArticleTranslations",
                columns: new[] { "ArticleTranslationId", "AppSeoId", "ArticleContent", "ArticleId", "ArticleSummary", "ArticleTitle", "LanguageId", "SeoAlias" },
                values: new object[] { 2, 7, "Wellcome", 1, "Wellcome", "Wellcome", "en-US", "wellcome" });

            migrationBuilder.InsertData(
                table: "ArticleTranslations",
                columns: new[] { "ArticleTranslationId", "AppSeoId", "ArticleContent", "ArticleId", "ArticleSummary", "ArticleTitle", "LanguageId", "SeoAlias" },
                values: new object[] { 1, 7, "Xin chào", 1, "Xin chào", "Xin chào", "vi-VN", "xin-chao" });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleInCategories_ArticleId",
                table: "ArticleInCategories",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleMedias_ArticleId",
                table: "ArticleMedias",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleRelates_ArticleReferenceId",
                table: "ArticleRelates",
                column: "ArticleReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleTranslations_ArticleId",
                table: "ArticleTranslations",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleTranslations_LanguageId",
                table: "ArticleTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_MenuId",
                table: "MenuItems",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMedias_ProductId",
                table: "ProductMedias",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleInCategories");

            migrationBuilder.DropTable(
                name: "ArticleMedias");

            migrationBuilder.DropTable(
                name: "ArticleRelates");

            migrationBuilder.DropTable(
                name: "ArticleTranslations");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "ProductMedias");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AppSeos",
                keyColumn: "AppSeoId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AppSeos",
                keyColumn: "AppSeoId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "CategoryLevel",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DataTypeId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "TreeOrder",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "UrlRewriteType",
                table: "Categories");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CrDateTime",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 23, 15, 58, 45, 790, DateTimeKind.Local).AddTicks(9595),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 8, 23, 17, 37, 37, 369, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CrDateTime",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 23, 15, 58, 45, 777, DateTimeKind.Local).AddTicks(6952),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 8, 23, 17, 37, 37, 348, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    ProductImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.ProductImageId);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "ReviewStatusId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CrDateTime",
                value: new DateTime(2020, 8, 23, 15, 58, 45, 806, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }
    }
}
