using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManager.ViewModels;
using EmployeeManager.Models;
using EmployeeManager.DataSource;
using Moq;

namespace EmployeeManager.Test
{
    [TestClass]
    public class AddEmployeeUnitTest
    {
        Employee emp = new Employee { Id = 1, Age = 12, Name = "Nikhil" };

        Mock<IDataSource<Employee>> db = new Mock<IDataSource<Employee>>();


        [TestMethod]
        public void AddEmployeeToDataSource()
        {
            AddEmployeeViewModel viewModel = new AddEmployeeViewModel(db.Object);
            viewModel.SaveDelegateCommand.Execute(emp);
            db.Verify(o => o.Add(emp));
        }

    }
}
