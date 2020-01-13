using SellIt_UWP.Views.ViewModels.UCAccessors.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors
{
    public class LoginPageAccessor
    {
        public LoginAccessor Login { get; set; }

        public LoginPageAccessor()
        {
            this.Login = new LoginAccessor();
        }
    }
}
