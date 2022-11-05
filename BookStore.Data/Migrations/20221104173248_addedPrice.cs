using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Data.Migrations
{
    public partial class addedPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookGenre = table.Column<int>(type: "int", nullable: false),
                    BestSeller = table.Column<bool>(type: "bit", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BookId", "DateOfBirth", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(1992, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amir", "Shakur" },
                    { 2, 1, new DateTime(1962, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alli", "Rulby" },
                    { 3, 5, new DateTime(1990, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hobbs", "Tru" },
                    { 4, 2, new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "William", "Davids" },
                    { 5, 3, new DateTime(1964, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dan", "Sinns" },
                    { 6, 8, new DateTime(1996, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Connel", "MonRoe" },
                    { 7, 5, new DateTime(1990, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ruth", "Pennylop" },
                    { 8, 1, new DateTime(1980, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jenkins", "snyder" },
                    { 9, 4, new DateTime(1985, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akin", "Brown" },
                    { 10, 7, new DateTime(1991, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avila", "Lawren" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "BestSeller", "BookGenre", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, 1, true, 2, 60, new DateTime(2002, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heroes of Dawn" },
                    { 2, 3, true, 0, 65, new DateTime(2010, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Goal With Money" },
                    { 3, 1, false, 1, 90, new DateTime(1999, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blacksmiths And Butcher" },
                    { 4, 1, true, 2, 55, new DateTime(2007, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Altering The West" },
                    { 5, 4, false, 0, 75, new DateTime(2013, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inventing The Void" },
                    { 6, 1, false, 1, 65, new DateTime(2006, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Traitor of The Banish" },
                    { 7, 8, true, 0, 65, new DateTime(2003, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crossbow of Ashwas" },
                    { 8, 3, false, 2, 85, new DateTime(2000, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heroes of America" },
                    { 9, 1, true, 0, 115, new DateTime(2015, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dawn of Apes" },
                    { 10, 7, false, 1, 65, new DateTime(2017, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vampires Tale" },
                    { 11, 7, false, 1, 45, new DateTime(2017, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vampires Tale" },
                    { 12, 1, true, 2, 15, new DateTime(2019, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "UnHoly Truth" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
