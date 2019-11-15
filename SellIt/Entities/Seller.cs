using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt.Entities
{
    public class Seller : Person
    {
        #region Attributs
        private long sellerID;
        private DateTime dateOfBirth;
        private List<Order> orders;
        #endregion


        #region Properties
        public long SellerID
        {
            get { return sellerID; }
            set { sellerID = value; }
        }   

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public List<Order> MyProperty
        {
            get { return orders; }
            set { orders = value; }
        }
        #endregion

    }
}
