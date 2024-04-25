using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastroPessoas.Migrations
{
    public partial class NomeDaMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SituacaoCadastral",
                table: "Pessoas",
                type: "int",
                nullable: false,
                defaultValue: 0,
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
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
