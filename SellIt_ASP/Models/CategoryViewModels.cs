using SellIt.Entities;
using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Collections.ObjectModel;
=======
>>>>>>> 99be1004ecbd9f2d06777486038f28dcf8ea2355
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

    public class CategoryListViewModel
    {
        [DisplayName("Catégorie")]
        public List<Category> Categories { get; set; }
    }
}