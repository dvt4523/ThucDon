using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ThucDon.Models;
using DotVVM.Framework.ViewModel;
using ThucDon.Services;

namespace ThucDon.ViewModels
{
    public class MealPlanGeneratorViewModel : DotvvmViewModelBase
    {
        public IEnumerable<CarbFood> CarbFoods { get; set; }
        public IEnumerable<ProteinFood> ProteinFoods { get; set; }
        public IEnumerable<FatFood> FatFoods { get; set; }
        public IEnumerable<MiscFood> MiscFoods { get; set; }

        public CarbFood RandomCarb { get; set; }
        public ProteinFood RandomProtein { get; set; }
        public FatFood RandomFat { get; set; }
        public MiscFood RandomMisc { get; set; }

        public void Generate()
        {
            GetRandomCarb();
        }

    }
}
