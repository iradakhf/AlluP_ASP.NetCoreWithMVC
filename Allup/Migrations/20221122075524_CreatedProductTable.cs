using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Allup.Migrations
{
    public partial class CreatedProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(maxLength: 500, nullable: true),
                    Price = table.Column<double>(nullable: false),
                    DiscountedPrice = table.Column<double>(nullable: false),
                    ExTax = table.Column<double>(nullable: false),
                    Seria = table.Column<string>(maxLength: 4, nullable: true),
                    Code = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    MainImage = table.Column<string>(maxLength: 255, nullable: true),
                    HoverImage = table.Column<string>(maxLength: 255, nullable: true),
                    IsNewArrival = table.Column<bool>(nullable: false),
                    IsBestSeller = table.Column<bool>(nullable: false),
                    IsFeatured = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
