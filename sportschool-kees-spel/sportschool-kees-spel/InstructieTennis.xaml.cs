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
    /// Interaction logic for InstructieTennis.xaml
    /// </summary>
    public partial class InstructieTennis : Page
    {
        MainWindow mainWindow;
        Tennis tp = new Tennis();

        public InstructieTennis(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);

            this.mainWindow.gotoTennis();
        }

        private void Terug(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
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
