using SellIt_UWP.Entities;
using SellIt_UWP.Views.ViewModels.UCAccessors.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors.Brands
{
    public class BrandEditAccessor
    {
        public Brand Brand { get; set; }
        public ButtonAccessor Button { get; set; }
        public BrandEditAccessor()
        {
            this.Brand = new Brand();
            this.Button = new ButtonAccessor();
        }
    }
}
