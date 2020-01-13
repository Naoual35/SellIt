using SellIt_UWP.Entities;
using SellIt_UWP.Views.ViewModels.UCAccessors.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors.Categories
{
    public class CategoryEditAccessor
    {
        public Category Category { get; set; }
        public ButtonAccessor Button { get; set; }
        public CategoryEditAccessor()
        {
            this.Category = new Category();
            this.Button = new ButtonAccessor();
        }
    }
}
