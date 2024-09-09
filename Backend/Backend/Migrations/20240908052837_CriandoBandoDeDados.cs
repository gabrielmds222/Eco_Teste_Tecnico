using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class CriandoBandoDeDados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contribuintes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contribuintes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mensageiros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    senha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensageiros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPagamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPagamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contribuicao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Recibo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataPrevista = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdMensageiro = table.Column<int>(type: "int", nullable: false),
                    MensageiroId = table.Column<int>(type: "int", nullable: false),
                    IdTipoPagamento = table.Column<int>(type: "int", nullable: false),
                    TipoPagamentoId = table.Column<int>(type: "int", nullable: false),
                    IdContribuinte = table.Column<int>(type: "int", nullable: false),
                    ContribuinteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contribuicao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contribuicao_Contribuintes_ContribuinteId",
                        column: x => x.ContribuinteId,
                        principalTable: "Contribuintes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contribuicao_Mensageiros_MensageiroId",
                        column: x => x.MensageiroId,
                        principalTable: "Mensageiros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contribuicao_TipoPagamentos_TipoPagamentoId",
                        column: x => x.TipoPagamentoId,
                        principalTable: "TipoPagamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovimentoDiario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Recibo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataMovimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataPrevista = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataRecebimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdMensageiro = table.Column<int>(type: "int", nullable: false),
                    MensageiroId = table.Column<int>(type: "int", nullable: false),
                    IdTipoPagamento = table.Column<int>(type: "int", nullable: false),
                    TipoPagamentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovimentoDiario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovimentoDiario_Mensageiros_MensageiroId",
                        column: x => x.MensageiroId,
                        principalTable: "Mensageiros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovimentoDiario_TipoPagamentos_TipoPagamentoId",
                        column: x => x.TipoPagamentoId,
                        principalTable: "TipoPagamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contribuicao_ContribuinteId",
                table: "Contribuicao",
                column: "ContribuinteId");

            migrationBuilder.CreateIndex(
                name: "IX_Contribuicao_MensageiroId",
                table: "Contribuicao",
                column: "MensageiroId");

            migrationBuilder.CreateIndex(
                name: "IX_Contribuicao_TipoPagamentoId",
                table: "Contribuicao",
                column: "TipoPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_MovimentoDiario_MensageiroId",
                table: "MovimentoDiario",
                column: "MensageiroId");

            migrationBuilder.CreateIndex(
                name: "IX_MovimentoDiario_TipoPagamentoId",
                table: "MovimentoDiario",
                column: "TipoPagamentoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contribuicao");

            migrationBuilder.DropTable(
                name: "MovimentoDiario");

            migrationBuilder.DropTable(
                name: "Contribuintes");

            migrationBuilder.DropTable(
                name: "Mensageiros");

            migrationBuilder.DropTable(
                name: "TipoPagamentos");
        }
    }
}
