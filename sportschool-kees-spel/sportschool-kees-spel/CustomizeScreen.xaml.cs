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
        int EquippedValue = 1;
        int maxValue = 4;
        int minValue = 2;
        string EquippedValueString = string.Empty;
        public CustomizeScreen()
        {
            InitializeComponent();
        }

        private void HeadwearSwitch()
        {
            InitializeComponent();
            switch (EquippedValue)
            {
                case 1:
                    SelectedHead.Source = new BitmapImage(new Uri("Images/Icons/1.png", UriKind.Relative));
                    break;
                case 2:
                    SelectedHead.Source = new BitmapImage(new Uri("Images/Icons/2.png", UriKind.Relative));
                    break;
                case 3:
                    SelectedHead.Source = new BitmapImage(new Uri("Images/Icons/3.png", UriKind.Relative));
                    break;
                case 4:
                    SelectedHead.Source = new BitmapImage(new Uri("Images/Icons/4.png", UriKind.Relative));
                    break;
                case 5:
                    SelectedHead.Source = new BitmapImage(new Uri("Images/Icons/5.png", UriKind.Relative));
                    break;
            }
        }

        private void Hoofd_Links(object sender, RoutedEventArgs e)
        {
            if (EquippedValue >= minValue)
            {
                EquippedValue--;
            }
            else
            {
                EquippedValue = maxValue + 1;
            }
            EquippedValueString = EquippedValue.ToString();
            NumberTest.Text = EquippedValueString;
            HeadwearSwitch();

        }

        private void Hoofd_Rechts(object sender, RoutedEventArgs e)
        {
            if (EquippedValue <= maxValue)
            {
                EquippedValue++;
            }
            else
            {
                EquippedValue = minValue - 1;
            }
            EquippedValueString = EquippedValue.ToString();
            NumberTest.Text = EquippedValueString;
            HeadwearSwitch();
        }
    }
}
