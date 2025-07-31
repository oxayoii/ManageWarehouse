using System.ComponentModel.DataAnnotations;

namespace DataBase.Models
{
    public class Resourse 
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Status is required")]
        public string Status { get; set; }
        public ICollection<ResourseEntrance> ResourseEntrances { get; set; }
    }
}
