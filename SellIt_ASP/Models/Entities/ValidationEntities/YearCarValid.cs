using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt.Entities.ValidationEntities
{
    public class YearCarValid : ValidationAttribute
    {
        #region Properties
        public int Min { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// initialise une nouvelle instance de YearCarValid
        /// </summary>
        /// <param name="min"> année minimal autorisé pour la date de cnstruction de la voiture</param>
        public YearCarValid(int min) : base("L\'année doit être comprise entre " + min + " et " + DateTime.Now.Year)
        {
            Min = min;
        }


        protected override ValidationResult IsValid(Object value, ValidationContext validationContext)
        {
            int result;
            if (int.TryParse(value.ToString(), out result))
            {
                if ((result >= this.Min) && (result <= DateTime.Now.Year))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("L\'annnée doit être comprise entre " + this.Min + " et " + DateTime.Now.Year);
                }
            }
            else
            {
                return new ValidationResult("Value n'est pas un entier");
            }

        }

        #endregion
    }
}
