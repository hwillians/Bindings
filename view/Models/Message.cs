using System;
using System.ComponentModel;

namespace view.Models
{
	public class Message : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged(string name)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		public string Emetteur { get; set; }
		private string contenu;

		public string Contenu
		{
			get { return contenu; }
			set
			{
				contenu = value;
				OnPropertyChanged(nameof(Contenu));
			}
		}

		public DateTime Date { get; set; }


		public override string ToString()
		{
			return $"{Emetteur} : {Contenu} \n {Date}";
		}
	}
}
