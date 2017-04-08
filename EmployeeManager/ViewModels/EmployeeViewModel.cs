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
    public class EmployeeViewModel
    {
        public Employee Employee { get; set; }
        public DelegateCommand SaveDelegateCommand { get; set; }
        public List<Employee> empList { get; set; }


        private IDataSource<Employee> dataSource;
        private IMessageViewer _viewer;

        private EmployeeViewModel _instance;

        public EmployeeViewModel getInstance()
        {
            if (_instance == null)
            {
                _instance = new EmployeeViewModel();
            }

            return _instance;
            
        }

        private EmployeeViewModel()
        {
            dataSource = new LocalDataSource();
            SaveDelegateCommand = new DelegateCommand(canAddEmployee, AddEmployee);
            _viewer = new MessageViewer();

            empList = dataSource.GetAllItems();

            empList.Add(new Employee { Id = 1, Age = 2, Name = "Ojasvi" });
            empList.Add(new Employee { Id = 12, Age = 22, Name = "Nikhil" });

        }
        private void AddEmployee(object obj)
        {
            Employee employee = obj as Employee;
            if (employee != null)
            {
                dataSource.Add(employee);
            }
            else
            {
                _viewer.Show("Check Employee Details");
            }

        }

        private bool canAddEmployee(object obj)
        {
            Employee emp = obj as Employee;

            var id = emp.Id;
            var age = emp.Age;
            var name = emp.Name;

            if (id == null || age == null || string.IsNullOrWhiteSpace(name))
            {
                return false;
            }
            return true;
        }
    }
}
