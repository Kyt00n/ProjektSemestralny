using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using UserInterface.Stores;
using UserInterface.ViewModels;

namespace UserInterface
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly SelectedTaskStore _selectedTaskStore;
        public App()
        {
            _selectedTaskStore = new SelectedTaskStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainControlViewModel(_selectedTaskStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
