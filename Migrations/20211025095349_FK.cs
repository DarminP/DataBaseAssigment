using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBaseAssigment.Migrations
{
    public partial class FK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LandlordId",
                table: "Apartments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Landlords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Landlords", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_LandlordId",
                table: "Apartments",
                column: "LandlordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartments_Landlords_LandlordId",
                table: "Apartments",
                column: "LandlordId",
                principalTable: "Landlords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartments_Landlords_LandlordId",
                table: "Apartments");

            migrationBuilder.DropTable(
                name: "Landlords");

            migrationBuilder.DropIndex(
                name: "IX_Apartments_LandlordId",
                table: "Apartments");

            migrationBuilder.DropColumn(
                name: "LandlordId",
                table: "Apartments");
        }
    }
}
