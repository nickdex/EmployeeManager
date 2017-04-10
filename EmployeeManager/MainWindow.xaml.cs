using EmployeeManager.Models;
using EmployeeManager.ViewModels;
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

namespace EmployeeManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new EmployeeViewModel();
        }

        private void SwitchWindows(Window window)
        {
            var current = App.Current.MainWindow;
            App.Current.MainWindow = window;

            window.Show();
            current.Close();
        }

        private void GoToAddEmployeeWindow(object sender, RoutedEventArgs e)
        {
            AddEmployeeWindow addEmployeeWindow = new AddEmployeeWindow();
            SwitchWindows(addEmployeeWindow);
        }

        private void GoToEditEmployeeWindow(object sender, RoutedEventArgs e)
        {
            Employee Employee = ((FrameworkElement)sender).DataContext as Employee;
            EditEmployeeWindow editEmployeeWindow = new EditEmployeeWindow(Employee);
            SwitchWindows(editEmployeeWindow);
        }

        private void GoToDeleteEmployeeWindow(object sender, RoutedEventArgs e)
        {
            Employee Employee = ((FrameworkElement)sender).DataContext as Employee;
            DeleteEmployeeWindow deleteEmployeeWindow = new DeleteEmployeeWindow(Employee);
            SwitchWindows(deleteEmployeeWindow);
        }

    }
}
