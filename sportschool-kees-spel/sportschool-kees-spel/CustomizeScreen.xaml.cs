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

namespace sportschool_kees_spel
{
    /// <summary>
    /// Interaction logic for CustomizeScreen.xaml
    /// </summary>
    public partial class CustomizeScreen : Page
    {
        public CustomizeScreen()
        {
            InitializeComponent();

            int selectedOption = 0;

            switch (selectedOption)
            {
                case 0:
                    Console.WriteLine("Succes!");
                    break;
            }
        }

        private void Hoofd_Links(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Links");
        }

        private void Hoofd_Rechts(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Rechts");
        }
    }
}
