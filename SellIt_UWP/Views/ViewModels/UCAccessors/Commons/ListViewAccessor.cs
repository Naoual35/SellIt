﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SellIt_UWP.Views.ViewModels.UCAccessors.Commons
{
    public class ListViewAccessor<T> where T: new()
    {
        public T SelectedItem { get; set; }
        public ICommand SelectionChanged { get; set; }

        public ListViewAccessor()
        {
            this.SelectedItem = new T();
        }
    }
}
