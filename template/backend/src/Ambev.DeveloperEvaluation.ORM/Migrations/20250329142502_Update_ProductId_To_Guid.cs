using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ambev.DeveloperEvaluation.ORM.Migrations
{
    /// <inheritdoc />
    public partial class Update_ProductId_To_Guid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Criar uma nova coluna temporária como uuid
            migrationBuilder.AddColumn<Guid>(
                name: "ProductId_temp",
                table: "SalesItems",
                type: "uuid",
                nullable: true
            );

            // Copiar os valores convertendo para uuid manualmente
            migrationBuilder.Sql("UPDATE \"SalesItems\" SET \"ProductId_temp\" = gen_random_uuid();");

            // Remover a chave estrangeira e a coluna antiga
            migrationBuilder.DropForeignKey(
                name: "FK_SalesItems_Products_ProductId1",
                table: "SalesItems");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "SalesItems");

            // Renomear a coluna nova para o nome correto
            migrationBuilder.RenameColumn(
                name: "ProductId_temp",
                table: "SalesItems",
                newName: "ProductId"
            );

            // Criar índice novamente
            migrationBuilder.CreateIndex(
                name: "IX_SalesItems_ProductId",
                table: "SalesItems",
                column: "ProductId");

            // Adicionar a chave estrangeira de volta
            migrationBuilder.AddForeignKey(
                name: "FK_SalesItems_Products_ProductId",
                table: "SalesItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesItems_Products_ProductId",
                table: "SalesItems");

            migrationBuilder.DropIndex(
                name: "IX_SalesItems_ProductId",
                table: "SalesItems");

            migrationBuilder.AddColumn<int>(
                name: "ProductId_temp",
                table: "SalesItems",
                type: "integer",
                nullable: true
            );

            migrationBuilder.Sql("UPDATE \"SalesItems\" SET \"ProductId_temp\" = 0;");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "SalesItems");

            migrationBuilder.RenameColumn(
                name: "ProductId_temp",
                table: "SalesItems",
                newName: "ProductId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SalesItems_ProductId",
                table: "SalesItems",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesItems_Products_ProductId",
                table: "SalesItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
