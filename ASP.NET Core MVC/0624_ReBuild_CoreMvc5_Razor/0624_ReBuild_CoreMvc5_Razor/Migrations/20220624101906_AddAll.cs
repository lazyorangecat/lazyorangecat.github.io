using Microsoft.EntityFrameworkCore.Migrations;

namespace _0624_ReBuild_CoreMvc5_Razor.Migrations
{
    public partial class AddAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chinese = table.Column<int>(type: "int", nullable: false),
                    English = table.Column<int>(type: "int", nullable: false),
                    Mathematics = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentTable", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "StudentTable",
                columns: new[] { "Id", "Chinese", "English", "Mathematics", "Name" },
                values: new object[,]
                {
                    { 1, 88, 95, 71, "Joe" },
                    { 12, 88, 95, 71, "Aoe" },
                    { 11, 88, 95, 71, "Eoe" },
                    { 14, 88, 95, 71, "Voe" },
                    { 16, 88, 95, 71, "Doe" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentTable");
        }
    }
}
