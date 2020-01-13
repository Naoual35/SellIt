using SellIt_UWP.Entities;
using SellIt_UWP.Views.ViewModels.UCAccessors.Commons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors.Categories
{
    public class CategoryListAccessor
    {
        public ObservableCollection<Category> Categories { get; set; }
        public ListViewAccessor<Category> ListView { get; set; }

        public CategoryListAccessor()
        {
            this.Categories = new ObservableCollection<Category>();
            this.ListView = new ListViewAccessor<Category>();
        }
    }
}
