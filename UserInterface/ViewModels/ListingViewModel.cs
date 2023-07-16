using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.Stores;

namespace UserInterface.ViewModels
{
    public class ListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ListingViewItem> _listingViewItems;
        public IEnumerable<ListingViewItem> ListingViewItems => _listingViewItems;
        public ListingViewModel(SelectedTaskStore selectedTaskStore)
        {
            _listingViewItems = new ObservableCollection<ListingViewItem>
            {
                new ListingViewItem("task1"),
                new ListingViewItem("task2"),
                new ListingViewItem("task3")
            };
        }
    }
}
