
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Students
{
    public class TeacherViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private PersonModel _teacherModel = new PersonModel();//实例化Model中的类
        public PersonModel TeacherModel
        {
            get { return _teacherModel; }
            set { _teacherModel = value; OnPropertyChanged("TeacherModel"); }
        }
    }
}
