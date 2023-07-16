using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UserInterface.ViewModels
{
    public class MainControlViewModel : ViewModelBase
    {
        public ListingViewModel ListingViewModel { get; }
        public DescriptionsViewModel DescriptionsViewModel { get; }

        public ICommand NewTaskCommand { get; }

        public MainControlViewModel()
        {
            ListingViewModel = new ListingViewModel();
            DescriptionsViewModel = new DescriptionsViewModel();
        }
    }
}
