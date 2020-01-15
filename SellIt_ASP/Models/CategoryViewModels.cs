using SellIt.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SellIt_ASP.Models
{
    public class BrandListViewModel
    {
        [DisplayName("Marque")]
        public List<Brand> Brands { get; set; }
    }
}