using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSales.Models
{
    public class Sales
    {
        public int Id { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [Display(Name = "Date Listed")]
        [DataType(DataType.Date)]
        public DateTime DateListed { get; set; }
       
    }
}
