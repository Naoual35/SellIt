﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt.Entities.ValidationEntities
{
    class DelayExchangeValid : ValidationAttribute
    {
        #region Properties
        #endregion

        #region Constructors
        public DelayExchangeValid() : base("le delai d'échange doit être positif")
        {
        }

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

        #endregion
    }
}
