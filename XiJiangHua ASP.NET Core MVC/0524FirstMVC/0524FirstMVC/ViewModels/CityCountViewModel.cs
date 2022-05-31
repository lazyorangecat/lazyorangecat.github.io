using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace _0524FirstMVC.ViewModels
{
    public class CityCountViewModel
    {
        //public int Id { get; set; }
        [Key]
        
        public string City { get; set; }
        public int Count { get; set; }
    }
}
