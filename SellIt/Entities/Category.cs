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
    [Table("Category")]
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
        [DisplayName("Nom")]
        [StringLength(50, ErrorMessage = "le nom de la catégorie ne peut pas contenir plus de 50 caractères", MinimumLength = 1)]
        [Required(ErrorMessage = "Le nom de la marque est obligatoire")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [Column("description")]
        [DisplayName("Description")]
        [StringLength(200, ErrorMessage = "la description de la catégorie ne peut pas contenir plus de 200 caractères", MinimumLength = 1)]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        [Column("brand")]
        [DisplayName("Marque")]
        [Required(ErrorMessage = "une marque est obligatoire")]
        public virtual Brand Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        [Column("price")]
        [DisplayName("Prix")]
        [PriceValid(250000)]
        [Required(ErrorMessage = "un prix est obligatoire")]
        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        [Column("tva")]
        [DisplayName("TVA")]
        [Required(ErrorMessage = "une tva est obligatoire")]
        [TvaValid]
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
