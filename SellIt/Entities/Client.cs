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
        private long clientID;
        #endregion


        #region properties
        public long ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }
        #endregion
    }
}
