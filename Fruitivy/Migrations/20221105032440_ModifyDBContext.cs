using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Fruitivy.Migrations
{
    public partial class ModifyDBContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "penjual",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Username = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Alamat = table.Column<string>(type: "text", nullable: false),
                    NoHp = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_penjual", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "produk",
                columns: table => new
                {
                    ProdukId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nama = table.Column<string>(type: "text", nullable: false),
                    Picture = table.Column<byte[]>(type: "bytea", nullable: false),
                    Stok = table.Column<int>(type: "integer", nullable: false),
                    Harga = table.Column<int>(type: "integer", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produk", x => x.ProdukId);
                    table.ForeignKey(
                        name: "FK_produk_penjual_Id",
                        column: x => x.Id,
                        principalTable: "penjual",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "transaksi",
                columns: table => new
                {
                    TransaksiId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TotalHarga = table.Column<double>(type: "double precision", nullable: false),
                    Tanggal = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Stok = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    ProdukId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaksi", x => x.TransaksiId);
                    table.ForeignKey(
                        name: "FK_transaksi_pembeli_Id",
                        column: x => x.Id,
                        principalTable: "pembeli",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transaksi_produk_ProdukId",
                        column: x => x.ProdukId,
                        principalTable: "produk",
                        principalColumn: "ProdukId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_produk_Id",
                table: "produk",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_transaksi_Id",
                table: "transaksi",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_transaksi_ProdukId",
                table: "transaksi",
                column: "ProdukId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "transaksi");

            migrationBuilder.DropTable(
                name: "produk");

            migrationBuilder.DropTable(
                name: "penjual");
        }
    }
}
