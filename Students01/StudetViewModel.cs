using Prism.Commands;
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

        public StudetViewModel()
        {
            this.CommadUpdata = new DelegateCommand(new Action(Updata));//命令属性与方法联系起来
        }

        private void Updata()//方法
        {
            this.StudentModel.Name = "小明";
            this.StudentModel.Age = "15";
            this.StudentModel.Sex = "男";
        }

        public DelegateCommand CommadUpdata { get; set; }//命令属性
    }
}
