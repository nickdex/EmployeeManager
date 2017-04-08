using EmployeeManager.Base;
using EmployeeManager.Commands;
using EmployeeManager.DataSource;
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
using System.Windows.Shapes;

namespace EmployeeManager
{
    /// <summary>
    /// Interaction logic for AddEmployeeWindow.xaml
    /// </summary>
    public partial class AddEmployeeWindow : Window
    {
        
        public AddEmployeeViewModel _viewModel {get; set;}

        public AddEmployeeWindow()
        {
            InitializeComponent();
            this.DataContext = new AddEmployeeViewModel();
        }

    }
}
