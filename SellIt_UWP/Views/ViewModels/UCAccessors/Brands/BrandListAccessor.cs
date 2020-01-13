using SellIt_UWP.Entities;
using SellIt_UWP.Views.ViewModels.UCAccessors.Commons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors.Brands
{
    public class BrandListAccessor
    {
        public ObservableCollection<Brand> Brands { get; set; }
        public ListViewAccessor<Brand> ListView { get; set; }

        public BrandListAccessor()
        {
            this.Brands = new ObservableCollection<Brand>();
            this.ListView = new ListViewAccessor<Brand>();
        }
    }
}
