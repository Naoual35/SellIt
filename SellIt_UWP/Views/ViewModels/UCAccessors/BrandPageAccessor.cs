using SellIt_UWP.Views.ViewModels.UCAccessors.Brands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors
{
   public class BrandPageAccessor
    {
        public BrandEditAccessor BrandEdit { get; set; }
        public BrandListAccessor BrandList { get; set; }
        public BrandShowAccessor BrandShow { get; set; }

        public BrandPageAccessor()
        {
            this.BrandEdit = new BrandEditAccessor();
            this.BrandList = new BrandListAccessor();
            this.BrandShow = new BrandShowAccessor();
        }
    }
}

