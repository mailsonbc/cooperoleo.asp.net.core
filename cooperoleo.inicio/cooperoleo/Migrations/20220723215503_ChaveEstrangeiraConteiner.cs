using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cooperoleo.Migrations
{
    public partial class ChaveEstrangeiraConteiner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Condominio_ConteinerId",
                table: "Condominio",
                column: "ConteinerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Condominio_Conteineres_ConteinerId",
                table: "Condominio",
                column: "ConteinerId",
                principalTable: "Conteineres",
                principalColumn: "ConteinerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Condominio_Conteineres_ConteinerId",
                table: "Condominio");

            migrationBuilder.DropIndex(
                name: "IX_Condominio_ConteinerId",
                table: "Condominio");
        }
    }
}
