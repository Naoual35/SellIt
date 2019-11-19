using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt.Entities
{
    public class Client : Person
    {

        #region attribut
        private long clientId;
        #endregion


        #region properties
        public long ClientId
        {
            get { return clientId; }
            set { clientId = value; }
        }
        #endregion
    }
}
