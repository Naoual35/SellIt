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
    public class Seller : Person
    {
        #region Attributs
        private long sellerId;
        private DateTime dateOfBirth;
        private List<Order> orders;
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
        [DateValid]
        [Required(ErrorMessage = "La date de naissance est obligatoire.")]
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public List<Order> Orders
        {
            get { return orders; }
            set { orders = value; }
        }
        [Required(ErrorMessage = "Le mot de passe est obligatoire."))]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        #endregion

    }
}
