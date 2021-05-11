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

		private void MenuItem_Click(object sender, RoutedEventArgs e)
		{
			var item = (MenuItem)sender;
			var id = item.Uid;
			switch (id)
			{
				case "0": view.Content = new TestString(); break;
				case "1": view.Content = new TestListString(); break;
				case "2": view.Content = new TestMessages(); break;
				case "3": view.Content = new UserControlRandom(); break;
				case "4": view.Content = new UserControlMessageTemplate(); break;
				default: break;
			}
		}
	}
}
