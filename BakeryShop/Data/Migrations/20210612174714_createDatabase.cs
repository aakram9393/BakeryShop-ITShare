using Microsoft.EntityFrameworkCore.Migrations;

namespace BakeryShop.Data.Migrations
{
    public partial class createDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Describtion = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    ImageFileName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Describtion", "ImageFileName", "Name", "Price" },
                values: new object[] { 1, "Carrot Cake Any Description", "carrot_cake.jpg", "Carrot Cake", 0m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Describtion", "ImageFileName", "Name", "Price" },
                values: new object[] { 2, "Bread Any Description", "bread.jpg", "Bread", 0m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Describtion", "ImageFileName", "Name", "Price" },
                values: new object[] { 3, "Chocolate Cake Any Description", "chocolate_cake.jpg", "Chocolate Cake", 0m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Describtion", "ImageFileName", "Name", "Price" },
                values: new object[] { 4, "Cup Cake Any Description", "cup_cake.jpg", "Cup Cake", 0m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Describtion", "ImageFileName", "Name", "Price" },
                values: new object[] { 5, "Lemon Tart Any Description", "lemon_tart.jpg", "Lemon Tart", 0m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Describtion", "ImageFileName", "Name", "Price" },
                values: new object[] { 6, "Pear Tart Any Description", "pear_tart.jpg", "Pear Tart", 0m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
