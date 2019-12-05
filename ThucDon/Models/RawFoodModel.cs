using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ThucDon.Models
{
    public class RawFoodModel
    {
        [Key]        
        public int FoodID { get; set; }
        [Required]
        public int Calories { get; set; }
        [Required]
        [Display(Name="Ingredient Name")]
        public string Name { get; set; }
        [Required]
        public int Protein { get; set; }
        [Required]
        public int Fat { get; set; }
        [Required]
        public int Fiber { get; set; }
        public enum FoodTag { Meat, Carb, Veggie, Fruit };
    }
}
