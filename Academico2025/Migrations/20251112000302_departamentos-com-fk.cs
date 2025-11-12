using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academico2025.Migrations
{
    /// <inheritdoc />
    public partial class departamentoscomfk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InstituicaoId",
                table: "Departamentos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InstuicaoId",
                table: "Departamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_InstituicaoId",
                table: "Departamentos",
                column: "InstituicaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departamentos_Instituicoes_InstituicaoId",
                table: "Departamentos",
                column: "InstituicaoId",
                principalTable: "Instituicoes",
                principalColumn: "InstituicaoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departamentos_Instituicoes_InstituicaoId",
                table: "Departamentos");

            migrationBuilder.DropIndex(
                name: "IX_Departamentos_InstituicaoId",
                table: "Departamentos");

            migrationBuilder.DropColumn(
                name: "InstituicaoId",
                table: "Departamentos");

            migrationBuilder.DropColumn(
                name: "InstuicaoId",
                table: "Departamentos");
        }
    }
}
