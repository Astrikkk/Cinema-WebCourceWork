using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaApp2.Migrations
{
    /// <inheritdoc />
    public partial class _004 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgURL",
                table: "Films",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImgURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImgURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImgURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImgURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImgURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImgURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImgURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImgURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImgURL",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgURL",
                table: "Films");
        }
    }
}
