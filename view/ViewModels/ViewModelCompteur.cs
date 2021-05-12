using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using view.Models;

namespace view.ViewModels
{
	class ViewModelCompteur : ViewModelBase
	{
		private int compteur = 0;

		public int Compteur
		{
			get { return compteur; }
			set
			{
				compteur = value;
				OnPropertyChanged(nameof(Compteur));
			}
		}

		public ICommand CompteurComande
		{
			get
			{
				return new RelayCommand(param =>
				{
					if (param.Equals("+")) Compteur++;
					else if (param.Equals("-")) Compteur--;
					else Compteur = 0;
				});
			}
		}
	}
}
