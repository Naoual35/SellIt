using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt.Entities
{
    public class Brand
    {
        #region attributs
        private long brandId;
        private string name;
        private string description;
        #endregion

        #region properties
        public long BrandID
        {
            get { return brandId; }
            set { brandId = value; }
        }

     
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        #endregion 
    }
}
