using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Students
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class View : Window
    {
        public static StudetViewModel studentViewModel;//声明一个类，但是没有实例化,把这个viewModel设为static方便其他页面文件互相访问绑定的属性
        public static TeacherViewModel teacherViewModel;
        public View()
        {
            InitializeComponent();
            studentViewModel = StudetGrid.DataContext as StudetViewModel;//在构造方法中实例化viewModel，这个viewModel就是View.xaml中声明的那个ViewModel实例，就是那个桥梁。
            teacherViewModel = TeacherGrid.DataContext as TeacherViewModel;
        }

        private void BtnClick(object sender, RoutedEventArgs e)
        {
            studentViewModel.StudentModel.Name = "小明";
            studentViewModel.StudentModel.Age = "15";
            studentViewModel.StudentModel.Sex = "男";
        }

        private void BtnClickTeacher(object sender, RoutedEventArgs e)
        {
            teacherViewModel.TeacherModel.Name = "王老师";
            teacherViewModel.TeacherModel.Age = "30";
            teacherViewModel.TeacherModel.Sex = "女";
        }
    }
}
