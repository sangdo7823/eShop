using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class UpdateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CrDateTime",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 23, 15, 19, 21, 967, DateTimeKind.Local).AddTicks(6554),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 8, 23, 15, 12, 59, 983, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CrDateTime",
                table: "Contacts",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 23, 15, 19, 21, 953, DateTimeKind.Local).AddTicks(7063),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryDesc",
                table: "CategoryTranslations",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SeoKeyword",
                table: "AppSeos",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SeoDescription",
                table: "AppSeos",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "AppSeos",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Canonical",
                table: "AppSeos",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CrDateTime",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 23, 15, 12, 59, 983, DateTimeKind.Local).AddTicks(8514),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 8, 23, 15, 19, 21, 967, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CrDateTime",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 8, 23, 15, 19, 21, 953, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.AlterColumn<string>(
                name: "CategoryDesc",
                table: "CategoryTranslations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "SeoKeyword",
                table: "AppSeos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SeoDescription",
                table: "AppSeos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "AppSeos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Canonical",
                table: "AppSeos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);
        }
    }
}
