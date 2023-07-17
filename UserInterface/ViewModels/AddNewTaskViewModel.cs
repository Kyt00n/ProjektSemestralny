using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.Commands;
using UserInterface.Stores;

namespace UserInterface.ViewModels
{
    public class AddNewTaskViewModel:ViewModelBase
    {
        public FormViewModel FormViewModel { get;  }
        public AddNewTaskViewModel(ModalNavigationStore modalNavigationStore)
        {
            FormViewModel = new FormViewModel(null, new CloseModalCommand(modalNavigationStore));
        }
    }
}
