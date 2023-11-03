using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace sportschool_kees_spel
{
    /// <summary>
    /// Interaction logic for InstructieBasketball.xaml
    /// </summary>
    public partial class InstructieBasketball : Page
    {
        MainWindow mainWindow;
        Basketball bp = new Basketball();

        public InstructieBasketball(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);

            this.mainWindow.testFunction();
        }

        private void Terug(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }

        private void Window_KeyDown_1(object sender, KeyEventArgs e)
        {
            bp.MainWindow_KeyDown(sender, e);
        }
    }
}
