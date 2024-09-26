using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_Lg.Migrations
{
    /// <inheritdoc />
    public partial class dsa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfPorts",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RouterProduct_Model",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RouterProduct_ip",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Speed",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfPorts",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "RouterProduct_Model",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "RouterProduct_ip",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Speed",
                table: "Products");
        }
    }
}
