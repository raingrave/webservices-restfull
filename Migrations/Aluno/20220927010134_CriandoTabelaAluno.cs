using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebServiceRestfull.Migrations.Aluno
{
    public partial class CriandoTabelaAluno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ALUNO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NOME = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    IDADE = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ALTURA = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    PESO = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    GENERO = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ALUNO", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ALUNO");
        }
    }
}
