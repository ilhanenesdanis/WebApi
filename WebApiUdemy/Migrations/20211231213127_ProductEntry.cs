using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiUdemy.Migrations
{
    public partial class ProductEntry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreateDate", "ImagePath", "Name", "Perice", "Stock" },
                values: new object[] { 1, new DateTime(2021, 12, 29, 0, 31, 26, 944, DateTimeKind.Local).AddTicks(6148), null, "Bilgisayar", 15500m, 300 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreateDate", "ImagePath", "Name", "Perice", "Stock" },
                values: new object[] { 2, new DateTime(2021, 12, 2, 0, 31, 26, 945, DateTimeKind.Local).AddTicks(4304), null, "Monitör", 2899m, 100 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreateDate", "ImagePath", "Name", "Perice", "Stock" },
                values: new object[] { 3, new DateTime(2021, 11, 2, 0, 31, 26, 945, DateTimeKind.Local).AddTicks(4330), null, "Klavye", 158m, 52 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
