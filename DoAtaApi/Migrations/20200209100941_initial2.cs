using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DoAtaApi.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsComplete",
                table: "DoAtaItems");

            migrationBuilder.AddColumn<int>(
                name: "Day",
                table: "DoAtaItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Month",
                table: "DoAtaItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "DoAtaItems",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "DoAtaItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoAtaItems_TypeId",
                table: "DoAtaItems",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_DoAtaItems_Types_TypeId",
                table: "DoAtaItems",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoAtaItems_Types_TypeId",
                table: "DoAtaItems");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropIndex(
                name: "IX_DoAtaItems_TypeId",
                table: "DoAtaItems");

            migrationBuilder.DropColumn(
                name: "Day",
                table: "DoAtaItems");

            migrationBuilder.DropColumn(
                name: "Month",
                table: "DoAtaItems");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "DoAtaItems");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "DoAtaItems");

            migrationBuilder.AddColumn<bool>(
                name: "IsComplete",
                table: "DoAtaItems",
                nullable: false,
                defaultValue: false);
        }
    }
}
