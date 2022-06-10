using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Locadora.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TabelaDeConta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Saldo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaDeConta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TabelaDeFilme",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    Valor = table.Column<int>(nullable: false),
                    Titulo = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Duracao = table.Column<int>(nullable: false),
                    QuantidadeDeOscars = table.Column<int>(nullable: false),
                    IdFilme = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaDeFilme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TabelaDeSerie",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    Valor = table.Column<int>(nullable: false),
                    Titulo = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Temporadas = table.Column<int>(nullable: false),
                    Emmies = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaDeSerie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TabelaDeUsuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Idade = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    ContaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaDeUsuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TabelaDeUsuario_TabelaDeConta_ContaId",
                        column: x => x.ContaId,
                        principalTable: "TabelaDeConta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TabelaDeUsuario_ContaId",
                table: "TabelaDeUsuario",
                column: "ContaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TabelaDeFilme");

            migrationBuilder.DropTable(
                name: "TabelaDeSerie");

            migrationBuilder.DropTable(
                name: "TabelaDeUsuario");

            migrationBuilder.DropTable(
                name: "TabelaDeConta");
        }
    }
}
