using SellIt.Entities.ValidationEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt.Entities
{
    public class Order
    {

        #region attributs
        private long orderId;
        private long clientId;
        private int sellerId;
        private List<Car> cars;
        private DateTime dateOrder;
        private DateTime dateDelivery;
        #endregion


        #region properties
        [Column("orderId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long OrderID
        {
            get { return orderId; }
            set { orderId = value; }
        }

        [Column("clientId")]
        [ForeignKey("Client")]
        [Required(ErrorMessage = "Un client doit être associé.")]
        public long ClientId
        {
            get { return clientId; }
            set { clientId = value; }
        }

        [Column("sellerId")]
        [ForeignKey("Seller")]
        [Required(ErrorMessage = "Un vendeur doit être associé.")]
        public int SellerID
        {
            get { return sellerId; }
            set { sellerId = value; }
        }


        public List<Car> Cars
        {
            get { return cars; }
            set { cars = value; }
        }

        [Column("dateOrderId")]
        [Required(ErrorMessage = "une date de commande doit être renseignée.")]
        [DateValid]
        public DateTime DateOrder
        {
            get { return dateOrder; }
            set { dateOrder = value; }
        }

        [Column("dateDelivery")]
        [Required(ErrorMessage = "une date de livraison doit être renseignée.")]
        [DateValid]
        public DateTime DateDelivery
        {
            get { return dateDelivery; }
            set { dateDelivery = value; }
        }

        #endregion

    }
}
