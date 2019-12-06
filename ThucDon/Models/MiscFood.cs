using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ThucDon.Models
{
    public class MiscFood
    {
        [Key]
        public int FoodID { get; set; }
        [Required]
        public int Calories { get; set; }
        [Required]
        [Display(Name = "Food Name")]
        public string Name { get; set; }
        [Required]
        public int Protein { get; set; }
        [Required]
        public int Fat { get; set; }
        [Required]
        public int Carb { get; set; }
        [Required]
        public int Fiber { get; set; }

        [Display(Name = "Food Category")]
        [ForeignKey("FoodCategoryID")]
        public virtual RawFoodCategory FoodCategory { get; set; }
    }
}
