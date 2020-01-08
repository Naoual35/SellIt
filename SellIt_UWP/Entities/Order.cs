using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Entities
{
    public class Order
    {
        #region attributs
        private long orderId;
        private DateTime dateOrder;
        private DateTime dateDelivery;
        private Seller seller;
        //private Client client;
        private ICollection<Car> cars;
        #endregion

        #region properties
        public long OrderID
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public virtual Seller Seller
        {
            get { return seller; }
            set { seller = value; }
        }

        //public virtual Client Client
        //{
        //    get { return client; }
        //    set { client = value; }
        //}

        public virtual ICollection<Car> Cars
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

        #region Constructors
        public Order()
        {
            this.cars = new List<Car>();
        }
        #endregion
    }
}
