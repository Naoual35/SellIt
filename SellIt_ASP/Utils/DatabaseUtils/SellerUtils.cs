using SellIt.Database;
using SellIt.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SellIt_ASP.Utils.DatabaseUtils
{
    public static class SellerUtils
    {
        public static List<Seller> GetSellers()
        {
            List<Seller> maListe = new List<Seller>();
            using (var ctx = new SellItContext())
            {
                foreach (var item in ctx.Sellers)
                {
                    maListe.Add(item);
                }
            }
            return maListe;
        }
    }
}