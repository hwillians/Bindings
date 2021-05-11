using System.Windows.Controls;
using view.ViewModels;

namespace view.UserControls
{
    /// <summary>
    /// Logique d'interaction pour TestString.xaml
    /// </summary>
    public partial class TestString : UserControl
    {
        public TestString()
        {
            InitializeComponent();
            DataContext = new ViewModelString();
        }
    }
}
