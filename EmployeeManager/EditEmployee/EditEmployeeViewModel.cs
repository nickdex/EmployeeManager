using EmployeeManager.Base;
using EmployeeManager.Commands;
using EmployeeManager.DataSource;
using EmployeeManager.Implementations;
using EmployeeManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.ViewModels
{
    class EditEmployeeViewModel : BaseViewModel
    {
        public Employee Employee { get; set; }
        public DelegateCommand UpdateDelegateCommand { get; set; }

        private IDataSource<Employee> dataSource;
        private IMessageViewer _viewer;

        public EditEmployeeViewModel()
        {
            dataSource = new LocalDataSource();
            _viewer = new MessageViewer();
            UpdateDelegateCommand = new DelegateCommand(canEditEmployee, UpdateEmployee);
        }

        public EditEmployeeViewModel(Employee employee) : this()
        {
            Employee = employee;
        }

        private void UpdateEmployee(object obj)
        {
            Employee employee = obj as Employee;
            if (employee != null)
            {
                dataSource.Update(employee.Id, employee);
                GoToMainWindow();
            }
            else
            {
                _viewer.Show("Check Employee details");
            }
        }

        private bool canEditEmployee(object obj)
        {
            return true;
        }

       
    }
}
