using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt.Entities.ValidationEntities
{
    class PriceValid : ValidationAttribute
    {
        #region Attributes
        public float Max { get; set; }
        #endregion

        #region Constructors
        public PriceValid(float max) : base("Le prix doit être compris entre 1 et " + max + " euros")
        {
            this.Max = max;
        }

        protected override ValidationResult IsValid(Object value, ValidationContext validationContext)
        {
            float result;

            if (float.TryParse(value.ToString(), out result))
            {
                if ((result >= 1F) && (result <= this.Max))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Le prix indiqué n\'est pas compris entre 1 et " + this.Max + "euros");
                }
            }
            else
            {
                return new ValidationResult("value n\'est pas un float");
            }
        }

        #endregion
    }
}
