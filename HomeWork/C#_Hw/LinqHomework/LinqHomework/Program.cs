using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //影片資料集合
            List<Video> videoList = new List<Video>() {
                new Video() { Name = "天竺鼠車車", Country = "日本", Duration = 2.6, Type = "動漫" },
                new Video() { Name = "鬼滅之刃", Country = "日本", Duration = 25, Type = "動漫" },
                new Video() { Name = "鬼滅之刃-無限列車", Country = "日本", Duration = 100, Type = "電影" },
                new Video() { Name = "甜蜜家園SweetHome", Country = "韓國", Duration = 50, Type = "影集" },
                new Video() { Name = "The 100 地球百子", Country = "歐美", Duration = 48, Type = "影集" },
                new Video() { Name = "冰與火之歌Game of thrones", Country = "歐美", Duration = 60, Type = "影集" },
                new Video() { Name = "半澤直樹", Country = "日本", Duration = 40, Type = "影集" },
                new Video() { Name = "古魯家族：新石代", Country = "歐美", Duration = 90, Type = "電影" },
                new Video() { Name = "角落小夥伴電影版：魔法繪本裡的新朋友", Country = "日本", Duration = 77, Type = "電影" },
                new Video() { Name = "TENET天能", Country = "歐美", Duration = 80, Type = "電影" },
                new Video() { Name = "倚天屠龍記2019", Country = "中國", Duration = 58, Type = "影集" },
                new Video() { Name = "下一站是幸福", Country = "中國", Duration = 45, Type = "影集" },
            };

            //人物資料集合
            List<Person> personList = new List<Person>()
            {
                new Person() { Name = "Bill", CountryPrefer = new List<string>() { "中國", "日本" }, TypePrefer = new List<string>() { "影集" } },
                new Person() { Name = "Jimmy", CountryPrefer = new List<string>() { "日本" }, TypePrefer = new List<string>() { "動漫", "電影" } },
                new Person() { Name = "Andy", CountryPrefer = new List<string>() { "歐美", "日本" }, TypePrefer = new List<string>() { "影集", "電影" } },
            };

            // 1. 找出所有日本的影片名稱
            Console.WriteLine($"{Environment.NewLine}Q1: 找出所有日本的影片名稱");

            var step1 = videoList.Where(v => v.Country == "日本");
            var step2 = step1.Select(v => v.Name);

            //輸出
            foreach(var item in step2)
            {
                Console.WriteLine(item);
            }
            //最終結果 join成單一字串
            var output1 = string.Join(",", step2);
            Console.WriteLine(output1);
            
            //篩選篩全部串一句
            Console.WriteLine(
                string.Join(",",
                    videoList
                    .Where(v => v.Country == "日本")
                    .Select(v => v.Name)));

            //Console.WriteLine(
            Console.WriteLine(
                string.Join(",",
                from v in videoList
                where v.Country == "日本"
                select v.Name));


            // 2. 找出所有歐美的影片且類型為"影集"的影片名稱
            Console.WriteLine($"{Environment.NewLine}Q2: 找出所有歐美的影片且類型為'影集'的影片名稱");

            
            Console.WriteLine(string.Join(",", 
                videoList.Where(v => v.Country == "歐美" && v.Type == "影集")
                .Select(v => v.Name)
                ));

            Console.WriteLine(
                string.Join(",",
                from v in videoList
                where v.Country == "歐美" && v.Type == "影集"
                select v.Name));

            // 3. 是否有影片片長超過120分鐘的影片
            Console.WriteLine($"{Environment.NewLine}Q3: 是否有影片片長超過120分鐘的影片");

            var result3=videoList.Any(v=>v.Duration>120);
            Console.WriteLine(result3?"是":"否");

            // 4. 請列出所有人的名稱，並且用大寫英文表示，ex: Bill -> BILL
            Console.WriteLine($"{Environment.NewLine}Q4: 請列出所有人的名稱，並且用大寫英文表示");

            var result4 = personList.Select(p=>$"{p.Name}\t->{p.Name.ToUpper()}");
            result4 = from p in personList
                      select $"{p.Name}\t->{p.Name.ToUpper()}";

            Console.WriteLine(
                String.Join(Environment.NewLine,result4));


            // 5. 將所有影片用片長排序(最長的在前)，並顯示排序過的排名以及片名，ex: No1: 天竺鼠車車
            Console.WriteLine($"{Environment.NewLine}Q5: 將所有影片用片長排序(最長的在前)，並顯示排序過的排名以及片名");
            videoList.OrderByDescending(v=>v.Duration)
                .Select((v,index)=>$"No{(index+1).ToString().PadLeft(2)}:{v.Name}");

            var ordered = videoList.OrderByDescending(v=>v.Duration);
            var result5 = ordered.Select(v => $"No{(ordered.ToList().IndexOf(v) + 1)}:{v.Name}");

            result5 = from v in ordered
                      
                      select $"No{(ordered.ToList().IndexOf(v) + 1)}:{v.Name}";
            Console.WriteLine(
                String.Join(Environment.NewLine, result5));

            // 6. 將所有影片進行以"類型"分類，並顯示以下樣式(注意縮排)
            /* 
            動漫:
                天竺鼠車車
                鬼滅之刃
            */
            Console.WriteLine($"{Environment.NewLine}Q6: 將所有影片進行以'類型'分類");

            var result6=videoList.GroupBy(v=>v.Type)
                .Select(g =>$"{g.Key}:{string.Concat(g.Select(v=>"\n\t"+v.Name)  )}");
            Console.WriteLine(
                String.Join(Environment.NewLine, result6));
            // 7. 找到第一個喜歡歐美影片的人
            Console.WriteLine($"{Environment.NewLine}Q7: 找到第一個喜歡歐美影片的人");

            var result7 = personList.FirstOrDefault(p => p.CountryPrefer.Contains("歐美")).Name;

            result7 = personList.Where(p => p.CountryPrefer.Contains("歐美"))
                .Select(p =>p.Name).FirstOrDefault();

            result7 = (from p in personList
                      where p.CountryPrefer.Contains("歐美")
                      select p.Name).FirstOrDefault();
            Console.WriteLine(result7);


            //8.找到每個人喜歡的影片(根據國家以及類型)，ex: Bill: 天竺鼠車車, 倚天屠龍記2019
            Console.WriteLine($"{Environment.NewLine}Q8: 找到每個人喜歡的影片");
            foreach (var p in personList)    //從人物清單抓出人來           
            {
                Console.WriteLine(p.Name);                //先把名字抓出來
                //根據國家以及類型
                Console.WriteLine(
                    String.Join("、", videoList.Where((v) => p.CountryPrefer.Contains(v.Country) && p.TypePrefer.Contains(v.Type))
                    .Select((x) => x.Name)));
            }
            //找到每個人喜歡的影片檢討每個人都要 對應一個答案字串 => 從personList出發
            //1.將每個 person p 轉成需要的答案字串
            var result8 =
            personList.Select(p => $"{p.Name}: {"此人p所喜歡的影片字串"}");
            //2.此人p所喜歡的影片串 = 從所有影片篩選，此人p'喜歡'的影片保留
            personList.Select(p => $"{p.Name}: {videoList.Where(v => "v被p喜歡否?" == "是") }");            //在 => 後的 只要是變數(videoList)都能參與
            //3.p喜歡v = v的 國家/類型 在p的 國家/類型 偏好清單中
            personList.Select(p => $"{p.Name}: {videoList.Where(v => p.CountryPrefer.Contains(v.Country) && p.TypePrefer.Contains(v.Type)) }");
            //4.此人p 所喜歡的影片串，只取名稱，再組成一個字串    先補.Select(v => v.Name) 只取影片名稱    在 string.Join(", ", 影片名稱串)
            result8 =
            personList.Select(p => $"{p.Name}:"+ $"{string.Join(", ",videoList.Where(v => p.CountryPrefer.Contains(v.Country) && p.TypePrefer.Contains(v.Type)).Select(v => v.Name))}");
            
            
            
            Console.WriteLine(String.Join(Environment.NewLine, result8));



            // 9. 列出所有類型的影片總時長，ex: 動漫: 100min
            Console.WriteLine($"{Environment.NewLine}Q9: 列出所有類型的影片總時長");

           var result9=videoList.GroupBy(v=>v.Type)
                .Select(g=>$"{g.Key}:{g.Sum(v=>v.Duration)}min");

            result9 = from v in videoList
                      group v by v.Type into g
                      select $"{g.Key}:{g.Sum(v => v.Duration)}min";

            Console.WriteLine(string.Join(Environment.NewLine, result9));

            // 10. 列出所有國家出產的影片數量，ex: 日本: 3部
            Console.WriteLine($"{Environment.NewLine}Q10: 列出所有國家出產的影片數量");

            var result10 = videoList.GroupBy(v => v.Country)
                .Select(g => $"{g.Key}:{g.Count()}部");

            result10 = from v in videoList
                       group v by v.Country into g
                       select $"{g.Key}:{g.Count()}部";

            Console.WriteLine(string.Join(Environment.NewLine,result10));

            Console.ReadLine();
        }
    }
}
