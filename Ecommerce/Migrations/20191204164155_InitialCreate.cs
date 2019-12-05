using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EComercial.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    product_name = table.Column<string>(nullable: true),
                    product_price = table.Column<int>(nullable: false),
                    product_description = table.Column<string>(nullable: true),
                    product_image = table.Column<string>(nullable: true),
                    ExpiredDateTime = table.Column<DateTime>(nullable: false),
                    quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
