using sportschool_kees_spel.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace sportschool_kees_spel
{
    /// <summary>
    /// Interaction logic for LevelSelectiePage.xaml
    /// </summary>
    public partial class LevelSelectiePage : Page
    {
        public LevelSelectiePage()
        {
            InitializeComponent();
        }

        private void goBack(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }


        private void gotoTennis(object sender, RoutedEventArgs e)
        {
            Games.Content = new Tennis();
        }
    }
}
