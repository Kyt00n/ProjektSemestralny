﻿using System;
using System.Threading.Tasks;
using BackEnd.Models;
using UserInterface.Stores;
using UserInterface.ViewModels;

namespace UserInterface.Commands
{
    /// <summary>
    /// Create functionality for CRUD application.
    /// </summary>
    public class SubmitCommand : AsyncCommandBase
    {
        private readonly AddNewTaskViewModel addNewTaskViewModel;
        private readonly ModalNavigationStore _modalNavigationStore;

        public SubmitCommand(AddNewTaskViewModel addNewTaskViewModel, ModalNavigationStore modalNavigationStore, TasksStore tasksStore)
        {
            this.addNewTaskViewModel = addNewTaskViewModel;
            _modalNavigationStore = modalNavigationStore;
            TasksStore = tasksStore;
        }

        public TasksStore TasksStore { get; }

        public override async Task ExecuteAsync(object parameter)
        {
            var formTask = addNewTaskViewModel.FormViewModel;
            TaskModel tm = new TaskModel(Guid.NewGuid(),formTask.TaskName, formTask.Description, formTask.Priority, formTask.Location);
            try
            {
                await TasksStore.Add(tm);
                _modalNavigationStore.CurrentViewModel = null;
            }
            catch(Exception) { }
            
        }
    }
}
