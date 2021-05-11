using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using view.Models;

namespace view.ViewModels
{
    class ViewModelListString : ViewModelBase
    {
        public ObservableCollection<string> ListStrings { get; set; } = new ObservableCollection<string> { "Value 1", "Value 2" };
        public int SelectedStringIndex { get; set; } = -1;
        public ICommand AddToList
        {
            get
            {
                return new RelayCommand(param =>
                {
                    ListStrings.Add($"Value {ListStrings.Count + 1}");
                });
            }
        }

        public ICommand EditLastElement
        {
            get
            {
                return new RelayCommand(param =>
                {
                    ListStrings[ListStrings.Count - 1] = "Value modifié";
                },
                param => ListStrings.Count > 0);
            }
        }

        public ICommand DeleteLastElement
        {
            get
            {
                return new RelayCommand(param =>
                {
                    ListStrings.RemoveAt(ListStrings.Count - 1);
                },
                param => ListStrings.Count > 0);
            }
        }

        public ICommand EditSelectedElement
        {
            get
            {
                return new RelayCommand(param =>
                {
                    ListStrings[SelectedStringIndex] = "Value modifié";
                },
                param => SelectedStringIndex >= 0 & ListStrings.Count > 0);
            }
        }

        public ICommand DeleteSelectElement
        {
            get
            {
                return new RelayCommand(param =>
                {
                    ListStrings.RemoveAt(SelectedStringIndex);
                },
                param => SelectedStringIndex >= 0 && ListStrings.Count > 0);
            }
        }
    }
}
