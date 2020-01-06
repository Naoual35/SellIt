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
    [Table("Car")]
    public class Car
    {
        #region Attributs
        private long carId;
        private string name;
        private int year;
        private int timeAssurancy;
        private bool avalaible;
        private int delayExchange;
        private string color;
        private Category category;
        #endregion

        #region Properties

        [Column("carId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CarId
        {
            get { return carId; }
            set { carId = value; }
        }

        [Column("name")]
        [StringLength(100, ErrorMessage = "Le nom de la voiture ne peut pas contenir plus de 100 caractères", MinimumLength = 1)]
        [DisplayName("Nom")]
        [Required(ErrorMessage = "Le modèle de la voiture est obligatoire")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [Column("category")]
        [DisplayName("Catégorie")]
        public virtual Category Category
        {
            get { return category; }
            set { category = value; }
        }

        [Column("year")]
        [YearCarValid(1970)]
        [DisplayName("Année")]
        [Required(ErrorMessage = "l\'année de la voiture est obligatoire")]
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        [Column("color")]
        [DisplayName("Couleur")]
        [StringLength(50, ErrorMessage = "la couleur de la voiture ne peut pas contenir plus de 50 caractères", MinimumLength = 1)]
        [Required(ErrorMessage = "la couleur de la voiture est obligatoire")]
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        [Column("avalaible")]
        [DisplayName("Disponibilité")]
        [Required(ErrorMessage = "la disponibilité de la voiture est obligatoire")]
        public bool Avalaible
        {
            get { return avalaible; }
            set { avalaible = value; }
        }

        [Column("timeAssurancy")]
        [DisplayName("Garantie")]
        [TimeAssurancyValid]
        [Required(ErrorMessage = "l\'assurance de la voiture est obligatoire")]
        public int TimeAssurancy
        {
            get { return timeAssurancy; }
            set { timeAssurancy = value; }
        }

        [Column("delayExchange")]
        [DisplayName("Délai d\'échange")]
        [DelayExchangeValid]
        [Required(ErrorMessage = "le délai d\'échange de la voiture est obligatoire")]
        public int DelayExchange
        {
            get { return delayExchange; }
            set { delayExchange = value; }
        }

        #endregion

        #region Functions

        public override string ToString()
        {

            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        #endregion

    }
}
