using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Base
{
    class BaseViewModel
    {
        protected void GoToMainWindow()
        {
            MainWindow window = new MainWindow();
            var current = App.Current.MainWindow;
            App.Current.MainWindow = window;

            window.Show();
            current.Close();
        }
    }
}
