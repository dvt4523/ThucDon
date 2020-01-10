using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThucDon.Data;
using ThucDon.Models;

namespace ThucDon.Services
{
    public class RawFoodServices
    {
        public ApplicationDbContext _db;
        public RawFoodServices(ApplicationDbContext db)
        {
            _db = db;
        }

        public CarbFood GetRandomCarb()
        {
            return _db.CarbFoods.OrderBy(r => Guid.NewGuid()).Take(1).FirstOrDefault();
        }
        public ProteinFood GetRandomProtein()
        {
            return _db.ProteinFoods.OrderBy(r => Guid.NewGuid()).Take(1).FirstOrDefault();
        }
        public FatFood GetRandomFat()
        {
            return _db.FatFoods.OrderBy(r => Guid.NewGuid()).Take(1).FirstOrDefault();            
        }
        public MiscFood GetRandomMisc()
        {
            return _db.MiscFoods.OrderBy(r => Guid.NewGuid()).Take(1).FirstOrDefault();
        }

        public double CalculateFat(FatFood fatFood, double calories)
        {
            return Math.Round(calories * 0.3 / 9 * 100 / fatFood.Fat,2);
        }
        public double CalculateProtein(ProteinFood proteinFood, double calories, double difference)
        {
            return Math.Round((calories * 0.2 / 4 - difference) * 100 / proteinFood.Protein,2);
        }
        public double CalculateCarb(CarbFood carbFood, double calories, double difference)
        {
            return Math.Round((calories * 0.6 / 4 - difference) * 100 / carbFood.Carb,2);
        }
        public double CalculateMisc(MiscFood miscFood, double difference)
        {
            if (13 - difference < 0) return 0;
            else
                return Math.Round((13 - difference) * 100 / miscFood.Fiber,2);
        }
    }
}
