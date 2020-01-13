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

        #region attributs
        private long orderId;
        private DateTimeOffSet dateOrder;
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

        [Column("sellerId")]
        [ForeignKey(typeof(Seller))]
        public long SellerId
        {
            get { return sellerId; }
            set 
            { 
                sellerId = value;
                OnPropertyChanged("SellerId");
            }
        }

        [Column("client")]
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

        [Column("clientId")]
        [ForeignKey(typeof(Client))]
        public long ClientId
        {
            get { return clientId; }
            set 
            { 
                clientId = value;
                OnPropertyChanged("ClientId");
            }
        }

        [Column("cars")]
        [OneToMany]
        public virtual ICollection<Car> Cars
        {
            get { return cars; }
            set 
            { 
                cars = value;
                OnPropertyChanged("Cars");
            }
        }

        [Column("dateOrder")]
        [NotNull]
        public DateTime DateOrder
        {
            get { return dateOrder; }
            set 
            { 
                dateOrder = value;
                OnPropertyChanged("DateOrder");
            }
        }

        [Column("dateDelivery")]
        [NotNull]
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

            if(this.Cars!=null)
            {
                foreach (var item in this.Cars)
                {
                    order.Cars.Add(item);
                }
            }

            return order;
        }


        public void CopyFrom(Order order)
        {
            this.OrderId = order.OrderId;
            this.DateOrder = order.DateOrder;
            this.DateDelivery = order.DateDelivery;
            if (order.Seller != null)
            {
                this.Seller = order.Seller.Copy();
            }
            if (order.Client != null)
            {
                this.Client = order.Client.Copy();
            }

            if(order.Cars!=null)
            {
                foreach (var item in order.Cars)
                {
                    order.Cars.Add(item);
                }
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
