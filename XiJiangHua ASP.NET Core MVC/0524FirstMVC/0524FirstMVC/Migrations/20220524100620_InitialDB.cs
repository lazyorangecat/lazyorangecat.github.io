using Microsoft.EntityFrameworkCore.Migrations;

namespace _0524FirstMVC.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brief = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Brief", "Name", "Photo" },
                values: new object[,]
                {
                    { 1, "中華大學 觀光與會展活動學系 最愛南柱赫!!!!!", "李家萱", "https://raw.githubusercontent.com/JiaXuan1083/FileStorage/main/IMG_7403.JPG" },
                    { 2, "中華大學 生物資訊學系 打羽球", "廖培余", "https://raw.githubusercontent.com/yu1129/hard/main/%E4%BD%99.jpg" },
                    { 3, "中華大學 生物資訊學系 聽音樂", "吳霈玟", "https://raw.githubusercontent.com/wen-0510/FileStorages/main/1.jpg" },
                    { 4, "中華大學 生物資訊學系 愛貓", "朱彥蓉", "https://raw.githubusercontent.com/t333685/t333685.github.io/590201655655be034c9866169ddbab949d138e33/S__7020548.jpg" },
                    { 5, "中華大學 生物資訊學系 瑜珈", "盧致文", "https://raw.githubusercontent.com/chihwen1215/FileStorage/main/S__35127335.jpg" },
                    { 6, "中華大學 工業管理學系 打羽球", "楊子慧", "https://raw.githubusercontent.com/LittleY11/FileStorage/main/photo.jpg" },
                    { 7, "中華大學 資訊工程學系 看比賽", "戴閣廷", "https://raw.githubusercontent.com/hi8787h/hi8787h.github.io/main/photo/Myphoto.png" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
