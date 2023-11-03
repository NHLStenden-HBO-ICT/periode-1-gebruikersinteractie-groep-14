using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using sportschool_kees_spel;

namespace sportschool_kees_spel
{
    public partial class Tennis : Page
    {
        private double ballX, ballY, ballSpeedX, ballSpeedY;
        private int player1Score, player2Score;
        private int UpdateScore;

        private bool isPlayer1MovingUp, isPlayer1MovingDown;
        private bool isPlayer2MovingUp, isPlayer2MovingDown;
        //private TextBlock scoreText;
        private Random random = new Random();

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        public Tennis()
        {
            InitializeComponent();
            InitializeGame();

            EquippedHeadValue = Properties.Settings.Default.EquippedHead;
            EquippedShirtValue = Properties.Settings.Default.EquippedShirt;

            HeadwearSwitch();
            ShirtSwitch();
        }

        private void InitializeGame()
        {
            ballX = 935;
            ballY = 515;
            ballSpeedX = 5;
            ballSpeedY = 4;

            player1Score = 0;
            player2Score = 0;

            var gameTimer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(16) };
            gameTimer.Tick += GameLoop;
            gameTimer.Start();


            KeyDown += OnKeyDown;
            KeyUp += OnKeyUp;

            //    scoreText = new TextBlock
            //    {
            //        FontSize = 24,
            //        Foreground = Brushes.Black,
            //        Width = 300,
            //        Height = 50,
            //        TextAlignment = TextAlignment.Center
            //    };
            //    Canvas.SetLeft(scoreText, 150);
            //    Canvas.SetTop(scoreText, 10);
            //    tennisCanvas.Children.Add(scoreText);
            //}
            //private void Updatescore()
            //{
            //    scoreText.Text = $"Player 1: {player1Score} - Player 2: {player2Score}";
        }


        public void OnKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.W:
                    isPlayer1MovingUp = true;
                    break;
                case Key.S:
                    isPlayer1MovingDown = true;
                    break;
                case Key.Up:
                    isPlayer2MovingUp = true;
                    break;
                case Key.Down:
                    isPlayer2MovingDown = true;
                    break;
            }
        }

        public void OnKeyUp(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.W:
                    isPlayer1MovingUp = false;
                    break;
                case Key.S:
                    isPlayer1MovingDown = false;
                    break;
                case Key.Up:
                    isPlayer2MovingUp = false;
                    break;
                case Key.Down:
                    isPlayer2MovingDown = false;
                    break;
            }
        }

        private void GameLoop(object sender, EventArgs e)
        {
            if (isPlayer1MovingUp)
            {
                Canvas.SetTop(player1, Canvas.GetTop(player1) - 10);
            }
            if (isPlayer1MovingDown)
            {
                Canvas.SetTop(player1, Canvas.GetTop(player1) + 10);
            }
            if (isPlayer2MovingUp)
            {
                Canvas.SetTop(player2, Canvas.GetTop(player2) - 10);
            }
            if (isPlayer2MovingDown)
            {
                Canvas.SetTop(player2, Canvas.GetTop(player2) + 10);
            }


            if (player1Score >= 8 || player2Score >= 8)
            {
                if (player1Score >= 8)
                {
                    ShowWinner("Player 1");

                }
                else
                {
                    ShowWinner("Player 2");
                }
                return; // Game over
            }

            ballX += ballSpeedX;
            ballY += ballSpeedY;

            if (ballX <= Canvas.GetLeft(player1) + player1.Width &&
                ballY >= Canvas.GetTop(player1) && ballY <= Canvas.GetTop(player1) + player1.Height)
            {
                ballSpeedX = Math.Abs(ballSpeedX);
            }
            else if (ballX + ball.Width >= Canvas.GetLeft(player2) &&
                     ballY >= Canvas.GetTop(player2) && ballY <= Canvas.GetTop(player2) + player2.Height)
            {
                ballSpeedX = -Math.Abs(ballSpeedX);
            }

            ballX += ballSpeedX;
            ballY += ballSpeedY;

            if (ballX <= 220 && ballY >= Canvas.GetTop(player1) && ballY <= Canvas.GetTop(player1) + player1.Height)
            {
                ballSpeedX *= 1.1;
            }
            else if (ballX >= 1700 && ballY >= Canvas.GetTop(player2) && ballY <= Canvas.GetTop(player2) + player2.Height)
            {
                ballSpeedX *= -1.1;
            }


            if (ballX < 0)
            {
                player2Score++;
                ballX = 250;
                ballY = random.Next(200, 880); ;
                ballSpeedX = 6;
                ballSpeedY = random.Next(-5, 5);
            }
            else if (ballX > 1920)
            {
                player1Score++;
                ballX = 1670;
                ballY = random.Next(200, 880);
                ballSpeedX = -6;
                ballSpeedY = random.Next(-5, 5);
            }

            if (ballY < 0 || ballY > tennisCanvas.ActualHeight - ball.Height)
            {
                ballSpeedY *= -1.05;
            }

            Canvas.SetLeft(ball, ballX);
            Canvas.SetTop(ball, ballY);







        }

        private void ShowWinner(string winner)
        {
            TextBlock winnerText = new TextBlock
            {
                FontSize = 36,
                Foreground = Brushes.Black,
                Width = 400,
                Height = 100,
                TextAlignment = TextAlignment.Center,
                Text = $"{winner} wins!"
            };
            Canvas.SetLeft(winnerText, 760);
            Canvas.SetTop(winnerText, 400);
            tennisCanvas.Children.Add(winnerText);

            restartButton.Visibility = Visibility.Visible;
            quitButton.Visibility = Visibility.Visible;
        }
        int EquippedHeadValue = 1;
        int EquippedShirtValue = 1;


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
                    PlayerShirt.Source = new BitmapImage(new Uri("Images/Speler/Speler1.png", UriKind.Relative));
                    break;
                case 2:
                    PlayerShirt.Source = new BitmapImage(new Uri("Images/Speler/Speler2.png", UriKind.Relative));
                    break;
                case 3:
                    PlayerShirt.Source = new BitmapImage(new Uri("Images/Speler/Speler3.png", UriKind.Relative));
                    break;
                case 4:
                    PlayerShirt.Source = new BitmapImage(new Uri("Images/Speler/Speler4.png", UriKind.Relative));
                    break;
            }
        }
}

}


