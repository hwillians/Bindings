using System.Windows.Input;
using view.Models;

namespace view.ViewModels
{
    class ViewModelString : ViewModelBase
    {
        private string test = "Texte test";

        public string Test
        {
            get { return test; }
            set
            {
                test = value;
                OnPropertyChanged(nameof(Test));
            }
        }


        public ICommand EditTest
        {
            get
            {
                return new RelayCommand(param =>
                {
                    Test = "Texte modifié";
                });
            }
        }
    }
}
