using System.ComponentModel.DataAnnotations;

namespace _0524FirstMVC.Models
{
    public class Member
    {
        [Display(Name="編號")]
        public int Id { get; set; }

        [Display(Name = "姓名")]
        public string Name { get; set; }

        [Display(Name="簡介")]
        public string Brief { get;set;}

        [Display(Name="照片")]
        public string Photo { get; set; }

        [Display(Name="系所")]
        public string Department { get; set; }

        [Display(Name="性別")]
         public bool Gender  {get;set;}

        [Display(Name="城市")]
         public string   City {get;set;}

        [Display(Name="未來規劃")]
         public string   FuturePlan  {get;set;}

        [Display(Name="薪水")]
         public string   Salary  {get;set;}

        [Display(Name="組別")]
         public string   Team  {get;set;}

        
    }
}
