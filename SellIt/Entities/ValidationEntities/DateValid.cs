using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt.Entities.ValidationEntities
{
    class DateValid : ValidationAttribute
    {
        #region Properties
        public string Mode { get; set; }
        #endregion

        #region Constructors
        public DateValid(string mode) : base("la date doit doit être valide.")
        {
            this.Mode = mode;
        }
        #endregion

        protected override ValidationResult IsValid(Object value, ValidationContext validationContext)
        {
            DateTime minDate;
            DateTime result;

            if (Mode.Equals("order"))
            {
                minDate = DateTime.Now;
            }
            else if (Mode.Equals("birth"))
            {
                minDate = new DateTime(1930, 1, 1);
            }
            else
            {
                Object instance = validationContext.ObjectInstance;
                Type type = instance.GetType();
                Object data = type.GetProperty("DateOrder").GetValue(instance, null);
                minDate = (DateTime)data;
            }

            if (DateTime.TryParse(value.ToString(), out result))
            {
                if (DateTime.Compare(result, minDate) >= 0)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    if (this.Mode == "order")
                    {
                        return new ValidationResult("La date de commande est inférieure à la date du jour");
                    }
                    else if (this.Mode == "birth")
                    {
                        return new ValidationResult("La date de naissance est inférieure à 1930");
                    }
                    else
                    {
                        return new ValidationResult("La date de livraison est inférieure à la date de commande");
                    }

                }
            }
            else
            {
                return new ValidationResult("Value n\'a pas le bon format de date (dd/MM/yyyy)");
            }

        }
    }
}
