using BackEnd.Models;
using System;
using System.Threading.Tasks;
using UserInterface.Stores;
using UserInterface.ViewModels;

namespace UserInterface.Commands
{
    /// <summary>
    /// Delete functionality for CRUD application.
    /// </summary>
    public class RemoveCommand : AsyncCommandBase
    {
        
        private ListingViewItem listingViewItem;
        private TasksStore tasksStore;

        public RemoveCommand(ListingViewItem listingViewItem, TasksStore tasksStore)
        {
            this.listingViewItem = listingViewItem;
            this.tasksStore = tasksStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            TaskModel tm = listingViewItem.Taskmodel;
            try
            {
                await tasksStore.Remove(tm.Id);
            }
            catch (Exception ex) { }
        }
    }
}
