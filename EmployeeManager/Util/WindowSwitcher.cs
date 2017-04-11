using System;

namespace EmployeeManager.Util
{
  class WindowSwitcher
  {
    static void SwitchWindows(Window window)
    {
        var current = App.Current.MainWindow;
        App.Current.MainWindow = window;

        window.Show();
        current.Close();
    }

    static void GoToMainWindow()
    {
      SwitchWindows(new MainWindow);
    }
  }
}
