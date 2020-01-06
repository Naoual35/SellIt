using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt.Entities.ValidationEntities
{
    class TvaValid : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            float result;

            if (float.TryParse(value.ToString(), out result))
            {
                if ((result >= 0F) && (result <= 0.2))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("La TVA indiquée n\'est pas comprise entre 0 et 0.2 ");
                }
            }
            else
            {
                return new ValidationResult("Value n'est pas un float");
            }
        }
    }
}
