﻿using SellIt.Entities.ValidationEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt.Entities
{
    [Table("Order")]
    public class Order
    {
        #region attributs
        private long orderId;
        private DateTime dateOrder;
        private DateTime dateDelivery;
        private Seller seller;
        private Client client;
        private ICollection<Car> cars;
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

        [Required]
        public virtual Seller Seller
        {
            get { return seller; }
            set { seller = value; }
        }

        [Required]
        public virtual Client Client
        {
            get { return client; }
            set { client = value; }
        }

        public virtual ICollection<Car> Cars
        {
            get { return cars; }
            set { cars = value; }
        }

        [Column("dateOrder")]
        [DisplayName("Date de commande")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Une date de commande doit être renseignée.")]
        [DateValid("now")]
        public DateTime DateOrder
        {
            get { return dateOrder; }
            set { dateOrder = value; }
        }

        [Column("dateDelivery")]
        [DisplayName("Date de livraison")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Une date de livraison doit être renseignée.")]
        [DateValid("delivery")]
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
