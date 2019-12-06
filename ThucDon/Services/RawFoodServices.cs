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
        private readonly ApplicationDbContext _db;
        public RawFoodServices (ApplicationDbContext db)
        {
            _db = db;
        }
    }
}
