using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SellIt_UWP.Views.ViewModels.UCAccessors.Commons
{
    public class ButtonAccessor
    {
        public string Content { get; set; }
        public ICommand Action { get; set; }
    }
}
