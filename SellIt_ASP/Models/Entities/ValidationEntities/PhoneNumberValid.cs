using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt.Entities.ValidationEntities
{
    class PhoneNumberValid : ValidationAttribute
    {
        #region Properties
        #endregion

        #region Constructors
        public PhoneNumberValid() : base("le numéro de téléphone doit être valide")
        {
        }
        #endregion

        public override bool IsValid(Object value)
        {
            bool result = false;
            int i = 0;
            string str = value.ToString();

            if (str.Count() == 10)
            {
                while (i < str.Count())
                {
                    if (!int.TryParse(str.Substring(i, 1), out _))
                    {
                        break;
                    }
                    i += 1;
                }

                if (i == 10)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
