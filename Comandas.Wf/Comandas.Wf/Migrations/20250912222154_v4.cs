using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Comandas.Wf.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PerfilUsuarioId",
                table: "Usuario",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PerfilUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descricao = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerfilUsuario", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PerfilUsuarioId",
                table: "Usuario",
                column: "PerfilUsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_PerfilUsuario_PerfilUsuarioId",
                table: "Usuario",
                column: "PerfilUsuarioId",
                principalTable: "PerfilUsuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_PerfilUsuario_PerfilUsuarioId",
                table: "Usuario");

            migrationBuilder.DropTable(
                name: "PerfilUsuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_PerfilUsuarioId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "PerfilUsuarioId",
                table: "Usuario");
        }
    }
}
