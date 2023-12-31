﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.ViewModels;

namespace UserInterface.Stores
{
    /// <summary>
    /// Class that controls if Modal( Edit and Create Form Pages) is open.
    /// </summary>
    public class ModalNavigationStore
    {
        public bool isOpen => CurrentViewModel != null;
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get { return _currentViewModel; }
            set 
            { 
                _currentViewModel = value;
                CurrentViewModelChanged?.Invoke();
            }
        }
        public event Action CurrentViewModelChanged;
    }
}
