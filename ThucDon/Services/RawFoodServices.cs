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
    }
}
