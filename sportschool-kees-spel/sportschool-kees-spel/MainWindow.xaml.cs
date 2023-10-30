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
using System.Configuration;

namespace sportschool_kees_spel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Configuration AppConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public MainWindow()
        {
            InitializeComponent();

        }

        private void BtnClickCSW(object sender, RoutedEventArgs e)
        {
            Main.Content = new CustomizeScreen();
        }

        private void BtnClickCSW2(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page2();
        }

        private void Main_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
