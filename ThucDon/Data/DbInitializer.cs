using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThucDon.Data
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext _db;
        public DbInitializer (ApplicationDbContext db)
        {
            _db = db;
        }
        public void Initialize()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception ex)
            {

            }

            if (_db.ProteinFoods.Any()) return;
            _db.ProteinFoods.Add(new Models.ProteinFood
            {
                Calories = 165,
                FoodID = 001,
                Protein = 31,
                Fat = 3,
                Carb = 0,
                Fiber = 0,
                Name = "Chicken Breast",
                FoodCategory = new Models.RawFoodCategory { FoodCategoryID = 01, Name = "Protein Foods"}
            });
            _db.SaveChanges();

        }
    }
}
