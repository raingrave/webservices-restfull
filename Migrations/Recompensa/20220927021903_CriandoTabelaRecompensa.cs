using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebServiceRestfull.Migrations.Recompensa
{
    public partial class CriandoTabelaRecompensa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RECOMPENSA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    EXERCICIOREALIZADO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    VALOR = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    TIPO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    REGISTRO = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RECOMPENSA", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RECOMPENSA");
        }
    }
}
