using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManager.ViewModels;
using EmployeeManager.Models;

namespace EmployeeManager.Test
{
    [TestClass]
    public class AddEmployeeUnitTest
    {
        Employee emp = new Employee { Id = 1, Age = 12, Name = "Nikhil" };

        

        [TestMethod]
        public void EmptyIdShouldFail()
        {
            EmployeeViewModel viewModel = new EmployeeViewModel();
            emp.Id = null;
            bool canAdd = viewModel.SaveDelegateCommand.CanExecute(emp);
            Assert.AreEqual(canAdd, false);

        }

        [TestMethod]
        public void EmptyAgeShouldFail()
        {
            EmployeeViewModel viewModel = new EmployeeViewModel();
            emp.Age = null;
            bool canAdd = viewModel.SaveDelegateCommand.CanExecute(emp);
            Assert.AreEqual(canAdd, false);

        }

        [TestMethod]
        public void EmptyNameShouldFail()
        {
            EmployeeViewModel viewModel = new EmployeeViewModel();
            emp.Name = null;
            bool canAdd = viewModel.SaveDelegateCommand.CanExecute(emp);
            Assert.AreEqual(canAdd, false);

        }
    }
}
