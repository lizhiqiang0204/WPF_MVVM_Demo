using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Students
{
    public class PersonModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string name;
        public String Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }

        private string age;
        public String Age
        {
            get { return age; }
            set { age = value; OnPropertyChanged("Age"); }
        }

        private string sex;
        public String Sex
        {
            get { return sex; }
            set { sex = value; OnPropertyChanged("Sex"); }
        }
    }
}
