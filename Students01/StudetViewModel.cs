using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Students
{
    public class StudetViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private PersonModel _studentModel = new PersonModel();//实例化Model中的类
        public PersonModel StudentModel
        {
            get { return _studentModel; }
            set { _studentModel = value; OnPropertyChanged("StudentModel"); }
        }
    }
}
