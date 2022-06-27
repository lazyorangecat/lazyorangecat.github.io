using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _0624_ReBuild_CoreMvc5_Razor.Models
{
    [Table("StudentTable")]
    public class Student
    {
        [Display(Name="學號")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DisplayFormat(DataFormatString ="{0:0000}",ApplyFormatInEditMode =false)]
        public int Id { get; set; }
        [Display(Name = "姓名")]
        public string Name { get; set; }
        [Display(Name="中文")]
        public int Chinese { get; set; }
        [Display(Name="英文")]
        public int English { get; set; }
        [Display(Name="數學")]
        [Column("Mathematics")]
        public int Math { get; set; }
        [Display(Name="總分")]
        [NotMapped]
        public int Total { get; set; }
    }
}
