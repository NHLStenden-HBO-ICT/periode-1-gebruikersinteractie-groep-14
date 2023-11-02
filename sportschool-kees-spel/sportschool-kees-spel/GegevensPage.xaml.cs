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
using Microsoft.UI.Xaml;

namespace sportschool_kees_spel
{
    /// <summary>
    /// Interaction logic for GegevensPage.xaml
    /// </summary>
    public partial class GegevensPage : Page
    {
        public GegevensPage()
        {
            InitializeComponent();        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void beginGame(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }
    }
}
