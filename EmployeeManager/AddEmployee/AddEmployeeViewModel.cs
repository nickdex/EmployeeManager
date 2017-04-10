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
    class AddEmployeeViewModel : BaseViewModel
    {
        public Employee Employee { get; set; }
        public DelegateCommand SaveDelegateCommand { get; set; }

        private IDataSource<Employee> _dataSource;
        private IMessageViewer _viewer;

        private void Init()
        {
            Employee = new Employee();
            _viewer = new MessageViewer();
            SaveDelegateCommand = new DelegateCommand(canAddEmployee, AddEmployee);
        }

        public AddEmployeeViewModel() : this(new LocalDataSource())
        {
            
        }

        public AddEmployeeViewModel(IDataSource<Employee> dataSource){
            _dataSource = dataSource;
            Init();
        }

        private void AddEmployee(object obj)
        {
            Employee employee = obj as Employee;
            if (employee != null)
            {
                try
                {
                    _dataSource.Add(employee);
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

        private bool canAddEmployee(object obj)
        {
            return true;
        }
    }
}
