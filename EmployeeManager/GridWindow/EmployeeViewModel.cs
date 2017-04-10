using EmployeeManager.Base;
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
    class EmployeeViewModel
    {
        public List<Employee> empList { get; set; }

        private IDataSource<Employee> dataSource;
        private IMessageViewer _viewer;

        public EmployeeViewModel ()
	    {
            dataSource = new LocalDataSource();
            _viewer = new MessageViewer();

            empList = dataSource.GetAllItems();
	    }
       
    }
}
