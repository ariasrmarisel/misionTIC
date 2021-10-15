using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoCiclo3.App.Persistencia.Migrations
{
    public partial class Migra13102021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "destino",
                table: "Servicios");

            migrationBuilder.DropColumn(
                name: "encomienda",
                table: "Servicios");

            migrationBuilder.DropColumn(
                name: "origen",
                table: "Servicios");

            migrationBuilder.AddColumn<int>(
                name: "destinoid",
                table: "Servicios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "encomiendaid",
                table: "Servicios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "origenid",
                table: "Servicios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_destinoid",
                table: "Servicios",
                column: "destinoid");

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_encomiendaid",
                table: "Servicios",
                column: "encomiendaid");

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_origenid",
                table: "Servicios",
                column: "origenid");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_Encomiendas_encomiendaid",
                table: "Servicios",
                column: "encomiendaid",
                principalTable: "Encomiendas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_Usuarios_destinoid",
                table: "Servicios",
                column: "destinoid",
                principalTable: "Usuarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_Usuarios_origenid",
                table: "Servicios",
                column: "origenid",
                principalTable: "Usuarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_Encomiendas_encomiendaid",
                table: "Servicios");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_Usuarios_destinoid",
                table: "Servicios");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_Usuarios_origenid",
                table: "Servicios");

            migrationBuilder.DropIndex(
                name: "IX_Servicios_destinoid",
                table: "Servicios");

            migrationBuilder.DropIndex(
                name: "IX_Servicios_encomiendaid",
                table: "Servicios");

            migrationBuilder.DropIndex(
                name: "IX_Servicios_origenid",
                table: "Servicios");

            migrationBuilder.DropColumn(
                name: "destinoid",
                table: "Servicios");

            migrationBuilder.DropColumn(
                name: "encomiendaid",
                table: "Servicios");

            migrationBuilder.DropColumn(
                name: "origenid",
                table: "Servicios");

            migrationBuilder.AddColumn<int>(
                name: "destino",
                table: "Servicios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "encomienda",
                table: "Servicios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "origen",
                table: "Servicios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
