using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastroPessoas.Migrations
{
    public partial class EnumSituacaoInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SituacaoCadastral",
                table: "Pessoas",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(2)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SituacaoCadastral",
                table: "Pessoas",
                type: "varchar(2)",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
