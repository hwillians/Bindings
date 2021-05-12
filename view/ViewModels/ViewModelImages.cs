using System.Collections.ObjectModel;

namespace view.ViewModels
{
	class ViewModelImages : ViewModelBase
	{
		public ObservableCollection<string> Images { get; set; } = new ObservableCollection<string>
		{
			"/images/img1.jpg",
			"/images/img2.jpg",
			"/images/img3.jpg",
			"/images/img4.jpg",
			"/images/img5.jpg"
		};
	}
}
