using SellIt.Entities.ValidationEntities;
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
    [Table("Seller")]
    public class Seller : Person
    {
        #region Attributs
        private long sellerId;
        private DateTime dateOfBirth;
        private ICollection<Order> orders; 

        #endregion


        #region Properties
        [Column("sellerId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long SellerId
        {
            get { return sellerId; }
            set { sellerId = value; }
        }

        [Column("dateOfBirth")]
        [DisplayName("Date de naissance")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DateValid("birth")]
        [Required(ErrorMessage = "La date de naissance est obligatoire.")]
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public virtual ICollection<Order> Orders
        {
            get { return orders; }
            set { orders = value; }
        }

        #endregion

        #region Constructeurs
        public Seller()
        {
            orders = new List<Order>();
        }
        #endregion

    }
}
