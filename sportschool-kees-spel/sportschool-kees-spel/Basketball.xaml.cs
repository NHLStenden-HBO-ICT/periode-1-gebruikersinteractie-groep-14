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
using System.Windows.Threading;

namespace sportschool_kees_spel
{
    /// <summary>
    /// Interaction logic for Basketball.xaml
    /// </summary>
    public partial class Basketball : Page
 
    {
        private bool isPlayer1Dragging = false;
        private bool isPlayer2Dragging = false;
        private double player1InitialLeft, player1InitialTop;
        private double player2InitialLeft, player2InitialTop;
        private double gravity = 1;
        private double velocityY1 = 0;
        private double velocityY2 = 0;
        private double floorLevel = 750;
        private double throwSpeed = 50; // Adjust the throw speed as needed
        private DispatcherTimer gameTimer = new DispatcherTimer();
        private TextBlock player1ScoreTextBlock;
        private TextBlock player2ScoreTextBlock;
        private int player1Score = 0;
        private int player2Score = 0;
        private TextBlock timerTextBlock;
        private int gameTime = 1800; // 60 seconden
        private bool isPlayer1Aiming = false;
        private bool isPlayer2Aiming = false;
        private double aimingDirection1 = 0; // Richting voor speler 1 (in radialen)
        private double aimingDirection2 = 0; // Richting voor speler 2 (in radialen)
        private double player1StartLeft;
        private double player1StartTop;
        private double player2StartLeft;
        private double player2StartTop;



        public Basketball()
        {
            InitializeComponent();
            InitializeGame();
            InitializeScoreDisplay();
        }

        private void InitializeGame()
        {
            // Voeg een TextBlock toe om de timer weer te geven
            timerTextBlock = new TextBlock
            {
                Text = "Time: " + gameTime,
                Foreground = Brushes.White,
                FontSize = 24,
                FontWeight = FontWeights.Bold,
                TextAlignment = TextAlignment.Center
            };

            Canvas.SetTop(timerTextBlock, 10);
            Canvas.SetLeft(timerTextBlock, 900);
            canvas.Children.Add(timerTextBlock);

            basketballPlayer1 = FindName("basketballPlayer1") as Ellipse;
            basketballPlayer2 = FindName("basketballPlayer2") as Ellipse;

            KeyDown += MainWindow_KeyDown;
            KeyUp += MainWindow_KeyUp;

            gameTimer = new DispatcherTimer();
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();

            player1StartLeft = Canvas.GetLeft(basketballPlayer1);
            player1StartTop = Canvas.GetTop(basketballPlayer1);
            player2StartLeft = Canvas.GetLeft(basketballPlayer2);
            player2StartTop = Canvas.GetTop(basketballPlayer2);

        }

        private void InitializeScoreDisplay()
        {
            player1ScoreTextBlock = new TextBlock
            {
                Text = "Player 1: " + player1Score,
                Foreground = Brushes.Orange,
                FontSize = 24,
                FontWeight = FontWeights.Bold,
                TextAlignment = TextAlignment.Left
            };
            player2ScoreTextBlock = new TextBlock
            {
                Text = "Player 2: " + player2Score,
                Foreground = Brushes.Red,
                FontSize = 24,
                FontWeight = FontWeights.Bold,
                TextAlignment = TextAlignment.Right
            };

            Canvas.SetTop(player1ScoreTextBlock, 10);
            Canvas.SetLeft(player1ScoreTextBlock, 10);
            Canvas.SetTop(player2ScoreTextBlock, 10);
            Canvas.SetRight(player2ScoreTextBlock, 10);
            canvas.Children.Add(player1ScoreTextBlock);
            canvas.Children.Add(player2ScoreTextBlock);
        }

        private void UpdatePlayerScores()
        {
            player1ScoreTextBlock.Text = "Player 1: " + player1Score.ToString();
            player2ScoreTextBlock.Text = "Player 2: " + player2Score.ToString();
        }

        public void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.W)
            {
                // Speler 1 richt naar links (in radialen)
                aimingDirection1 = Math.PI - (Math.PI / 4);
                isPlayer1Aiming = true;
            }

