using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ThucDon.Models;

namespace ThucDon.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base (options)
        {

        }
        public DbSet<DishesModel> DishesModels { get; set; }
        public DbSet<RawFoodCategory> RawFoodModels { get; set; }
        public DbSet<CarbFood> CarbFoods { get; set; }
        public DbSet<FatFood> FatFoods { get; set; }
        public DbSet<ProteinFood> ProteinFoods { get; set; }
        public DbSet<MiscFood> MiscFoods { get; set; }
        public DbSet<RawFoodCategory>RawFoodCategories { get; set; }

    }
}
