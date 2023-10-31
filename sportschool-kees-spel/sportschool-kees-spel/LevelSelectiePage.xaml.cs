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
using System.Windows.Threading;

namespace sportschool_kees_spel
{
    /// <summary>
    /// Interaction logic for LevelSelectiePage.xaml
    /// </summary>
    public partial class LevelSelectiePage : Page
    {

        ImageBrush spelerHaarBrush = new ImageBrush();
        ImageBrush spelerShirtBrush = new ImageBrush();

        public LevelSelectiePage(int spelerHaar, int spelerShirt)
        {
            InitializeComponent();

            switch (spelerHaar)
            {
                case 1:
                    spelerShirtBrush.ImageSource = new BitmapImage(new Uri("Images/Speler/Haar1.png", UriKind.Relative));
                    break;
                case 2:
                    spelerShirtBrush.ImageSource = new BitmapImage(new Uri("Images/Speler/Haar2.png", UriKind.Relative));
                    break;
                case 3:
                    spelerShirtBrush.ImageSource = new BitmapImage(new Uri("Images/Speler/Haar3.png", UriKind.Relative));
                    break;
                case 4:
                    spelerShirtBrush.ImageSource = new BitmapImage(new Uri("Images/Speler/Haar4.png", UriKind.Relative));
                    break;
                case 5:
                    spelerShirtBrush.ImageSource = new BitmapImage(new Uri("Images/Speler/Haar5.png", UriKind.Relative));
                    break;
                case 6:
                    spelerShirtBrush.ImageSource = new BitmapImage(new Uri("Images/Speler/Haar6.png", UriKind.Relative));
                    break;
                case 7:
                    spelerShirtBrush.ImageSource = new BitmapImage(new Uri("Images/Speler/Haar7.png", UriKind.Relative));
                    break;
                case 8:
                    spelerShirtBrush.ImageSource = new BitmapImage(new Uri("Images/Speler/Haar8.png", UriKind.Relative));
                    break;
            }

            switch (spelerShirt)
            {
                case 1:
                    spelerHaarBrush.ImageSource = new BitmapImage(new Uri("Images/Speler/Speler1.png", UriKind.Relative));
                    break;
                case 2:
                    spelerHaarBrush.ImageSource = new BitmapImage(new Uri("Images/Speler/Speler2.png", UriKind.Relative));
                    break;
                case 3:
                    spelerHaarBrush.ImageSource = new BitmapImage(new Uri("Images/Speler/Speler3.png", UriKind.Relative));
                    break;
                case 4:
                    spelerHaarBrush.ImageSource = new BitmapImage(new Uri("Images/Speler/Speler4.png", UriKind.Relative));
                    break;
            }
        }
    }
}
