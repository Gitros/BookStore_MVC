using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddProductToDbAndSeedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Andrzej Sapkowski", "The book narrates the adventures of Geralt of Rivia, a Witcher - a monster hunter and slayer. The series of stories showcases a dark and mysterious world where magic, monsters, and political intrigue intertwine.", "9788382951486", 90.0, 70.0, 30.0, 50.0, "The Witcher" },
                    { 2, "Sui Ishida", "One of the greatest horror series in manga history, the visceral Tokyo Ghoul introduces the shy Ken Kaneki, unwittingly transformed into a half-human, half-ghoul hybrid after a first date goes seriously wrong. Ghouls live among us, the same as normal people in every way - except their craving for human flesh.", "9788382951486", 50.0, 40.0, 30.0, 35.0, "Tokyo ghoul" },
                    { 3, "J.K. Rowling", "Harry Potter is a series of seven fantasy novels written by British author J. K. Rowling. The novels chronicle the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are students at Hogwarts School of Witchcraft and Wizardry.", "9788382951486", 70.0, 60.0, 40.0, 55.0, "Harry Potter" },
                    { 4, "Black Holly", "The Earth contains the remains of those who perform, but this is only the beginning....\r\n\r\nThe first brutal murder, then the bloody massacre of the royal family and an unexpected coronation - but yes, that was just the beginning.", "1220475959", 80.0, 75.0, 45.0, 55.0, "Mad King" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
