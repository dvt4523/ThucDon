using System;
using System.ComponentModel.DataAnnotations;

namespace ThucDon.Models
{
    public class DishesModel
    {
        [Key]
        public int DishID { get; set; }
        [Required]
        public int Calories { get; set; }
        public int Protein { get; set; }
        public int Fat { get; set; }
        [Required]
        public int Carb { get; set; }
        public int Fiber { get; set; }
    }
}
