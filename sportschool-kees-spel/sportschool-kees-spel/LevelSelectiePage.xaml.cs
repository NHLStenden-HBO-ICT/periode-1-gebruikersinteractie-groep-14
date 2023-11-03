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
using Windows.Gaming.Preview;

namespace sportschool_kees_spel
{
    /// <summary>
    /// Interaction logic for LevelSelectiePage.xaml
    /// </summary>
    public partial class LevelSelectiePage : Page
    {
        MainWindow mainWindow;

        public LevelSelectiePage(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();

        }

        private void goBack(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }

        private void gotoBasketball(object sender, RoutedEventArgs e)
        {
            Games.Content = new InstructieBasketball(mainWindow);
        }

        private void Window_KeyDown_1(object sender, KeyEventArgs e)
        {
            //bp.MainWindow_KeyDown(sender, e);
        }

        private void gotoTennis(object sender, RoutedEventArgs e)
        {
            Games.Content = new InstructieTennis(mainWindow);
        }

        private void Games_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
