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
        [DisplayName("Nom")]
        [StringLength(50,ErrorMessage ="La taille du nom doit être comprise entre 1 et 50 caractères",MinimumLength = 1)]
        [Required(ErrorMessage = "Le nom de la personne est obligatoire")]
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        [Column("firstname")]
        [DisplayName("Prénom")]
        [StringLength(50, ErrorMessage = "La taille du prénom doit être comprise entre 1 et 50 caractères", MinimumLength = 1)]
        [Required(ErrorMessage = "Le prénom de la personne est obligatoire")]
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        [Column("address")]
        [DisplayName("Adresse")]
        [StringLength(50, ErrorMessage = "La taille du prénom doit être comprise entre 1 et 50 caractères", MinimumLength = 1)]
        [Required(ErrorMessage = "L\'adresse de la personne est obligatoire")]
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        [Column("postcode")]
        [DisplayName("Code postal")]
        [RegularExpression("^((0[1-9])|([1-8][0-9])|(9[0-8])|(2A)|(2B))[0-9]{3}$")]
        [Required(ErrorMessage = "Le code postal de la personne est obligatoire")]
        public int Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }

        [Column("city")]
        [DisplayName("Ville")]
        [StringLength(100,ErrorMessage = "Le taille du nom du proget doit être comprise entre 1 et 100 caractères",MinimumLength = 1)]
        [Required(ErrorMessage = "la ville obligatoire")]
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        [Column("phonenumber")]
        [DisplayName("Numéro de téléphone")]
        [RegularExpression("^[0-9]{10,10}$")]
        [Required(ErrorMessage = "le numéro de téléphone de la personne est obligatoire")]
        //[PhoneNumberValid]
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        #endregion
    }
}
