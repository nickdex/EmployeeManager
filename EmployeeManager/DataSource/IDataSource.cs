using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.DataSource
{
    public interface IDataSource<T>
    {
        void Add(T item);
        bool Delete(int itemId);
        void Update(int itemId, T item);
        T GetItem(int itemId);
        List<T> GetAllItems();
    }
}
