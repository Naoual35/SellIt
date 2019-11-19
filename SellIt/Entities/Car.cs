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
    public class Car
    {
        #region Attributs
        private long carId;
        private string nom;
        private Category category;
        private int year;
        private int timeAssurancy;
        private bool avalaible;
        private int delayExchange;
        private string color;
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
        [MaxLength(200)]
        [MinLength(1)]
        [Required(ErrorMessage = "le modèle de la voiture est obligatoire")]
        public string Name
        {
            get { return nom; }
            set { nom = value; }
        }

        [Column("category")]
        [Required(ErrorMessage = "la catégorie de la voiture est obligatoire")]
        public Category Category
        {
            get { return category; }
            set { category = value; }
        }

        [Column("year")]
        [YearCarValid]
        [Required(ErrorMessage = "l'année de la voiture est obligatoire")]
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        [Column("color")]
        [MaxLength(200)]
        [MinLength(2)]
        [Required(ErrorMessage = "la couleur de la voiture est obligatoire")]
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        [Column("avalaible")]
        [Required(ErrorMessage = "la disponibilité de la voiture est obligatoire")]
        public bool Avalaible
        {
            get { return avalaible; }
            set { avalaible = value; }
        }

        [Column("timeAssurancy")]
        [TimeAssurancyValid]
        [Required(ErrorMessage = "l'assurance de la voiture est obligatoire")]
        public int TimeAssurancy
        {
            get { return timeAssurancy; }
            set { timeAssurancy = value; }
        }

        [Column("delayExchange")]
        [DelayExchangeValid]
        [Required(ErrorMessage = "le délai d'échange de la voiture est obligatoire")]
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
