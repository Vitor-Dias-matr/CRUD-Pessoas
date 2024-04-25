using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastroPessoas.Migrations
{
    public partial class AlterarTipoPessoaParaInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                              name: "TipoPessoa",
                              table: "Pessoas",
                              nullable: true,
                              oldClrType: typeof(string),
                              oldType: "varchar(2)",
                              oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
