using System.Windows.Input;

namespace UserInterface.ViewModels
{
    /// <summary>
    /// View model for form used in both Editting and Adding new Task. 
    /// </summary>
    public class FormViewModel : ViewModelBase
    {
        private string _taskname;
        public string TaskName
        { 
            get { return _taskname; } 
            set 
            { 
                _taskname = value; 
                OnPropertyChanged(nameof(TaskName));
                OnPropertyChanged(nameof(CanSubmit));
            }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }
        private string _priority;
        public string Priority
        {
            get { return _priority; }
            set
            {
                _priority = value;
                OnPropertyChanged(nameof(Priority));
            }
        }
        private string _location;

        public FormViewModel(ICommand submitCommand, ICommand cancelCommand)
        {
            SubmitCommand = submitCommand;
            CancelCommand = cancelCommand;
        }

        public string Location
        {
            get { return _location; }
            set
            {
                _location = value;
                OnPropertyChanged(nameof(Location));
            }
        }
        public bool CanSubmit => !string.IsNullOrEmpty(TaskName);
        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }


    }
}
