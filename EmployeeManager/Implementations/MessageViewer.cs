using EmployeeManager.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EmployeeManager.Implementations
{
    class MessageViewer : IMessageViewer
    {
        public void Show(string p)
        {
            MessageBox.Show(p);
        }
    }
}
