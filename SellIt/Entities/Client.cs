using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ClientId
        {
            get { return clientId; }
            set { clientId = value; }
        }
        #endregion
    }
}
