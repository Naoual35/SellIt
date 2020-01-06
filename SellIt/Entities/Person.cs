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
    [Table("Person")]
    public abstract class Person
    {
        #region Attributs
        private string lastname;
        private string firstname;
        private string address;
        private int postcode;
        private string phoneNumber;
        private string city;
        #endregion

        #region Properties
        [Column("lastname")]
        [MaxLength(200)]
        [MinLength(4)]
        [Required(ErrorMessage = "le nom de la personne est obligatoire")]
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        [Column("firstname")]
        [MaxLength(200)]
        [MinLength(4)]
        [Required(ErrorMessage = "le prénom de la personne est obligatoire")]
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        [Column("address")]
        [MaxLength(200)]
        [MinLength(4)]
        [Required(ErrorMessage = "l'adresse de la personne est obligatoire")]
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        [Column("postcode")]
        [Required(ErrorMessage = "le code postal de la personne est obligatoire")]
        [PostCodeValid]
        public int Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }

        [Column("city")]
        [MaxLength(200)]
        [MinLength(2)]
        [Required(ErrorMessage = "la ville de résidence de la personne est obligatoire")]
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        [Column("phonenumber")]
        [MaxLength(12)]
        [MinLength(12)]
        [Required(ErrorMessage = "le numéro de téléphone de la personne est obligatoire")]
        [PhoneNumberValid]
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        #endregion
    }
}
