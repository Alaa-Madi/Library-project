using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookLIbrary12.Migrations
{
    public partial class CreateBooksLibrary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authers",
                columns: table => new
                {
                    autherID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Biography = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authers", x => x.autherID);
                });

            migrationBuilder.CreateTable(
                name: "Libraians",
                columns: table => new
                {
                    AddressID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Position = table.Column<int>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libraians", x => x.AddressID);
                });

            migrationBuilder.CreateTable(
                name: "Libraries",
                columns: table => new
                {
                    AddressID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libraries", x => x.AddressID);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    history = table.Column<string>(nullable: true),
                    date = table.Column<DateTime>(nullable: false),
                    state = table.Column<int>(nullable: false),
                    LibraryAddressID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountID);
                    table.ForeignKey(
                        name: "FK_Accounts_Libraries_LibraryAddressID",
                        column: x => x.LibraryAddressID,
                        principalTable: "Libraries",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Catalogs",
                columns: table => new
                {
                    CatalogID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    LibraryAddressID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogs", x => x.CatalogID);
                    table.ForeignKey(
                        name: "FK_Catalogs_Libraries_LibraryAddressID",
                        column: x => x.LibraryAddressID,
                        principalTable: "Libraries",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patrons",
                columns: table => new
                {
                    PatronID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    AccountID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patrons", x => x.PatronID);
                    table.ForeignKey(
                        name: "FK_Patrons_Accounts_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Accounts",
                        principalColumn: "AccountID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ISBNID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(nullable: true),
                    Summary = table.Column<string>(nullable: true),
                    publisher = table.Column<string>(nullable: true),
                    publicationDate = table.Column<DateTime>(nullable: false),
                    numberOfPage = table.Column<int>(nullable: false),
                    language = table.Column<string>(nullable: true),
                    LibraianAddressID = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    barcode = table.Column<string>(nullable: true),
                    tag = table.Column<int>(nullable: true),
                    isRefrenceOnly = table.Column<bool>(nullable: true),
                    CatalogID = table.Column<int>(nullable: true),
                    State = table.Column<int>(nullable: true),
                    AccountID = table.Column<int>(nullable: true),
                    LibraryAddressID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ISBNID);
                    table.ForeignKey(
                        name: "FK_Books_Libraians_LibraianAddressID",
                        column: x => x.LibraianAddressID,
                        principalTable: "Libraians",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Books_Accounts_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Accounts",
                        principalColumn: "AccountID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Books_Catalogs_CatalogID",
                        column: x => x.CatalogID,
                        principalTable: "Catalogs",
                        principalColumn: "CatalogID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Books_Libraries_LibraryAddressID",
                        column: x => x.LibraryAddressID,
                        principalTable: "Libraries",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookAuthers",
                columns: table => new
                {
                    ISBNID = table.Column<int>(nullable: false),
                    autherID = table.Column<int>(nullable: false),
                    BookISBNID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthers", x => new { x.ISBNID, x.autherID });
                    table.ForeignKey(
                        name: "FK_BookAuthers_Books_BookISBNID",
                        column: x => x.BookISBNID,
                        principalTable: "Books",
                        principalColumn: "ISBNID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookAuthers_Authers_autherID",
                        column: x => x.autherID,
                        principalTable: "Authers",
                        principalColumn: "autherID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_LibraryAddressID",
                table: "Accounts",
                column: "LibraryAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthers_BookISBNID",
                table: "BookAuthers",
                column: "BookISBNID");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthers_autherID",
                table: "BookAuthers",
                column: "autherID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_LibraianAddressID",
                table: "Books",
                column: "LibraianAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AccountID",
                table: "Books",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CatalogID",
                table: "Books",
                column: "CatalogID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_LibraryAddressID",
                table: "Books",
                column: "LibraryAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Catalogs_LibraryAddressID",
                table: "Catalogs",
                column: "LibraryAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Patrons_AccountID",
                table: "Patrons",
                column: "AccountID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookAuthers");

            migrationBuilder.DropTable(
                name: "Patrons");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authers");

            migrationBuilder.DropTable(
                name: "Libraians");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Catalogs");

            migrationBuilder.DropTable(
                name: "Libraries");
        }
    }
}
