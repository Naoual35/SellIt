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
        #endregion

        #region Constructors
        public YearCarValid() : base("L'année doit être comprise entre 1980 et 2019")
        {
        }

        public override bool IsValid(Object value)
        {
            if (int.TryParse(value.ToString(), out int result))
            {
                if ((result >= 1980) && (result <= 2019))
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
                throw new Exception("value n'est pas un entier");
            }

        }

        #endregion

    }
}
