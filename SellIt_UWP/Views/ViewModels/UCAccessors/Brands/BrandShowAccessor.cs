using SellIt_UWP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors.Brands
{
    public class BrandShowAccessor
    {
        public Brand Brand { get; set; }

        public BrandShowAccessor()
        {
            this.Brand = new Brand();
        }
    }
}
