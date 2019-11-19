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

        public override bool IsValid(Object value)
        {
            if (int.TryParse(value.ToString(), out int result))
            {
                if ((result >= 0) && (result <= 98000))
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
