using System.Windows.Controls;
using view.ViewModels;

namespace view.UserControls
{
	/// <summary>
	/// Logique d'interaction pour UserControlImages.xaml
	/// </summary>
	public partial class UserControlImages : UserControl
	{
		public UserControlImages()
		{
			InitializeComponent();
			DataContext = new ViewModelImages();
		}
	}
}
