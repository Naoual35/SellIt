using SellIt.Database;
using SellIt.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SellIt_ASP.Utils.DatabaseUtils
{
    public class CategoryUtils
    {
        public static List<Category> GetCategories()
        {
            List<Category> maListe = new List<Category>();
            using (var ctx = new SellItContext())
            {
                foreach (var item in ctx.DbCategory.ToList())
                {
                    maListe.Add(item);
                }
            }
            return maListe;
        }
    }
}