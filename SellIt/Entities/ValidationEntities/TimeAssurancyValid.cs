using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt.Entities.ValidationEntities
{
    class TimeAssurancyValid : ValidationAttribute
    {
        #region Properties
        #endregion

        #region Constructors
        public TimeAssurancyValid() : base("la garantie  doit être positive")
        {
        }
        #endregion

        public override bool IsValid(Object value)
        {
            if (int.TryParse(value.ToString(), out int result))
            {
                if (result >= 0)
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
    }
}
