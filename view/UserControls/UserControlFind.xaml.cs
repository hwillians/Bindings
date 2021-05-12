using System.Windows.Controls;
using view.ViewModels;

namespace view.UserControls
{
	/// <summary>
	/// Logique d'interaction pour UserControlFind.xaml
	/// </summary>
	public partial class UserControlFind : UserControl
	{
		public UserControlFind()
		{
			InitializeComponent();
			DataContext = new ViewModelFind();
		}
	}
}