            if (e.Key == Key.Up)
            {
                // Speler 2 richt naar rechts (in radialen)
                aimingDirection2 = Math.PI / 4;
                isPlayer2Aiming = true;
            }
        }


        private void MainWindow_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            {
                gameTime--;
                timerTextBlock.Text = "Time: " + gameTime / 30;

                if (gameTime == 0)
                {
                    gameTimer.Stop(); // Stop de timer als de tijd om is

                    // Toon het resultaat op basis van de scores
                    string result;
                    if (player1Score > player2Score)
                    {
                        result = "Player 1 wint!";
                    }
                    else if (player2Score > player1Score)
                    {
                        result = "Player 2 wint!";
                    }
                    else
                    {
                        result = "Gelijkspel!";
                    }

                    MessageBox.Show(result, "Spelresultaat", MessageBoxButton.OK);
                }
            }
            if (isPlayer1Dragging)
            {
                // Update the position of the ball for player 1 using keys (WASD)
                // You can implement logic to control the movement here
            }
            else if (isPlayer2Dragging)
            {
                // Update the position of the ball for player 2 using arrow keys
                // You can implement logic to control the movement here
            }
            else
            {
                // Apply gravity to both balls
                velocityY1 += gravity;
                velocityY2 += gravity;

                double top1 = Canvas.GetTop(basketballPlayer1) + velocityY1;
                Canvas.SetTop(basketballPlayer1, top1);

                double top2 = Canvas.GetTop(basketballPlayer2) + velocityY2;
                Canvas.SetTop(basketballPlayer2, top2);

                // Check if the basketballs hit the floor
                if (top1 >= floorLevel)
                {
                    Canvas.SetTop(basketballPlayer1, floorLevel);
                    velocityY1 = 0; // Zet de verticale snelheid op 0, zodat de bal niet meer stuitert

                    // Reset de positie van de bal naar de startpositie
                    Canvas.SetLeft(basketballPlayer1, player1StartLeft);
                    Canvas.SetTop(basketballPlayer1, player1StartTop);
                }

                if (top2 >= floorLevel)
                {
                    Canvas.SetTop(basketballPlayer2, floorLevel);
                    velocityY2 = 0; // Zet de verticale snelheid op 0, zodat de bal niet meer stuitert

                    // Reset de positie van de bal naar de startpositie
                    Canvas.SetLeft(basketballPlayer2, player2StartLeft);
                    Canvas.SetTop(basketballPlayer2, player2StartTop);
                }

                // Check if a basketball has entered the net for player 1
                if (top1 <= 520 && top1 >= 500 && Canvas.GetLeft(basketballPlayer1) >= 175 && Canvas.GetLeft(basketballPlayer1) <= 275)
                {
                    // Player 1 scores a point
                    player1Score += 2;
                    UpdatePlayerScores();
                }

                // Check if a basketball has entered the net for player 2
                if (top2 <= 520 && top2 >= 500 && Canvas.GetLeft(basketballPlayer2) >= 1640 && Canvas.GetLeft(basketballPlayer2) <= 1740)
                {
                    // Player 2 scores a point
                    player2Score += 2;
                    UpdatePlayerScores();
                }

                if (isPlayer1Aiming)
                {
                    // Schietlogica voor speler 1
                    double speed = throwSpeed;
                    double dx = Math.Cos(aimingDirection1) * speed;
                    double dy = Math.Sin(aimingDirection1) * speed;

                    // Pas de positie van de bal van speler 1 aan
                    double currentLeft1 = Canvas.GetLeft(basketballPlayer1);
                    double currentTop1 = Canvas.GetTop(basketballPlayer1);
                    Canvas.SetLeft(basketballPlayer1, currentLeft1 + dx);
                    Canvas.SetTop(basketballPlayer1, currentTop1 - dy);

                    isPlayer1Aiming = false;
                }

                if (isPlayer2Aiming)
                {
                    // Schietlogica voor speler 2
                    double speed = throwSpeed;
                    double dx = Math.Cos(aimingDirection2) * speed;
                    double dy = Math.Sin(aimingDirection2) * speed;

                    // Pas de positie van de bal van speler 2 aan
                    double currentLeft2 = Canvas.GetLeft(basketballPlayer2);
                    double currentTop2 = Canvas.GetTop(basketballPlayer2);
                    Canvas.SetLeft(basketballPlayer2, currentLeft2 + dx);
                    Canvas.SetTop(basketballPlayer2, currentTop2 - dy);

                    isPlayer2Aiming = false;
                }
            }
        }
        private void RestartButton_Click(object sender, RoutedEventArgs e)
        {
            // Voeg hier code toe om het spel te herstarten
            // Dit kan het resetten van scores, timers en andere game-gerelateerde variabelen omvatten.
            // Bijvoorbeeld:
            player1Score = 0;
            player2Score = 0;
            UpdatePlayerScores();
            gameTime = 1800;
            timerTextBlock.Text = "Time: " + gameTime / 30;
            gameTimer.Start(); // Start de timer opnieuw als je die hebt gestopt
                               // Voer andere herstartlogica uit zoals het positioneren van de spelers op hun oorspronkelijke locaties, etc.
            Canvas.SetLeft(basketballPlayer1, player1StartLeft);
            Canvas.SetTop(basketballPlayer1, player1StartTop);
            Canvas.SetLeft(basketballPlayer2, player2StartLeft);
            Canvas.SetTop(basketballPlayer2, player2StartTop);
        }
    }
}

