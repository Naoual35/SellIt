﻿using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Entities
{
    public abstract class EntityBase : INotifyPropertyChanged
    {
        private long id;

        [PrimaryKey,AutoIncrement]
        public long Id
        {
            get { return id; }
            set { id = value; }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public abstract Object Copy();
        public abstract void CopyFrom(Object obj);
    }
}
