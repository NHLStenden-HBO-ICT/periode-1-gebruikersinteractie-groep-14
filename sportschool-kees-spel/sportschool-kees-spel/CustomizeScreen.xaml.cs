using Microsoft.Win32;
using System;
using System.Collections;
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
        int EquippedHeadValue = 1;
        int maxHeadValue = 7; // max waarde - 1
        int minHeadValue = 2;

        int EquippedShirtValue = 1;
        int maxShirtValue = 3; // max waarde - 1
        int minShirtValue = 2;



        public CustomizeScreen()
        {
            EquippedHeadValue = Properties.Settings.Default.EquippedHead;
            EquippedShirtValue = Properties.Settings.Default.EquippedShirt;

            InitializeComponent();
            ShirtSwitch();
            HeadwearSwitch();
        }

        private void SavedFit()
        {
            ShirtSwitch();
            HeadwearSwitch();
            Properties.Settings.Default.EquippedHead = EquippedHeadValue;
            Properties.Settings.Default.EquippedShirt = EquippedShirtValue;
            Properties.Settings.Default.Save();

        } 



        private void HeadwearSwitch()
        {
            switch (EquippedHeadValue)
            {
                case 1:
                    PlayerHair.Source = new BitmapImage(new Uri("Images/Speler/Haar1.png", UriKind.Relative));
                    break;
                case 2:
                    PlayerHair.Source = new BitmapImage(new Uri("Images/Speler/Haar2.png", UriKind.Relative));
                    break;
                case 3:
                    PlayerHair.Source = new BitmapImage(new Uri("Images/Speler/Haar3.png", UriKind.Relative));
                    break;
                case 4:
                    PlayerHair.Source = new BitmapImage(new Uri("Images/Speler/Haar4.png", UriKind.Relative));
                    break;
                case 5:
                    PlayerHair.Source = new BitmapImage(new Uri("Images/Speler/Haar5.png", UriKind.Relative));
                    break;
                case 6:
                    PlayerHair.Source = new BitmapImage(new Uri("Images/Speler/Haar6.png", UriKind.Relative));
                    break;
                case 7:
                    PlayerHair.Source = new BitmapImage(new Uri("Images/Speler/Haar7.png", UriKind.Relative));
                    break;
                case 8:
                    PlayerHair.Source = new BitmapImage(new Uri("Images/Speler/Haar8.png", UriKind.Relative));
                    break;
            }
        }

        private void ShirtSwitch()
        {
            switch (EquippedShirtValue)
            {
                case 1:
                    PlayerCharacter.Source = new BitmapImage(new Uri("Images/Speler/Speler1.png", UriKind.Relative));
                    break;
                case 2:
                    PlayerCharacter.Source = new BitmapImage(new Uri("Images/Speler/Speler2.png", UriKind.Relative));
                    break;
                case 3:
                    PlayerCharacter.Source = new BitmapImage(new Uri("Images/Speler/Speler3.png", UriKind.Relative));
                    break;
                case 4:
                    PlayerCharacter.Source = new BitmapImage(new Uri("Images/Speler/Speler4.png", UriKind.Relative));
                    break;
            }
        }

        private void Hoofd_Links(object sender, RoutedEventArgs e)
        {
            if (EquippedHeadValue >= minHeadValue)
            {
                EquippedHeadValue--;
            }
            else
            {
                EquippedHeadValue = maxHeadValue + 1;
            }
            SavedFit();


        }

        private void Hoofd_Rechts(object sender, RoutedEventArgs e)
        {
            if (EquippedHeadValue <= maxHeadValue)
            {
                EquippedHeadValue++;
            }
            else
            {
                EquippedHeadValue = minHeadValue - 1;
            }
            SavedFit();
        }

        private void Shirt_Rechts(object sender, RoutedEventArgs e)
        {
            if (EquippedShirtValue <= maxShirtValue)
            {
                EquippedShirtValue++;
            }
            else
            {
                EquippedShirtValue = minShirtValue - 1;
            }
            SavedFit();
        }

        private void Shirt_Links(object sender, RoutedEventArgs e)
        {
            if (EquippedShirtValue >= minShirtValue)
            {
                EquippedShirtValue--;
            }
            else
            {
                EquippedShirtValue = maxShirtValue + 1;
            }
            SavedFit();
        }

        private void goBack(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);


        }
    }
}
