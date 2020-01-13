using SellIt_UWP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors.Categories
{
    public class CategoryShowAccessor
    {
        public Category Category { get; set; }

        public CategoryShowAccessor()
        {
            this.Category = new Category();
        }
    }
}
