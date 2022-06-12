using Microsoft.EntityFrameworkCore.Migrations;

namespace _0524FirstMVC.Migrations
{
    public partial class AddProductData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brief = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FuturePlan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Team = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitPrice = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Member",
                columns: new[] { "Id", "Brief", "City", "Department", "FuturePlan", "Gender", "Name", "Photo", "Salary", "Team" },
                values: new object[,]
                {
                    { 1, "我的興趣大吃大喝，喜歡購物，就是沒錢", "Malaysia", "國際企業學系", "Work", false, "林詠琦", "https://raw.githubusercontent.com/YongChyi/YongChyi.github.io/main/45296.jpg", "40000-50000", "第一組" },
                    { 31, "可以坐著就不要站著，可以躺著就不要坐著", "", "", "", true, "郭柏言", "https://lazyorangecat.github.io/XiJiangHua%20ASP.NET%20Core%20MVC/0524FirstMVC/12.jpeg", "", "第四組" },
                    { 30, "甜點愛好者", "台南市", "資工系", "stuty", false, "王俐璇", "https://raw.githubusercontent.com/Lemon-2001/FileStoreage/main/MVC/Hsuan.jpeg", "36000-42000", "第四組" },
                    { 29, "", "新竹市", "資工系", "stuty", false, "吳奕君", "https://raw.githubusercontent.com/Chun-2000/Chun-2000.github.io/main/MyPhoto.jpg", "38000~40000", "第四組" },
                    { 28, "平時喜好打APEX、LOL最近每天去打撞球", "", "資管系", "", true, "王泓凱", "https://raw.githubusercontent.com/PurerKai/MVCAPI/main/myself.png", "", "第四組" },
                    { 27, "可愛又迷人的反派角色", "新竹市", "資管系", "work+study", true, "張添宇", "https://raw.githubusercontent.com/RainRoc1222/RainRoc1222.github.io/main/178099682_6502551609770280_5658538484540389917_n.jpg", "40000~40002", "第四組" },
                    { 26, "充滿文學氣質的文藝青年", "新竹縣", "航海系", "work+study", true, "羅世晏", "https://raw.githubusercontent.com/LoShinYen/FileStorages/main/S__5750791.jpg", "36000~45000", "第四組" },
                    { 25, "抽菸,飆車,", "宜蘭縣", "國際企業系", "work", true, "楊明翰", "https://raw.githubusercontent.com/ert3455668/ert3455668.github.io/main/JavaScript/77F5723D-D640-4DA9-A57C-2C1542D58145.jpg", "38000~42000", "第四組" },
                    { 24, "看書", "新竹市", "資訊工程學系", "NA", true, "彭宗文", "https://raw.githubusercontent.com/DavidPeng1/FileStorage/main/IMG_0039.JPG", " 200000 ~ 500000", "第三組" },
                    { 23, "追劇", "新竹縣", "工業工程管理學系", "Work", false, "林盈均", "https://raw.githubusercontent.com/linyign/FileStorage/main/pic.jpg", "36000-42000", "第三組" },
                    { 22, "看漫畫", "新竹縣", "應用日語學系", "Study", false, "范華軒", "https://fan-hua-hsuan.github.io/photo/hana.jpg", "35000 ~ 40000", "第三組" },
                    { 21, "看漫畫", "台東縣", "工業工程管理學系(原科技管理學系)", "Work", false, "楊景琁", "https://raw.githubusercontent.com/Kei209/FileStorage/main/2022-05-24-15-52-31-817.jpg", "36000-42000", "第三組" },
                    { 20, "玩摩爾", "新北市", "生物資訊系", "Study", false, "劉禮婷", "https://raw.githubusercontent.com/Lyting030/Lyting030.github.io/main/0524.jpg", "40000 ~ 50000", "第三組" },
                    { 19, "看漫畫", "新竹市", "工業工程管理學系", "Work", false, "陳亮羽", "https://raw.githubusercontent.com/liang10713/FileStorage/main/64102.jpg", "35000 ~ 40000", "第三組" },
                    { 18, "上網", "南投縣", "資訊工程學系", "Work", true, "徐秉詰", "https://raw.githubusercontent.com/3TeT3/FileStorage_/main/16140801732026.jpg", "35000-42000", "第三組" },
                    { 17, "超愛羽球", "台北市", "資訊管理學系", "Work", true, "陳柏宇", "https://raw.githubusercontent.com/Ankepoyou/FileStorage/main/IMG_20210518_154803_800.jpg", "35000 ~ 40000", "第三組" },
                    { 8, "最愛南柱赫!!!!!", "基隆市", "觀光與會展活動學系", "work", false, "李家萱", "https://raw.githubusercontent.com/JiaXuan1083/FileStorage/main/IMG_7403.JPG", "40000-45000", "第二組" },
                    { 15, "看女團", "桃園市", "生物資訊學系", "work", true, "江昱寬", "https://raw.githubusercontent.com/Kuan1215/FileStorage/main/D6480B08-E095-456D-BB43-C0372D0FB0AC.jpg", "70000-150000", "第二組" },
                    { 14, "看比賽", "桃園市", "資訊工程學系", "work", true, "戴閣廷", "https://raw.githubusercontent.com/hi8787h/hi8787h.github.io/main/photo/Myphoto.png", "36000-42000", "第二組" },
                    { 13, "打羽球", "台中市", "工業管理學系", "study", false, "楊子慧", "https://raw.githubusercontent.com/LittleY11/FileStorage/main/photo.jpg", "40000-45000", "第二組" },
                    { 12, "瑜珈", "台南市", "生物資訊學系", "work", false, "盧致文", "https://raw.githubusercontent.com/chihwen1215/FileStorage/main/S__35127335.jpg", "40000-45000", "第二組" },
                    { 11, "愛貓", "苗栗縣", "生物資訊學系 ", "work", false, "朱彥蓉", "https://raw.githubusercontent.com/t333685/t333685.github.io/590201655655be034c9866169ddbab949d138e33/S__7020548.jpg", "35000-40000", "第二組" },
                    { 10, "聽音樂", "高雄市", "生物資訊學系", "study", false, "吳霈玟", "https://raw.githubusercontent.com/wen-0510/FileStorages/main/1.jpg", "42000-48000", "第二組" },
                    { 9, "打羽球", "雲林縣", "生物資訊學系 ", "work", false, "廖培余", "https://raw.githubusercontent.com/yu1129/hard/main/%E4%BD%99.jpg", "40000-48000", "第二組" },
                    { 16, "超愛出去玩", "桃園市", "企業管理學系", "Work", false, "陳妤瑄", "https://raw.githubusercontent.com/Jamie1721/FileStorage/main/S__6267102.jpg", "35000 ~ 40000", "第三組" },
                    { 7, "I’m very communicative, detail-oriented, and versatile. I like to think of myself as a team player. While I don’t mind taking on solo projects, I prefer to work with others.I like to think that I’m persistent and persuasive. Working in sales, these traits have served me well. Outside of work, I enjoy taking part in lively debates where I can share my views with others.", "新竹市", "企業管理學系", "Work", true, "魏子涵", "https://raw.githubusercontent.com/Neil-Yang3759/FileStorage/main/IMG_0299.jpg", "100000-150000", "第一組" },
                    { 6, "喜歡玩遊戲", "雲林縣", "資訊工程學系", "Study", true, "林秉謙", "https://raw.githubusercontent.com/Silmonght/Silmonght.github.io/main/steven.jpg", "38000-45000", "第一組" },
                    { 5, "窩不知道", "苗栗縣", "資訊工程學系", "Work", true, "余仲恩", "https://raw.githubusercontent.com/ycm123/FileStorage/main/20712.jpg", "36000-40000", "第一組" },
                    { 4, "123", "新北市", "資訊工程學系", "Study", true, "王紀翔", "https://raw.githubusercontent.com/shaun881017/shaun881017.github.io/main/JS_HW1/D1F75C32-5FF6-4442-AA67-47A11D25F468.jpg", "50000-60000", "第一組" },
                    { 3, "單身", "新竹市", "資訊工程學系", "Work", true, "Neil", "https://raw.githubusercontent.com/Neil-Yang3759/Neil-Yang3759.github.io/main/JS/HW1/selfie.jpg", "100000-150000", "第一組" },
                    { 2, "雙胞胎姐姐", "Malaysia", "國際企業學系", "Study", false, "林詩琦", "https://raw.githubusercontent.com/ShiChyiLim/ShiChyiLim.github.io/main/1784C24F-3C76-475D-A246-B8B1F58CBD7E.jpg", "40000-60000", "第一組" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "ImageUrl", "ProductName", "UnitPrice" },
                values: new object[,]
                {
                    { 1, "https://autos.yahoo.com.tw/p/r/w880/car-models/November2021/NB9n7re2C6OIisCSnALF.jpg", "Ferrari 296 GTB", 1616161 },
                    { 2, "https://image.u-car.com.tw/file_26223.jpg", "大穩發", 638000 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
