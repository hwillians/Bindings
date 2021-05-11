using System.Collections.ObjectModel;
using System.Windows.Input;
using view.Models;
using System;

namespace view.ViewModels
{
    public class ViewModelRandom : ViewModelBase
    {
       
        private int randomNumber = new Random().Next(0, 20);

        public int RandomNumber
        {
            get { return randomNumber; }
            set
            {
                randomNumber = value;
                OnPropertyChanged("RandomNumber");
            }
        }

        public ICommand ChangeNumber
        {
            get
            {
                return new RelayCommand(param =>
                {
                    RandomNumber = new Random().Next(0, 20);
                });
            }
        }



    }
}
