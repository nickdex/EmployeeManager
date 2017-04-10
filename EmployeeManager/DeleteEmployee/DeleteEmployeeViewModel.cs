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
    class DeleteEmployeeViewModel : BaseViewModel
    {
        public Employee Employee { get; set; }
        public DelegateCommand AffirmativeDeleteDelegateCommand { get; set; }
        public DelegateCommand NegativeDeleteDelegateCommand { get; set; }
        private IDataSource<Employee> dataSource;
        private IMessageViewer _viewer;

        public DeleteEmployeeViewModel()
        {
            dataSource = new LocalDataSource();
            _viewer = new MessageViewer();
            AffirmativeDeleteDelegateCommand = new DelegateCommand(canDeleteEmployee, DeleteEmployee);
            NegativeDeleteDelegateCommand = new DelegateCommand(canGoBackToMainWindow, GoToMainWindow);
        }

        public DeleteEmployeeViewModel(Employee employee)
            : this()
        {
            Employee = employee;
        }

        #region Delegate Methods
        private bool canGoBackToMainWindow(object obj)
        {
            return true;
        }

        private void DeleteEmployee(object obj)
        {
            dataSource.Delete(Employee.Id);
            GoToMainWindow();
        }

        private bool canDeleteEmployee(object obj)
        {
            return true;
        }

        private void GoToMainWindow(object obj)
        {
            GoToMainWindow();
        } 
        #endregion

       
    }
}
