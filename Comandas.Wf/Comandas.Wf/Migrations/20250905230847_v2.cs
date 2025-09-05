using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Comandas.Wf.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoCozinhaItem_PedidoCozinha_PedidoCozinhaId",
                table: "PedidoCozinhaItem");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoCozinhaItem_PedidoCozinha_PedidoCozinhaId",
                table: "PedidoCozinhaItem",
                column: "PedidoCozinhaId",
                principalTable: "PedidoCozinha",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoCozinhaItem_PedidoCozinha_PedidoCozinhaId",
                table: "PedidoCozinhaItem");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoCozinhaItem_PedidoCozinha_PedidoCozinhaId",
                table: "PedidoCozinhaItem",
                column: "PedidoCozinhaId",
                principalTable: "PedidoCozinha",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
