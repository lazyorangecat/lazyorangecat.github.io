using _0524FirstMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace _0524FirstMVC.Data
{
    public class MemberContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MembersDB");
        }


        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Member> members = new List<Member>
            {
                new Member { Id = 1, Name ="王泓凱",Brief="平時喜好打APEX、LOL最近每天去打撞球",Photo="https://raw.githubusercontent.com/PurerKai/MVCAPI/main/myself.png"},
                new Member { Id = 2, Name="王俐璇", Brief="甜點愛好者", Photo="https://raw.githubusercontent.com/Lemon-2001/FileStoreage/main/MVC/Hsuan.jpeg" },
                new Member { Id = 3, Name="楊明翰",Brief="抽菸,飆車,",Photo="https://raw.githubusercontent.com/ert3455668/ert3455668.github.io/main/JavaScript/77F5723D-D640-4DA9-A57C-2C1542D58145.jpg"},
                new Member { Id = 4, Name="昱寬", Brief="看女團", Photo="https://raw.githubusercontent.com/Kuan1215/FileStorage/main/D6480B08-E095-456D-BB43-C0372D0FB0AC.jpg" },
                new Member { Id = 5, Name="吳奕君",Brief="聽音樂、看看書、過生活", Photo="https://raw.githubusercontent.com/Chun-2000/Chun-2000.github.io/main/MyPhoto.jpg" },
                new Member { Id = 6, Name ="羅世晏",Brief="充滿文學氣質的文藝青年",Photo="https://raw.githubusercontent.com/LoShinYen/FileStorages/main/S__5750791.jpg"},
                new Member { Id = 7, Name ="張添宇",Brief="可愛又迷人的反派角色",Photo="https://raw.githubusercontent.com/RainRoc1222/RainRoc1222.github.io/main/178099682_6502551609770280_5658538484540389917_n.jpg"},
                new Member { Id = 8, Name ="郭柏言",Brief="可以坐著就不要站著，可以躺著就不要坐著",Photo="https://raw.githubusercontent.com/lazyorangecat/lazyorangecat.github.io/main/XiJiangHua%20ASP.NET%20Core%20MVC/0524FirstMVC/12.jpeg"},
            };

            modelBuilder.Entity<Member>().HasData(members);
        }
    }
}
