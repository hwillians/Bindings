using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using view.Models;

namespace view.ViewModels
{
	class ViewModelFind : ViewModelBase
	{
		public ObservableCollection<string> Words { get; set; } =
			new ObservableCollection<string> {"Sauce","Historique","Empreinte","Laryngite","Blessure","Miette",
				"Ressorts","Barre","Moteur","Joker","Supermarché","Agrandir","Raquette","Mexique","Pause",
				"Torpille","Petit","Traducteur","Couverture","Château","Crocs","Ranch","Hanche","Uniforme",
				"Bonbons","Plaquettaire","Vignoble","Gouvernement","Exploiter","Coassement","Tulipe","Bordeaux",
				"Slips","Poulpe","Frelon","Exploiter","Coupe","Vache","Public","Taverne"};

		public ObservableCollection<string> WordsResult { get; set; }

		private string wordToFind;

		public string WordToFind
		{
			get { return wordToFind; }
			set
			{
				wordToFind = value;
				
				OnPropertyChanged(nameof(WordToFind));
			}
		}

		public ICommand FindWord
		{
			get
			{
				return new RelayCommand(param =>
				{
					WordsResult = new ObservableCollection<string>(Words.Where(w => w.Contains(WordToFind)).ToList());
				});
			}

		}

	}
}
