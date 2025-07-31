using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    public class DocumentEntrance
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Number is required")]
        public string Number { get; set; }
        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }
        public ICollection<ResourseEntrance> ResourseEntrances { get; set; }
    }
}
