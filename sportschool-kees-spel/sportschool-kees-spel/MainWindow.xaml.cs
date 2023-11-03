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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Tennis tp = new Tennis();
        public MainWindow()
        {
            InitializeComponent();
            Games.Content = tp;
        }

        private void Main_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void Afsluiten(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void beginGame(object sender, RoutedEventArgs e)
        {
            Games.Content = new LevelSelectiePage();
        }

        private void gotoCustom(object sender, RoutedEventArgs e)
        {
            Main.Content = new CustomizeScreen();
        }

        private void gotoInfo(object sender, RoutedEventArgs e)
        {

        }

        private void gotoLeaderbord(object sender, RoutedEventArgs e)
        {

        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            tp.OnKeyDown(sender, e);
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            tp.OnKeyUp(sender, e);
        }
    }
    
}


