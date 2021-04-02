using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XPTO.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "xpto");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                schema: "xpto",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 120, nullable: false),
                    RG = table.Column<string>(maxLength: 20, nullable: false),
                    CPF = table.Column<string>(maxLength: 11, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "CategoriaAtivos",
                schema: "xpto",
                columns: table => new
                {
                    CategoriaAtivoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 150, nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaAtivos", x => x.CategoriaAtivoId);
                    table.ForeignKey(
                        name: "FK_CategoriaAtivos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalSchema: "xpto",
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ativos",
                schema: "xpto",
                columns: table => new
                {
                    AtivoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ticker = table.Column<string>(maxLength: 10, nullable: false),
                    CategoriaAtivoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ativos", x => x.AtivoId);
                    table.ForeignKey(
                        name: "FK_Ativos_CategoriaAtivos_CategoriaAtivoId",
                        column: x => x.CategoriaAtivoId,
                        principalSchema: "xpto",
                        principalTable: "CategoriaAtivos",
                        principalColumn: "CategoriaAtivoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompraAtivos",
                schema: "xpto",
                columns: table => new
                {
                    CompraAtivoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCompra = table.Column<DateTime>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    ValorUnitario = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    AtivoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompraAtivos", x => x.CompraAtivoId);
                    table.ForeignKey(
                        name: "FK_CompraAtivos_Ativos_AtivoId",
                        column: x => x.AtivoId,
                        principalSchema: "xpto",
                        principalTable: "Ativos",
                        principalColumn: "AtivoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VendaAtivos",
                schema: "xpto",
                columns: table => new
                {
                    VendaAtivoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataVenda = table.Column<DateTime>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    ValorUnitario = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    AtivoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendaAtivos", x => x.VendaAtivoId);
                    table.ForeignKey(
                        name: "FK_VendaAtivos_Ativos_AtivoId",
                        column: x => x.AtivoId,
                        principalSchema: "xpto",
                        principalTable: "Ativos",
                        principalColumn: "AtivoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ativos_CategoriaAtivoId",
                schema: "xpto",
                table: "Ativos",
                column: "CategoriaAtivoId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaAtivos_UsuarioId",
                schema: "xpto",
                table: "CategoriaAtivos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CompraAtivos_AtivoId",
                schema: "xpto",
                table: "CompraAtivos",
                column: "AtivoId");

            migrationBuilder.CreateIndex(
                name: "IX_VendaAtivos_AtivoId",
                schema: "xpto",
                table: "VendaAtivos",
                column: "AtivoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompraAtivos",
                schema: "xpto");

            migrationBuilder.DropTable(
                name: "VendaAtivos",
                schema: "xpto");

            migrationBuilder.DropTable(
                name: "Ativos",
                schema: "xpto");

            migrationBuilder.DropTable(
                name: "CategoriaAtivos",
                schema: "xpto");

            migrationBuilder.DropTable(
                name: "Usuarios",
                schema: "xpto");
        }
    }
}
