using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt.Entities
{
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
        [MaxLength(200)]
        [MinLength(1)]
        [Required(ErrorMessage = "un nom de taille comprise entre 2 et 200 caractères est requis")]
        //[Index(IsUnique = true)]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [Column("description")]
        [MaxLength(400)]
        [MinLength(4)]
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
