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
        #endregion

        #region Constructors
        public DateValid() : base("la date doit doit être valide.")
        {
        }
        #endregion

        public override bool IsValid(Object value)
        {
            DateTime dtmin = new DateTime(1900, 1, 1);
            if (DateTime.TryParse(value.ToString(), out DateTime result))
            {
                if ((DateTime.Compare(result, dtmin) > 0) && (DateTime.Compare(result, DateTime.Now) < 0))
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
                throw new Exception("value n'est pas une DateTime.");
            }

        }
    }
}
