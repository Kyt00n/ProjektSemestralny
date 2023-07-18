using UserInterface.Stores;

namespace UserInterface.Commands
{
    /// <summary>
    /// Closes Modal(edit and create form page)
    /// </summary>
    public class CloseModalCommand : CommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;

        public CloseModalCommand(ModalNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object? parameter)
        {
            _modalNavigationStore.CurrentViewModel = null;
        }
    }
}
