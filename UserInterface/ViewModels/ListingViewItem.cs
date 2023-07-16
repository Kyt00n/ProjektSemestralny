using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UserInterface.ViewModels
{
    public class ListingViewItem:ViewModelBase
    {
        public string Name { get; }
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public ListingViewItem(string name)
        {
            Name = name;
        }
    }
}
