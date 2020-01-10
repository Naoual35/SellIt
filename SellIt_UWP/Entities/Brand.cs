using System.ComponentModel;

namespace SellIt_UWP.Entities
{
    public class Brand : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        #region attributs
        private long brandId;
        private string name;
        private string description;
        #endregion

        #region properties

        public long BrandId
        {
            get { return brandId; }
            set { brandId = value; }
        }

        //[Index(IsUnique = true)]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        #endregion
    } 
}
