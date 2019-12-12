using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt.Entities
{
    public class Category
    {
        #region Attributs
        private long categoryId;
        private string name;
        private Brand brand;
        private string description;
        private float tva;
        private float price;
        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }

        [Column("name")]
        [MaxLength(200)]
        [MinLength(1)]
        [Required]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [Column("description")]
        [MaxLength(200)]
        [MinLength(1)]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        [Column("brand")]
        [Required(ErrorMessage = "une marque est obligatoire")]
        public Brand Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        [Column("price")]
        [Required(ErrorMessage = "un prix est obligatoire")]
        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        [Column("tva")]
        [Required(ErrorMessage = "une tva est obligatoire")]
        public float Tva
        {
            get { return tva; }
            set { tva = value; }
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
