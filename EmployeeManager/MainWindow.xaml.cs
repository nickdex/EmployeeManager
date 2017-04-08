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

        private void GoToAddEmployeeWindow(object sender, RoutedEventArgs e)
        {
            AddEmployeeWindow window = new AddEmployeeWindow();
            var current =  App.Current.MainWindow;
            App.Current.MainWindow = window;

            current.Close();
        }
    }
}
