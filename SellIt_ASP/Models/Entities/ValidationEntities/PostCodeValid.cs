using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt.Entities.ValidationEntities
{
    class PostCodeValid : ValidationAttribute
    {
        #region Properties
        #endregion

        #region Constructors
        public PostCodeValid() : base("le code postal doit être valide")
        {
        }
        #endregion

        protected override ValidationResult IsValid(Object value,ValidationContext validationContext)
        {
            if (int.TryParse(value.ToString(), out int result))
            {
                if ((result >= 1) && (result <= 98000))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Le code postal n\'est pas valide");
                }
            }
            else
            {
                throw new Exception("value n'est pas un entier");
            }

        }
    }
}
