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
                dataSource.Add(employee);
                GoToMainWindow();
            }
            else
            {
                _viewer.Show("Check Employee Details");
            }

        }

        private void GoToMainWindow()
        {
            throw new NotImplementedException();
        }

        private bool canAddEmployee(object obj)
        {
            //Employee emp = obj as Employee;

            //if (emp == null)
            //{
            //    return false;
            //}

            //var id = emp.Id;
            //var age = emp.Age;
            //var name = emp.Name;

            //if (id == null || age == null || string.IsNullOrWhiteSpace(name))
            //{
            //    return false;
            //}
            return true;
        }
    }
}
