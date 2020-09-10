
using Prism.Commands;
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

        public TeacherViewModel()
        {
            this.CommadUpdata = new DelegateCommand(new Action(Updata));//命令属性与方法联系起来
        }

        private void Updata()//方法
        {
            this.TeacherModel.Name = "王老师";
            this.TeacherModel.Age = "30";
            this.TeacherModel.Sex = "女";
        }

        public DelegateCommand CommadUpdata { get; set; }//命令属性
    }
}
