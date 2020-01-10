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
    [Table("Brand")]
    public class Brand
    {
        #region attributs
        private long brandId;
        private string name;
        private string description;
        #endregion

        #region properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long BrandId
        {
            get { return brandId; }
            set { brandId = value; }
        }

        [Column("name")]
        [DisplayName("Nom")]
        [StringLength(50, ErrorMessage = "La marque de la voiture ne peut pas contenir plus de 50 caractères", MinimumLength = 1)]
        [Required(ErrorMessage = "Un nom pour la marque est obligatoire")]
        //[Index(IsUnique = true)]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [Column("description")]
        [DisplayName("Description")]
        [StringLength(200, ErrorMessage = "La description de la marque ne peut pas contenir plus de 200 caractères", MinimumLength = 1)]
        public string Description
        {
            get { return description; }
            set { description = value; }
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
