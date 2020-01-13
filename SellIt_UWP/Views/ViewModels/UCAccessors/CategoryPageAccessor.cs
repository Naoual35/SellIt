using SellIt_UWP.Views.ViewModels.UCAccessors.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels
{
    public class CategoryPageAccessor
    {
        public CategoryEditAccessor CategoryEdit { get; set; }
        public CategoryListAccessor CategoryList { get; set; }
        public CategoryShowAccessor CategoryShow { get; set; }

        public CategoryPageAccessor()
        {
            this.CategoryEdit = new CategoryEditAccessor();
            this.CategoryList = new CategoryListAccessor();
            this.CategoryShow = new CategoryShowAccessor();
        }
    }
}
