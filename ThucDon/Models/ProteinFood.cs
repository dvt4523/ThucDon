using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ThucDon.Models
{
    public class ProteinFood
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FoodID { get; set; }
        [Required]
        public double Calories { get; set; }
        [Required]
        [Display(Name = "Food Name")]
        public string Name { get; set; }
        [Required]
        public double Protein { get; set; }
        [Required]
        public double Fat { get; set; }
        [Required]
        public double Carb { get; set; }
        [Required]
        public double Fiber { get; set; }

        [Display(Name = "Food Category")]
        [ForeignKey("FoodCategoryID")]
        public virtual RawFoodCategory FoodCategory { get; set; }
    }
}
