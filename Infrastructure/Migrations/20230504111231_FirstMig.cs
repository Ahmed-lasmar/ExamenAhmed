using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FirstMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conseilleur",
                columns: table => new
                {
                    ConseilleurId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conseilleur", x => x.ConseilleurId);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Identifiant = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ConseilleurFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Identifiant);
                    table.ForeignKey(
                        name: "FK_Client_Conseilleur_ConseilleurFK",
                        column: x => x.ConseilleurFK,
                        principalTable: "Conseilleur",
                        principalColumn: "ConseilleurId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_ConseilleurFK",
                table: "Client",
                column: "ConseilleurFK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Conseilleur");
        }
    }
}
