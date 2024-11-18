using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlataformaEficienciaEnergetica.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Predios",
                columns: table => new
                {
                    PredioId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    ConsumoEnergetico = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    UsoEnergiaRenovavel = table.Column<double>(type: "BINARY_DOUBLE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Predios", x => x.PredioId);
                });

            migrationBuilder.CreateTable(
                name: "DadosEnergia",
                columns: table => new
                {
                    DadosEnergiaId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    PredioId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ConsumoTotal = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    Data = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DadosEnergia", x => x.DadosEnergiaId);
                    table.ForeignKey(
                        name: "FK_DadosEnergia_Predios_PredioId",
                        column: x => x.PredioId,
                        principalTable: "Predios",
                        principalColumn: "PredioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DadosEnergia_PredioId",
                table: "DadosEnergia",
                column: "PredioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DadosEnergia");

            migrationBuilder.DropTable(
                name: "Predios");
        }
    }
}
