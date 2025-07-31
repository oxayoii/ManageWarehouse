using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    public class ResourseEntrance
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Document entrance is required")]
        public int DocumentEntranceId { get; set; }
        public DocumentEntrance DocumentEntrance { get; set; }
        [Required(ErrorMessage = "Resourse is required")]
        public int ResourseId { get; set; }
        public Resourse Resourse { get; set; }
        [Required(ErrorMessage = "Unit meansure is required")]
        public int UnitMeansureId { get; set; }
        public UnitMeansure UnitMeansure { get; set; }

        public int Count { get; set; }
    }
}
