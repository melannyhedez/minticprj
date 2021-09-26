using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GranjaAvicolaD.app.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DatosInicioSesiones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pasword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Usuario_idId = table.Column<int>(type: "int", nullable: true),
                    Rol = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosInicioSesiones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DatosInicioSesiones_Usuarios_Usuario_idId",
                        column: x => x.Usuario_idId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Usuario_idId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registros_Usuarios_Usuario_idId",
                        column: x => x.Usuario_idId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sugerencia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario_idId = table.Column<int>(type: "int", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sugerencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sugerencia_Usuarios_Usuario_idId",
                        column: x => x.Usuario_idId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Galpones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroGallinas = table.Column<int>(type: "int", nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Operario_idId = table.Column<int>(type: "int", nullable: true),
                    Veterinario_idId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galpones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Galpones_DatosInicioSesiones_Operario_idId",
                        column: x => x.Operario_idId,
                        principalTable: "DatosInicioSesiones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Galpones_DatosInicioSesiones_Veterinario_idId",
                        column: x => x.Veterinario_idId,
                        principalTable: "DatosInicioSesiones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Historias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Temperatura = table.Column<float>(type: "real", nullable: false),
                    NivelAgua = table.Column<float>(type: "real", nullable: false),
                    CantidadAlimento = table.Column<float>(type: "real", nullable: false),
                    GallinasEnfermasPorCuarentena = table.Column<int>(type: "int", nullable: false),
                    Galpon_idId = table.Column<int>(type: "int", nullable: true),
                    Usuario_idId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historias_Galpones_Galpon_idId",
                        column: x => x.Galpon_idId,
                        principalTable: "Galpones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Historias_Usuarios_Usuario_idId",
                        column: x => x.Usuario_idId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DatosInicioSesiones_Usuario_idId",
                table: "DatosInicioSesiones",
                column: "Usuario_idId");

            migrationBuilder.CreateIndex(
                name: "IX_Galpones_Operario_idId",
                table: "Galpones",
                column: "Operario_idId");

            migrationBuilder.CreateIndex(
                name: "IX_Galpones_Veterinario_idId",
                table: "Galpones",
                column: "Veterinario_idId");

            migrationBuilder.CreateIndex(
                name: "IX_Historias_Galpon_idId",
                table: "Historias",
                column: "Galpon_idId");

            migrationBuilder.CreateIndex(
                name: "IX_Historias_Usuario_idId",
                table: "Historias",
                column: "Usuario_idId");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_Usuario_idId",
                table: "Registros",
                column: "Usuario_idId");

            migrationBuilder.CreateIndex(
                name: "IX_Sugerencia_Usuario_idId",
                table: "Sugerencia",
                column: "Usuario_idId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Historias");

            migrationBuilder.DropTable(
                name: "Registros");

            migrationBuilder.DropTable(
                name: "Sugerencia");

            migrationBuilder.DropTable(
                name: "Galpones");

            migrationBuilder.DropTable(
                name: "DatosInicioSesiones");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
