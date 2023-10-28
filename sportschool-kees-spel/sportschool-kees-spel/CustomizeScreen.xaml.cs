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
        int maxValue = 9;
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
                    MessageBox.Show("1");
                    break;
                case 2:
                    MessageBox.Show("2");
                    break;
                case 3:
                    MessageBox.Show("3");
                    break;
                case 4:
                    MessageBox.Show("4");
                    break;
                case 5:
                    MessageBox.Show("5");
                    break;
                case 6:
                    MessageBox.Show("6");
                    break;
                case 7:
                    MessageBox.Show("7");
                    break;
                case 8:
                    MessageBox.Show("8");
                    break;
                case 9:
                    MessageBox.Show("9");
                    break;
                case 10:
                    MessageBox.Show("10");
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
