using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloXamarin.Model
{
    [Table("Recipes")]
    public class RecipeModel : INotifyPropertyChanged
    {

        private int _id;
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                this._id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        private string _name;
        [NotNull]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                this._name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private string _type;
        [NotNull]
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                this._type = value;
                OnPropertyChanged(nameof(Type));
            }
        }

        private string _time;
        [NotNull]
        public string Time
        {
            get
            {
                return _time;
            }
            set
            {
                this._time = value;
                OnPropertyChanged(nameof(Time));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this,
              new PropertyChangedEventArgs(propertyName));
        }
    }
}
