using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UserInterface.Models;

namespace UserInterface.ViewModels
{
    public class ListingViewItem:ViewModelBase
    {
        public TaskModel Taskmodel;

        public string Name => Taskmodel.TaskName;
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public ListingViewItem(TaskModel taskmodel)
        {
            this.Taskmodel = taskmodel;
        }
    }
}
