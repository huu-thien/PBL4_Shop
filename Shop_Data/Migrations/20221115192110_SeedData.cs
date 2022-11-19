using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop_Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SeoAlias",
                table: "Products",
                newName: "DateCreated");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "ProductTranslations",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 500);

            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "HomeDescription", "This is description of PBL4: Shop" },
                    { "HomeKeyword", "This is keyword of PBL4: Shop" },
                    { "HomeTitle", "This is home page of PBL4: Shop" }
                });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "40eb800a-5a8f-4666-a111-2a6c3c2cb76e", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "c2c988e8-8182-4ca9-a575-55232093bee0", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Thien", "Nguyen", false, null, "admin@gmail.com", "admin", "AQAAAAEAACcQAAAAEGwMB4tpx8izb8dEmNuhwjX8c/THp+MOA3QWsDlB9LYzzqFLTDsnWdwJC2FExqIFCw==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsShowOnHome", "ParentID", "SortOrder", "Status" },
                values: new object[,]
                {
                    { 1, true, null, 1, 1 },
                    { 2, true, null, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "IsDefault", "Name" },
                values: new object[,]
                {
                    { "en", false, "English" },
                    { "vi", true, "Tiếng Việt" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateCreated", "OriginalPrice", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2022, 11, 16, 2, 21, 10, 570, DateTimeKind.Local).AddTicks(7464), 15000000m, 20000000m, 5 });

            migrationBuilder.InsertData(
                table: "CategoryTranslations",
                columns: new[] { "Id", "CategoryId", "LanguageId", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, 1, "vi", "Máy tính xách tay", "may-tinh-xach-tay", "Sản phẩm máy tính xách tay", "Sản phẩm máy tính xách tay" },
                    { 2, 1, "en", "Laptop", "lap-top", "The laptop product", "The laptop product" },
                    { 3, 2, "vi", "Điện thoại di động", "dien-thoai-di-dong", "Sản phẩm điện thoại di động", "Sản phẩm điện thoại di động" },
                    { 4, 2, "en", "Smart Phone", "smart-phone", "The Smart Phone product", "The Smart Phone product" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "ProductTranslations",
                columns: new[] { "Id", "Description", "Details", "LanguageId", "Name", "ProductId", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, "Laptop Gaming GIGABYTE G5 GD-51VN123SO i5-11400H/16GB/512GB/RTX3050/15.6", "Laptop Gaming GIGABYTE G5 GD-51VN123SO i5-11400H/16GB/512GB/RTX3050/15.6", "vi", "Laptop Gaming GIGABYTE G5 GD-51VN123SO i5-11400H/16GB/512GB/RTX3050/15.6", 1, "lap-top-gaming-gigabyte-g5-51vn1235so", "Laptop Gaming GIGABYTE G5 GD-51VN123SO i5-11400H/16GB/512GB/RTX3050/15.6", "Laptop Gaming GIGABYTE G5 GD-51VN123SO i5-11400H/16GB/512GB/RTX3050/15.6" },
                    { 2, "Samsung Galaxy A73 5G", "Samsung Galaxy A73 5G", "en", "Samsung Galaxy A73 5G", 1, "samsung-galaxy-a73-5g", "Samsung Galaxy A73 5G", "Samsung Galaxy A73 5G" }
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
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "en");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "vi");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Products",
                newName: "SeoAlias");

            migrationBuilder.AlterColumn<decimal>(
                name: "Details",
                table: "ProductTranslations",
                type: "decimal(18,2)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);
        }
    }
}
