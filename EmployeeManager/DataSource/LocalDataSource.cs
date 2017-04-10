using EmployeeManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.DataSource
{
    class LocalDataSource : IDataSource<Employee>
    {
        private static Dictionary<int?,Employee> employees;

        public LocalDataSource()
        {
            if (employees == null)
            {
                employees = new Dictionary<int?, Employee>();
            }
        }

        public void Add(Employee item)
        {
            employees.Add(item.Id, item);
        }

        public bool Delete(int itemId)
        {
            return employees.Remove(itemId);
        }

        public void Update(int itemId, Employee item)
        {
            employees[itemId] = item;
        }

        public  Employee GetItem(int itemId)
        {
            return employees[itemId];
        }

        public List<Employee> GetAllItems()
        {
            var list = employees.ToList();
            return list.Select(o => o.Value).ToList();
        }
    }
}
