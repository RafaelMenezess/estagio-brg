using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace brg.Migrations
{
    public partial class Others : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Habilidade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trilha",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Prazo = table.Column<DateTime>(nullable: false),
                    ColaboradorId = table.Column<int>(nullable: true),
                    HabilidadeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trilha", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trilha_Colaborador_ColaboradorId",
                        column: x => x.ColaboradorId,
                        principalTable: "Colaborador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trilha_Habilidade_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "Habilidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trilha_ColaboradorId",
                table: "Trilha",
                column: "ColaboradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Trilha_HabilidadeId",
                table: "Trilha",
                column: "HabilidadeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trilha");

            migrationBuilder.DropTable(
                name: "Habilidade");
        }
    }
}
