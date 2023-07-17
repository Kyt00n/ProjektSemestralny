using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.Stores;

namespace UserInterface.Commands
{
    public class EditCommand : AsyncCommandBase
    {

        private readonly ModalNavigationStore _modalNavigationStore;

        public EditCommand(ModalNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            _modalNavigationStore.CurrentViewModel = null;
        }
    }
}
