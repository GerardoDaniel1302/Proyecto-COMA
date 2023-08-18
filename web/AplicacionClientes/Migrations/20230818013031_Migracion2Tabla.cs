using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AplicacionClientes.Migrations
{
    /// <inheritdoc />
    public partial class Migracion2Tabla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Folio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Saldo = table.Column<int>(type: "int", nullable: false),
                    Fecha_facturacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha_creacion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Factura");
        }
    }
}
