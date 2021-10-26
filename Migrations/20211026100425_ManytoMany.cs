using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBaseAssigment.Migrations
{
    public partial class ManytoMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ApartmentApplicants",
                table: "ApartmentApplicants");

            migrationBuilder.DropIndex(
                name: "IX_ApartmentApplicants_ApartmentId",
                table: "ApartmentApplicants");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ApartmentApplicants");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApartmentApplicants",
                table: "ApartmentApplicants",
                columns: new[] { "ApartmentId", "ApplicantId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ApartmentApplicants",
                table: "ApartmentApplicants");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ApartmentApplicants",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApartmentApplicants",
                table: "ApartmentApplicants",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentApplicants_ApartmentId",
                table: "ApartmentApplicants",
                column: "ApartmentId");
        }
    }
}
