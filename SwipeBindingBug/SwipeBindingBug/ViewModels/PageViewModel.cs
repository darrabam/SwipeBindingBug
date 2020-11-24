using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SwipeBindingBug.ViewModels
{

    public class PageViewModel : BaseViewModel
    {
        public ObservableRangeCollection<string> Items { get; set; } = new ObservableRangeCollection<string>();
        private string buttonLabel;
        private bool isSwipeViewEnabled;
        public ICommand SwitchSwipeViewStatus => new Command(SwitchSwipe);
        public string ButtonLabel
        {
            get
            {
                return buttonLabel;
            }
            set
            {
                buttonLabel = value;
                this.OnPropertyChanged("ButtonLabel");
            }
        }

        public bool IsSwipeViewEnabled
        {
            get
            {
                return isSwipeViewEnabled;
            }
            set
            {
                isSwipeViewEnabled = value;
                this.OnPropertyChanged("IsSwipeViewEnabled");
            }
        }

        public PageViewModel()
        {
            Items.AddRange(new List<string> { "Baboon", "Capuchin Monkey", "Blue Monkey", "Squirrel Monkey", "Golden Lion Tamarin", "Howler Monkey", "Japanese Macaque" });
            IsSwipeViewEnabled = true;
            ButtonLabel = $"Is SwipeView Enabled: {IsSwipeViewEnabled}";
        }
        public void SwitchSwipe()
        {
            IsSwipeViewEnabled = !IsSwipeViewEnabled;
            ButtonLabel = $"Is SwipeView Enabled: {IsSwipeViewEnabled}";
        }
    }

    
}
