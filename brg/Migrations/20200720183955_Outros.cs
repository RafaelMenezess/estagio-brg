using Microsoft.EntityFrameworkCore.Migrations;

namespace brg.Migrations
{
    public partial class Outros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trilha_Colaborador_ColaboradorId",
                table: "Trilha");

            migrationBuilder.DropForeignKey(
                name: "FK_Trilha_Habilidade_HabilidadeId",
                table: "Trilha");

            migrationBuilder.AlterColumn<int>(
                name: "HabilidadeId",
                table: "Trilha",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ColaboradorId",
                table: "Trilha",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Trilha_Colaborador_ColaboradorId",
                table: "Trilha",
                column: "ColaboradorId",
                principalTable: "Colaborador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trilha_Habilidade_HabilidadeId",
                table: "Trilha",
                column: "HabilidadeId",
                principalTable: "Habilidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trilha_Colaborador_ColaboradorId",
                table: "Trilha");

            migrationBuilder.DropForeignKey(
                name: "FK_Trilha_Habilidade_HabilidadeId",
                table: "Trilha");

            migrationBuilder.AlterColumn<int>(
                name: "HabilidadeId",
                table: "Trilha",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ColaboradorId",
                table: "Trilha",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Trilha_Colaborador_ColaboradorId",
                table: "Trilha",
                column: "ColaboradorId",
                principalTable: "Colaborador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trilha_Habilidade_HabilidadeId",
                table: "Trilha",
                column: "HabilidadeId",
                principalTable: "Habilidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
