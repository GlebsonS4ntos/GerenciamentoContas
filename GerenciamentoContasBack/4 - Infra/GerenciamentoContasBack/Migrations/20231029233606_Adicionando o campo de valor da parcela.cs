using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciamentoContasBack.Infra.Migrations
{
    public partial class Adicionandoocampodevalordaparcela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ValorParcela",
                table: "PagamentosMensais",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValorParcela",
                table: "PagamentosMensais");
        }
    }
}
