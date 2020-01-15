using SellIt.Database;
using SellIt.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SellIt_ASP.Utils.DatabaseUtils
{
    public static class BrandUtils
    {
        public static List<Brand> GetBrands()
        {
            List<Brand> maListe = new List<Brand>();
            using (var ctx = new SellItContext())
            {
                foreach (var item in ctx.DbBrand.ToList())
                {
                    maListe.Add(item);
                }
            }
            return maListe;
        }
    }
}