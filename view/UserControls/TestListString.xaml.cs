using System.Windows.Controls;
using view.ViewModels;

namespace view.UserControls
{
    /// <summary>
    /// Logique d'interaction pour TestListString.xaml
    /// </summary>
    public partial class TestListString : UserControl
    {
        public TestListString()
        {
            InitializeComponent();
            DataContext = new ViewModelListString();
        }
    }
}
