using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface.ViewModels
{
    public class EditTaskViewModel:ViewModelBase
    {
        public FormViewModel FormViewModel { get; }
        public EditTaskViewModel()
        {
            FormViewModel = new FormViewModel();
        }
    }
}
