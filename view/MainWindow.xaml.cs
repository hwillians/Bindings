using System.Windows;
using System.Windows.Controls;
using view.UserControls;
using view.ViewModels;

namespace view
{
	/// <summary>
	/// Logique d'interaction pour MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		void GetContent(UserControl userControl)
		{
			view.Content = userControl;
		}

		private void MenuItem_Click(object sender, RoutedEventArgs e)
		{
			var item = (MenuItem)sender;
			var id = item.Uid;
			switch (id)
			{
				case "0": GetContent(new TestString()); break;
				case "1": GetContent(new TestListString()); break;
				case "2": GetContent(new TestMessages()); break;
				case "3": GetContent(new UserControlRandom()); break;
				case "4": GetContent(new UserControlMessageTemplate()); break;
				default: break;
			}
		}
	}
}
