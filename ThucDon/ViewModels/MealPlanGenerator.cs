using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ThucDon.Models;
using DotVVM.Framework.ViewModel;

namespace ThucDon.ViewModels
{
    public class MealPlanGenerator : DotvvmViewModelBase
    {
        public IEnumerable<CarbFood> CarbFoods { get; set; }
        public IEnumerable<ProteinFood> ProteinFoods { get; set; }
        public IEnumerable<FatFood> FatFoods { get; set; }
        public IEnumerable<MiscFood> MiscFoods { get; set; }

    }
}
