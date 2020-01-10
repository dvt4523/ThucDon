using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ThucDon.Models;
using DotVVM.Framework.ViewModel;
using ThucDon.Services;

namespace ThucDon.ViewModels
{
    public class MealPlanGeneratorViewModel : MasterPageViewModel
    {
        public IEnumerable<CarbFood> CarbFoods { get; set; }
        public IEnumerable<ProteinFood> ProteinFoods { get; set; }
        public IEnumerable<FatFood> FatFoods { get; set; }
        public IEnumerable<MiscFood> MiscFoods { get; set; }
        public double Calories { get; set; }

        private readonly RawFoodServices _rawFoodService;

        public MealPlanGeneratorViewModel (RawFoodServices rawFoodService)
        {
            _rawFoodService = rawFoodService;
        }
        public string ProteinName { get; set; }
        public double ProteinAmount { get; set; }
        public string FatName { get; set; }
        public double FatAmount { get; set; }
        public string CarbName { get; set; }
        public double CarbAmount { get; set; }
        public string MiscName { get; set; }
        public double MiscAmount { get; set; }

        public CarbFood RandomCarb { get; set; }
        public ProteinFood RandomProtein { get; set; }
        public FatFood RandomFat { get; set; }
        public MiscFood RandomMisc { get; set; }

        public void Generate()
        {
            RandomCarb = _rawFoodService.GetRandomCarb();
            RandomProtein = _rawFoodService.GetRandomProtein();
            RandomFat = _rawFoodService.GetRandomFat();
            RandomMisc = _rawFoodService.GetRandomMisc();
            ProteinName = RandomProtein.Name;
            FatName = RandomFat.Name;
            CarbName = RandomCarb.Name;
            MiscName = RandomMisc.Name;
            FatAmount = _rawFoodService.CalculateFat(RandomFat, Calories);
            ProteinAmount = _rawFoodService.CalculateProtein(RandomProtein, Calories, RandomFat.Protein);
            CarbAmount = _rawFoodService.CalculateCarb(RandomCarb, Calories, RandomFat.Carb + RandomProtein.Carb);
            MiscAmount = _rawFoodService.CalculateMisc(RandomMisc, CarbAmount * RandomCarb.Fiber / 100 + ProteinAmount * RandomProtein.Fiber / 100 + FatAmount * RandomFat.Fiber / 100);
        }
    }
}
