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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace sportschool_kees_spel
{
    /// <summary>
    /// Interaction logic for Startscherm.xaml
    /// </summary>
    
    public partial class Startscherm : Page
    {
        public Startscherm()
        {
            InitializeComponent();
        }

        private void StartButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("LevelSelectiePage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void ExtraButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("ExtraPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void OptiesButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("OptiesPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void HelpButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("HelpPage.xaml", UriKind.RelativeOrAbsolute));
        }
        private void GegevensButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("GegevensPage.xaml", UriKind.RelativeOrAbsolute));
        }
        private void ExitButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("", UriKind.RelativeOrAbsolute));
        }
    }
}