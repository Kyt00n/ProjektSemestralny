using UserInterface.Stores;

namespace UserInterface.ViewModels
{
    public class MainViewModel:ViewModelBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;

        public MainControlViewModel MainControlViewModel { get; }
        public ViewModelBase CurrentModalViewModel => _modalNavigationStore.CurrentViewModel;
        public string IsModalOpen => _modalNavigationStore.isOpen ? "Visable" : "Hidden";
        public MainViewModel(ModalNavigationStore modalNavigationStore, MainControlViewModel mainControlViewModel)
        {
            _modalNavigationStore = modalNavigationStore;
            MainControlViewModel = mainControlViewModel;
            _modalNavigationStore.CurrentViewModelChanged += ModalNavigationStore_CurrentBiewModelChanged;
        }

        private void ModalNavigationStore_CurrentBiewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentModalViewModel));
            OnPropertyChanged(nameof(IsModalOpen));
        }
    }
}
