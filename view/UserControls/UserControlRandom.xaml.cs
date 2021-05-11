using System.Windows.Controls;
using view.ViewModels;

namespace view.UserControls
{
    /// <summary>
    /// Logique d'interaction pour UserControlRandom.xaml
    /// </summary>
    public partial class UserControlRandom : UserControl
    {
        public UserControlRandom()
        {
            InitializeComponent();
            DataContext = new ViewModelRandom();
        }
    }
}
