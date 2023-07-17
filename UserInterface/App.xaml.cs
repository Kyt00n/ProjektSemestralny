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
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly TasksStore _tasksStore;
        public App()
        {
            _tasksStore = new TasksStore();
            _selectedTaskStore = new SelectedTaskStore();
            _modalNavigationStore = new ModalNavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainControlViewModel mainControlViewModel = new MainControlViewModel(_selectedTaskStore, _modalNavigationStore, _tasksStore);
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_modalNavigationStore, mainControlViewModel)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
