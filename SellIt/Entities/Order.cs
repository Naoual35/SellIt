using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt.Entities
{
   public class Order
    {

        #region attributs
        private long orderID;
        private long clientID;
        private int sellerID;
        private List<Car> cars;
        private DateTime dateOrder;
        private DateTime dateDelivery;
        #endregion


        #region properties
        public long OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }
      
      
        public long ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }


        public int SellerID
        {
            get { return sellerID; }
            set { sellerID = value; }
        }


        public List<Car> Cars
        {
            get { return cars; }
            set { cars = value; }
        }


        public DateTime DateOrder
        {
            get { return dateOrder; }
            set { dateOrder = value; }
        }


        public DateTime DateDelivery
        {
            get { return dateDelivery; }
            set { dateDelivery = value; }
        }

        #endregion

    }
}
