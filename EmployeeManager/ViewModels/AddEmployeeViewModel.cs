using EmployeeManager.Models;
using EmployeeManager.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManager.Commands;
using EmployeeManager.Implementations;
using EmployeeManager.Base;

namespace EmployeeManager.ViewModels
{
    public class AddEmployeeViewModel
    {
        public Employee Employee { get; set; }
        public DelegateCommand SaveDelegateCommand { get; set; }

        private IDataSource<Employee> dataSource;
        private IMessageViewer _viewer;

        public AddEmployeeViewModel()
        {
            Employee = new Employee();
            dataSource = new LocalDataSource();
            _viewer = new MessageViewer();
            SaveDelegateCommand = new DelegateCommand(canAddEmployee, AddEmployee);

        }

        private void AddEmployee(object obj)
        {
            Employee employee = obj as Employee;
            if (employee != null)
            {
                try
                {
                    dataSource.Add(employee);
                    GoToMainWindow();
                }
                catch (ArgumentException)
                {
                    _viewer.Show("Duplicate Id. Please change it");
                }
                
            }
            else
            {
                _viewer.Show("Check Employee Details");
            }

        }

        private void GoToMainWindow()
        {
            MainWindow window = new MainWindow();
            var current = App.Current.MainWindow;
            App.Current.MainWindow = window;

            window.Show();
            current.Close();
        }

        private bool canAddEmployee(object obj)
        {
            return true;
        }
    }
}
