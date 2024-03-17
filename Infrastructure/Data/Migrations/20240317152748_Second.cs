using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoContribuyenteId1",
                table: "Contribuyentes",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contribuyentes_TipoContribuyenteId1",
                table: "Contribuyentes",
                column: "TipoContribuyenteId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Contribuyentes_TiposContribuyente_TipoContribuyenteId1",
                table: "Contribuyentes",
                column: "TipoContribuyenteId1",
                principalTable: "TiposContribuyente",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contribuyentes_TiposContribuyente_TipoContribuyenteId1",
                table: "Contribuyentes");

            migrationBuilder.DropIndex(
                name: "IX_Contribuyentes_TipoContribuyenteId1",
                table: "Contribuyentes");

            migrationBuilder.DropColumn(
                name: "TipoContribuyenteId1",
                table: "Contribuyentes");
        }
    }
}
