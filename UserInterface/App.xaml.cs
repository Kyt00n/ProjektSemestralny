using BackEnd.Commands;
using BackEnd.EntityFramework;
using BackEnd.EntityFramework.Commands;
using BackEnd.EntityFramework.Queries;
using BackEnd.Queries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using UserInterface.Stores;
using UserInterface.ViewModels;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace UserInterface
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly TasksDbContextFactory tasksDbContextFactory;
        private readonly IAddTaskCommand addTaskCommand;
        private readonly IRemoveTaskCommand removeTaskCommand;
        private readonly IEditTaskCommand editTaskCommand;
        private readonly IGetAllTasksQuery query;
        private readonly SelectedTaskStore _selectedTaskStore;
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly TasksStore _tasksStore;
        public App()
        {
            string _connectionString = "Data Source=ProjektSemestralny.db";
            
            tasksDbContextFactory = new TasksDbContextFactory(
                new DbContextOptionsBuilder().UseSqlite(_connectionString).Options);
            query = new GetAllTasks(tasksDbContextFactory);
            addTaskCommand = new AddTaskCommand(tasksDbContextFactory);
            removeTaskCommand = new RemoveTaskCommand(tasksDbContextFactory);
            editTaskCommand = new EditTaskCommand(tasksDbContextFactory);
            _tasksStore = new TasksStore(addTaskCommand, removeTaskCommand, editTaskCommand, query);
            _selectedTaskStore = new SelectedTaskStore(_tasksStore);
            _modalNavigationStore = new ModalNavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            using (TaskDBcontext context = tasksDbContextFactory.Create())
            {
                context.Database.Migrate();
            }
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
