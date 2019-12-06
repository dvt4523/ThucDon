using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ThucDon.Models
{
    public class RawFoodCategory
    {
        [Key]        
        public int FoodCategoryID { get; set; }
        [Required]
        [Display(Name="Food Category")]
        public string Name { get; set; }

        public virtual ProteinFood ProteinFood { get; set; }
        public virtual FatFood FatFood { get; set; }
        public virtual CarbFood CarbFood { get; set; }
        public virtual MiscFood MiscFood { get; set; }



    }
}
