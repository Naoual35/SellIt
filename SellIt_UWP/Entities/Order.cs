using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Entities
{
    [Table("Order")]
    public class Order : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        #region attributs
        private long orderId;
        private DateTime dateOrder;
        private DateTime dateDelivery;
        private Seller seller;
        private long sellerId;
        private Client client;
        private long clientId;   

        private ICollection<Car> cars;
        #endregion

        #region properties
        [PrimaryKey, AutoIncrement]
        public long OrderId
        {
            get { return orderId; }
            set 
            {
                orderId = value;
                OnPropertyChanged("OrderId");
            }
        }

        [Column("seller")]
        [ManyToOne("SellerId")]
        public virtual Seller Seller
        {
            get { return seller; }
            set
            { 
                seller = value;
                OnPropertyChanged("Seller");
            }
        }


        [ForeignKey(typeof(Seller))]
        public long SellerId
        {
            get { return sellerId; }
            set { sellerId = value; }
        }


        [ManyToOne("ClientId")]
        public virtual Client Client
        {
            get { return client; }
            set 
            { 
                client = value;
                OnPropertyChanged("Client");
            }
        }

        [ForeignKey(typeof(Client))]
        public long ClientId
        {
            get { return clientId; }
            set { clientId = value; }
        }

        [OneToMany]
        public virtual ICollection<Car> Cars
        {
            get { return cars; }
            set { cars = value; }
        }

        [Column("dateOrder")]
        public DateTime DateOrder
        {
            get { return dateOrder; }
            set 
            { 
                dateOrder = value;
                OnPropertyChanged("DateOrder");
            }
        }

        public DateTime DateDelivery
        {
            get { return dateDelivery; }
            set 
            { 
                dateDelivery = value;
                OnPropertyChanged("DateDelivery");
            }
        }
        #endregion

        #region Constructors
        public Order()
        {
            this.cars = new List<Car>();
        }
        #endregion

        #region Methods
        public Order Copy()
        {
            Order order = new Order();

            order.OrderId = this.OrderId;
            order.DateOrder = this.DateOrder;
            order.DateDelivery = this.DateDelivery;
            if(this.Seller!=null)
            {
                order.Seller = this.Seller.Copy();
            }
            if (this.Client != null)
            {
                order.Client = this.Client.Copy();
            }

            return order;
        }
        #endregion
    }
}
