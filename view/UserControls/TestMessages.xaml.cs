using System.Windows.Controls;
using view.ViewModels;

namespace view.UserControls
{
    /// <summary>
    /// Logique d'interaction pour TestMessages.xaml
    /// </summary>
    public partial class TestMessages : UserControl
    {
        public TestMessages()
        {
            InitializeComponent();
            DataContext = new ViewModelMessage();
        }
    }
}
