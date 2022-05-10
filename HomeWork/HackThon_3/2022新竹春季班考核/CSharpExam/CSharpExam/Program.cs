using CSharpExam.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Course> courseList = new List<Course>()
            {
                new Course() { CourseId = "A001", Name = "C#", Teacher = "Bill", Classroom = "L107", Credit = 3 },
                new Course() { CourseId = "A002", Name = "HTML/CSS", Teacher = "Amos", Classroom = "L104", Credit = 2 },
                new Course() { CourseId = "A003", Name = "JavaScript/jQuery", Teacher = "奚江華", Classroom = "L104", Credit = 3 },
                new Course() { CourseId = "A004", Name = "MSSQL", Teacher = "Jimmy", Classroom = "L202", Credit = 3 },
                new Course() { CourseId = "A005", Name = "MVC5/CoreMVC", Teacher = "奚江華", Classroom = "L107", Credit = 6 },
                new Course() { CourseId = "B001", Name = "VueJS", Teacher = "Jimmy", Classroom = "L104", Credit = 2 },
                new Course() { CourseId = "B002", Name = "DevOps", Teacher = "David", Classroom = "L107", Credit = 3 },
                new Course() { CourseId = "B003", Name = "MongoDB", Teacher = "Ben", Classroom = "L202", Credit = 2 },
                new Course() { CourseId = "B004", Name = "Redis", Teacher = "Ben", Classroom = "L202", Credit = 2 },
                new Course() { CourseId = "B005", Name = "Git", Teacher = "Andy", Classroom = "L107", Credit = 1 },
                new Course() { CourseId = "B006", Name = "Git", Teacher = "Jimmy", Classroom = "L107", Credit = 1 }
            };

            List<Student> studentList = new List<Student>()
            {
                new Student() { StudentId = "S0001", Name = "小新", Gender = GenderOption.Male, CourseList = new List<string>() { "A001", "A004", "B002", "B003", "B004", "B005" } },
                new Student() { StudentId = "S0002", Name = "妮妮", Gender = GenderOption.Female, CourseList = new List<string>() { "A002", "A003", "B001", "B002", "B005" } },
                new Student() { StudentId = "S0003", Name = "風間", Gender = GenderOption.Male, CourseList = new List<string>() { "A001", "A002", "A003", "A004", "A005", "B001", "B002", "B003", "B004", "B005"  } },
                new Student() { StudentId = "S0004", Name = "阿呆", Gender = GenderOption.Male, CourseList = new List<string>() { "A001", "A002", "A003", "A004", "A005" } },
                new Student() { StudentId = "S0005", Name = "正男", Gender = GenderOption.Male, CourseList = new List<string>() { "B001", "B002", "B003", "B004", "B005" } },
                new Student() { StudentId = "S0006", Name = "小丸子", Gender = GenderOption.Female, CourseList = new List<string>() { "A005" } },
                new Student() { StudentId = "S0007", Name = "小玉", Gender = GenderOption.Female, CourseList = new List<string>() { "A005", "B002", "B003", "B004" } },
            };

            #region 第1題
            // 1. 列出所有課程的名稱
            Console.WriteLine(
                string.Join(",",
                    from c in courseList
                    select c.Name));


            Console.WriteLine($"{Environment.NewLine}");
            #endregion

            #region 第2題
            // 2. 列出所有在"L107"教室上課的課程ID
            Console.WriteLine(string.Join(",",
                from c in courseList
                where c.Classroom == "L107"
                select c.CourseId));


            Console.WriteLine($"{Environment.NewLine}");
            #endregion

            #region 第3題
            // 3. 列出所有在'L107'教室上課，並且學分為3的課程ID
            Console.WriteLine("3. 列出所有在'L107'教室上課，並且學分為3的課程ID");

            Console.WriteLine(string.Join(",",
            from c in courseList
            where c.Classroom == "L107" && c.Credit == 3
            select c.CourseId));



            Console.WriteLine($"{Environment.NewLine}");
            #endregion

            #region 第4題
            // 4. 列出所有老師的名字(名字不能重複出現)
            Console.WriteLine("4. 列出所有老師的名字(名字不能重複出現)");
            {
                Console.WriteLine(string.Join(",",
                    (from c in courseList
                     select c.Teacher).Distinct()));

            }

            Console.WriteLine($"{Environment.NewLine}");
            #endregion

            #region 第5題
            // 5. 列出所有有在'L202'上課的老師名字(名字不能重複出現)
            Console.WriteLine("5. 列出所有有在'L202'上課的老師名字(名字不能重複出現)");
            {
                Console.WriteLine(string.Join(",",
                    (from c in courseList
                     where c.Classroom == "L202"
                     select c.Teacher).Distinct()));

            }

            Console.WriteLine($"{Environment.NewLine}");
            #endregion

            #region 第6題
            // 6. 列出所有女性學生的名字
            Console.WriteLine("6. 列出所有女性學生的名字");
            {
                Console.WriteLine(string.Join(",",
                    (from s in studentList
                     where s.Gender == GenderOption.Female
                     select s.Name)));

            }

            Console.WriteLine($"{Environment.NewLine}");
            #endregion

            #region 第7題
            // 7. 列出有上'Git'這門課的學員名字
            Console.WriteLine("7. 列出有上'Git'這門課的學員名字");////////////////////////
            {
                var courlist = from c in courseList                                                 //最初
                               where c.Name == "Git"                                                //最初
                               select c.CourseId;//B005,B006                                        //最初
                                                                                                    //最初
                Console.WriteLine(string.Join(",",                                                  //最初
                    (from s in studentList                                                          //最初
                     where s.CourseList.Contains("B005") || s.CourseList.Contains("B006")           //最初
                                                                                                    //最初
                     select s.Name)));                                                              //最初
                
                var GitCourseID=String.Join(",", courseList.Where(c => c.Name == "Git").Select(ID => ID.CourseId));//兩個Git課程的ID
                var learnGitStudents = String.Join(",", studentList.Where(s => s.CourseList.Contains(GitCourseID)).Select(student => student.Name));/*選Git課程的學生*/


                Console.WriteLine(learnGitStudents);
                
            }

            #endregion

            #region 第8題
            // 8. 列出每個學員上的每一堂課
            // ex:
            /*
               小玉: 
                    MVC5/CoreMVC
                    DevOps
                    MongoDB
                    Redis
            */
            Console.WriteLine("8. 列出每個學員上的每一堂課");
            {
                //foreach (var student in studentList)
                //{
                //    Console.WriteLine(student.Name);
                //    foreach (var courses in student.CourseList)
                //        Console.WriteLine($"\t" + courses);
                //}
                //studentList.Select(s => $"{s.Name}:{"這個人上的課"}");
                //var result8=
                //studentList.Select(s => $"{s.Name}:{courseList.Where(c=>s.CourseList.Contains(c.CourseId)).Select(c=>c.Name)}");
                var result8 =
                studentList.Select(s => $"{s.Name}:\n\t{string.Join($"\n\t", courseList.Where(c => s.CourseList.Contains(c.CourseId)).Select(c => c.Name))}");
                
                Console.WriteLine(String.Join(Environment.NewLine, result8));
                





            }

            //Console.WriteLine($"{Environment.NewLine.result1}");
            #endregion

            #region 第9題
            // 9. 找出誰上的課數量最少
            Console.WriteLine("9. 找出誰上的課數量最少");
            {
                var result9 = (from s in studentList
                               orderby s.CourseList.Count()
                               select s.Name).FirstOrDefault();
                //foreach (var student in studentList)
                //{
                //    Console.Write(student.Name);
                //    Console.WriteLine(student.CourseList.Count());
                //}
                Console.WriteLine("答案:" + result9);

            }

            #endregion

            #region 第10題
            // 10. 找出誰修的學分總和小於10
            Console.WriteLine("10. 找出誰修的學分總和小於10");
            {
                //var 一個學生所上的課 = (from s in studentList                                
                //                select s.CourseList);
                //var 課程的學分=(from c in courseList
                //           where     
                //           select c.Credit )

                //Console.WriteLine(String.Join(Environment.NewLine, 一個學生所上的課));
                //var result10=studentList.Select(s =>$"{s.Name}:"+$"{string.Join(",",courseList.Where(c=>s.CourseList.Contains(c.CourseId))}")
                //}
                //總分加起來最少的人
                //studentList.Select(s => $"{s.Name}:{"此人所選的課的加總"}");
                //studentList.Select(s => $"{s.Name}:{courseList.GroupBy().Where(c=>s.CourseList.Contains(c.CourseId))}");
                var result10 =
                studentList.Select(s => $"{s.Name}:{string.Join($"", courseList.Where(c => s.CourseList.Contains(c.CourseId)).Sum(c => c.Credit))}");

                Console.WriteLine(String.Join(Environment.NewLine, result10));

                #endregion

                #region 第11題
                // 11. 找出誰最後獲得學分數最高
                Console.WriteLine("11. 找出誰最後獲得學分數最高");
                {
                    //作答區

                }

                Console.WriteLine($"{Environment.NewLine}");
                #endregion

                #region 第12題(加分題)
                // 12. 十二生肖自定義排序
                Console.WriteLine("12. 十二生肖自定義排序");
                {
                    var zoo = new List<string> { "龍", "鼠", "馬", "豬", "羊" }; //答案: 鼠、龍、馬、羊、豬
                    Console.WriteLine($"排序前: {string.Join("、", zoo)}{Environment.NewLine}");
                    Console.Write("排序後: ");
                    //作答區

                }

                #endregion

                Console.ReadLine();
            }
        }
    }
}
