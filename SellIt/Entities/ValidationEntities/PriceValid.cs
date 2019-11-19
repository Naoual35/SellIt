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
        #region Properties
        #endregion

        #region Constructors
        public PriceValid() : base("le prix doit être positif")
        {
        }

        public override bool IsValid(Object value)
        {
            if (float.TryParse(value.ToString(), out float result))
            {
                if (result >= 0D)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new Exception("value n'est pas un float");
            }

        }

        #endregion
    }
}
