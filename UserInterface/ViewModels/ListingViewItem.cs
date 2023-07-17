﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UserInterface.Commands;
using BackEnd.Models;
using UserInterface.Stores;

namespace UserInterface.ViewModels
{
    public class ListingViewItem:ViewModelBase
    {
       
        private TasksStore tasksStore;
        private ModalNavigationStore modalNavigationStore;

        public TaskModel Taskmodel { get; set; }

        public string Name => Taskmodel.TaskName;
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public ListingViewItem(TaskModel taskmodel, ICommand editCommand)
        {
            this.Taskmodel = taskmodel;
           
        }

        public ListingViewItem(TaskModel taskmodel, TasksStore tasksStore, ModalNavigationStore modalNavigationStore)
        {
            this.Taskmodel = taskmodel;
            this.tasksStore = tasksStore;
            this.modalNavigationStore = modalNavigationStore;
            EditCommand = new OpenEditTaskCommand(this, tasksStore, modalNavigationStore);
        }

        public void Edit(TaskModel obj)
        {
            Taskmodel = obj;
            OnPropertyChanged(nameof(Name));
        }
    }
}
