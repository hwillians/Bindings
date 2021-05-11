using System.Windows.Controls;
using view.ViewModels;

namespace view.UserControls
{
    /// <summary>
    /// Logique d'interaction pour UserControlMessageTemplate.xaml
    /// </summary>
    public partial class UserControlMessageTemplate : UserControl
    {
        public UserControlMessageTemplate()
        {
            InitializeComponent();
            DataContext = new ViewModelMessage();
        }
    }
}
