using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using view.Models;

namespace view.ViewModels
{
    class ViewModelMessage : ViewModelBase
    {
        public ObservableCollection<Message> Messages { get; set; } = new ObservableCollection<Message> {
            new Message { Emetteur = "E0" , Contenu="Contenue 0", Date=  DateTime.Now} ,
            new Message { Emetteur = "E1" , Contenu="Contenue 1", Date= DateTime.Now}
        };
        public int SelectedMessageIndex { get; set; } = -1;

        public ICommand AddToMessages
        {
            get
            {
                return new RelayCommand(param =>
                Messages.Add(new Message { Emetteur = "E" + Messages.Count, Contenu = "Contenue " + Messages.Count, Date = DateTime.Now }));
            }
        }

        public ICommand EditMessage
        {
            get
            {
                return new RelayCommand(param =>
                {
                    var message = Messages[SelectedMessageIndex];
                    Messages[SelectedMessageIndex] = new Message { Emetteur = message.Emetteur, Contenu = "Contenue Modifié", Date = message.Date };
                },
                param => SelectedMessageIndex >= 0 && Messages.Count > 0);
            }
        }

        public ICommand DeleteMessage
        {
            get
            {
                return new RelayCommand(param =>
                {
                    Messages.RemoveAt(SelectedMessageIndex);
                },
                param => SelectedMessageIndex >= 0 && Messages.Count > 0);
            }
        }

        public ICommand EditFirstMessage
        {
            get
            {
                return new RelayCommand(param =>
                {
                    var message = Messages[0];
                    Messages[0] = new Message { Emetteur = message.Emetteur, Contenu = "Contenue Modifié", Date = message.Date };
                },
                param => Messages.Count > 0);
            }
        }

        public ICommand DeleteFirstMessage
        {
            get
            {
                return new RelayCommand(param =>
                {
                    Messages.RemoveAt(0);
                },
                param => Messages.Count > 0);
            }
        }

        public ICommand EditFirstMessageTemplate
        {
            get
            {
                return new RelayCommand(param =>
                {
                    Messages[0].Contenu = "Contenue Modifié";
                },
                param => Messages.Count > 0);
            }
        }

        public ICommand EditThisMessage
        {
            get
            {
                return new RelayCommand(param =>
                {
                    (param as Message).Contenu = "Modifié";
                },
                param => Messages.Count > 0);
            }
        }

        public ICommand DeleteThisMessage
        {
            get
            {
                return new RelayCommand(param =>
                {
                    Messages.Remove(param as Message);
                },
                param => Messages.Count > 0);
            }
        }

    }
}
