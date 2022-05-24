using Microsoft.EntityFrameworkCore.Migrations;

namespace _0524FirstMVC.Migrations
{
    public partial class InitialDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brief", "Name", "Photo" },
                values: new object[] { "平時喜好打APEX、LOL最近每天去打撞球", "王泓凱", "https://raw.githubusercontent.com/PurerKai/MVCAPI/main/myself.png" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brief", "Name", "Photo" },
                values: new object[] { "甜點愛好者", "王俐璇", "https://raw.githubusercontent.com/Lemon-2001/FileStoreage/main/MVC/Hsuan.jpeg" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Brief", "Name", "Photo" },
                values: new object[] { "抽菸,飆車,", "楊明翰", "https://raw.githubusercontent.com/ert3455668/ert3455668.github.io/main/JavaScript/77F5723D-D640-4DA9-A57C-2C1542D58145.jpg" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Brief", "Name", "Photo" },
                values: new object[] { "看女團", "昱寬", "https://raw.githubusercontent.com/Kuan1215/FileStorage/main/D6480B08-E095-456D-BB43-C0372D0FB0AC.jpg" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Brief", "Name", "Photo" },
                values: new object[] { "聽音樂、看看書、過生活", "吳奕君", "https://raw.githubusercontent.com/Chun-2000/Chun-2000.github.io/main/MyPhoto.jpg" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Brief", "Name", "Photo" },
                values: new object[] { "充滿文學氣質的文藝青年", "羅世晏", "https://raw.githubusercontent.com/LoShinYen/FileStorages/main/S__5750791.jpg" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Brief", "Name", "Photo" },
                values: new object[] { "可愛又迷人的反派角色", "張添宇", "https://raw.githubusercontent.com/RainRoc1222/RainRoc1222.github.io/main/178099682_6502551609770280_5658538484540389917_n.jpg" });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Brief", "Name", "Photo" },
                values: new object[] { 8, "可以坐著就不要站著，可以躺著就不要坐著", "郭柏言", "https://raw.githubusercontent.com/lazyorangecat/lazyorangecat.github.io/main/XiJiangHua%20ASP.NET%20Core%20MVC/0524FirstMVC/12.jpeg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brief", "Name", "Photo" },
                values: new object[] { "中華大學 觀光與會展活動學系 最愛南柱赫!!!!!", "李家萱", "https://raw.githubusercontent.com/JiaXuan1083/FileStorage/main/IMG_7403.JPG" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brief", "Name", "Photo" },
                values: new object[] { "中華大學 生物資訊學系 打羽球", "廖培余", "https://raw.githubusercontent.com/yu1129/hard/main/%E4%BD%99.jpg" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Brief", "Name", "Photo" },
                values: new object[] { "中華大學 生物資訊學系 聽音樂", "吳霈玟", "https://raw.githubusercontent.com/wen-0510/FileStorages/main/1.jpg" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Brief", "Name", "Photo" },
                values: new object[] { "中華大學 生物資訊學系 愛貓", "朱彥蓉", "https://raw.githubusercontent.com/t333685/t333685.github.io/590201655655be034c9866169ddbab949d138e33/S__7020548.jpg" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Brief", "Name", "Photo" },
                values: new object[] { "中華大學 生物資訊學系 瑜珈", "盧致文", "https://raw.githubusercontent.com/chihwen1215/FileStorage/main/S__35127335.jpg" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Brief", "Name", "Photo" },
                values: new object[] { "中華大學 工業管理學系 打羽球", "楊子慧", "https://raw.githubusercontent.com/LittleY11/FileStorage/main/photo.jpg" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Brief", "Name", "Photo" },
                values: new object[] { "中華大學 資訊工程學系 看比賽", "戴閣廷", "https://raw.githubusercontent.com/hi8787h/hi8787h.github.io/main/photo/Myphoto.png" });
        }
    }
}
