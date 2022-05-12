using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_CourseSelection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            //以下由你完善，設定學生的個資、選課
            student1.ID = "S11001";
            student1.Name = "Dann";
            student1.Courses = new Course[]
            {
                new Course(){Name ="微積分",Credit=4},
                new Course(){Name ="線性代數",Credit=3},
                new Course(){Name ="普通物理",Credit=3},
                new Course(){Name ="物理實驗",Credit=1}
            };
            //以上由你完善
            student1.ShowInformation();


            Student student2 = new Student();
            //以下由你完善，設定學生的個資、選課
            student1.ID = "S11002";
            student1.Name = "Bill";
            student1.Courses = new Course[]
            {
                new Course(){Name ="視唱",Credit=3},
                new Course(){Name ="和弦",Credit=4},
                
            };
            //以上由你完善
            student2.ShowInformation();

            Console.ReadLine();
        }
    }

    public class Student
    {
        //須要什麼成員，自行設計
        public string ID { get; set; }
        public string Name { get; set; }
        public Course[] Courses { get; set; }
        public void ShowInformation()
        {
            //輸出參考示意圖格式
            Console.WriteLine($"學號:{ID}\n姓名:{Name}\n選課:");
            int totalCredit = 0;
            //for(int i = 0; i < Courses.Length; i++)
            //{
            //    Console.WriteLine($"\t{Courses[i].Name},{Courses[i].Credit}學分");
            //    totalCredit+=Courses[i].Credit;
            //}

            foreach(Course c in Courses)
            {
                Console.WriteLine($"\t{c.Name},{c.Credit}學分");
                totalCredit+=c.Credit;
            }
            Console.WriteLine(totalCredit);
            Console.WriteLine("______________________________");
        }
    }
    public class Course
    {
        //須要什麼成員，自行設計        
        public string Name { get; set; }
        public int Credit{ get; set; }
    }
}