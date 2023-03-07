using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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

namespace BingoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GameNumber = 1;
        }

        public MainWindow(int gameNumber)
        {
            GameNumber = gameNumber;
            InitializeComponent();
        }

        private int GameNumber;
        private int CurrentNumber = 0;
        private ArrayList CalledNumbers = new();
        private int CalledNumbersCount = 0;
        private int CallTime;
        private int TimeLeft = 0;
        private DispatcherTimer timer = new();

        private void ChangeSelectedColor(object sender, RoutedEventArgs e) 
        {
            System.Windows.Shapes.Rectangle rectangle = (System.Windows.Shapes.Rectangle)sender;
            if (rectangle.Fill == Brushes.White) 
            {
                rectangle.Fill = Brushes.Red;
            }
            else
            {
                rectangle.Fill = Brushes.White;
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (CalledNumbersCount < 75)
            {
                Random rnd = new Random();
                CurrentNumber = rnd.Next(1, 76);

                if (CalledNumbers.Contains(CurrentNumber))
                {
                    Button_Click(sender, e);
                }
                else
                {
                    CalledNumbers.Add(CurrentNumber);

                    tblCurrCall.Text = CurrentNumber.ToString();

                    switch (CurrentNumber)
                    {
                        case 1:
                            tbl1.Background = new SolidColorBrush(Colors.Red);
                            tbl1.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 2:
                            tbl2.Background = new SolidColorBrush(Colors.Red);
                            tbl2.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 3:
                            tbl3.Background = new SolidColorBrush(Colors.Red);
                            tbl3.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 4:
                            tbl4.Background = new SolidColorBrush(Colors.Red);
                            tbl4.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 5:
                            tbl5.Background = new SolidColorBrush(Colors.Red);
                            tbl5.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 6:
                            tbl6.Background = new SolidColorBrush(Colors.Red);
                            tbl6.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 7:
                            tbl7.Background = new SolidColorBrush(Colors.Red);
                            tbl7.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 8:
                            tbl8.Background = new SolidColorBrush(Colors.Red);
                            tbl8.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 9:
                            tbl9.Background = new SolidColorBrush(Colors.Red);
                            tbl9.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 10:
                            tbl10.Background = new SolidColorBrush(Colors.Red);
                            tbl10.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 11:
                            tbl11.Background = new SolidColorBrush(Colors.Red);
                            tbl11.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 12:
                            tbl12.Background = new SolidColorBrush(Colors.Red);
                            tbl12.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 13:
                            tbl13.Background = new SolidColorBrush(Colors.Red);
                            tbl13.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 14:
                            tbl14.Background = new SolidColorBrush(Colors.Red);
                            tbl14.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 15:
                            tbl15.Background = new SolidColorBrush(Colors.Red);
                            tbl15.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 16:
                            tbl16.Background = new SolidColorBrush(Colors.Red);
                            tbl16.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 17:
                            tbl17.Background = new SolidColorBrush(Colors.Red);
                            tbl17.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 18:
                            tbl18.Background = new SolidColorBrush(Colors.Red);
                            tbl18.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 19:
                            tbl19.Background = new SolidColorBrush(Colors.Red);
                            tbl19.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 20:
                            tbl20.Background = new SolidColorBrush(Colors.Red);
                            tbl20.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 21:
                            tbl21.Background = new SolidColorBrush(Colors.Red);
                            tbl21.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 22:
                            tbl22.Background = new SolidColorBrush(Colors.Red);
                            tbl22.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 23:
                            tbl23.Background = new SolidColorBrush(Colors.Red);
                            tbl23.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 24:
                            tbl24.Background = new SolidColorBrush(Colors.Red);
                            tbl24.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 25:
                            tbl25.Background = new SolidColorBrush(Colors.Red);
                            tbl25.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 26:
                            tbl26.Background = new SolidColorBrush(Colors.Red);
                            tbl26.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 27:
                            tbl27.Background = new SolidColorBrush(Colors.Red);
                            tbl27.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 28:
                            tbl28.Background = new SolidColorBrush(Colors.Red);
                            tbl28.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 29:
                            tbl29.Background = new SolidColorBrush(Colors.Red);
                            tbl29.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 30:
                            tbl30.Background = new SolidColorBrush(Colors.Red);
                            tbl30.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 31:
                            tbl31.Background = new SolidColorBrush(Colors.Red);
                            tbl31.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 32:
                            tbl32.Background = new SolidColorBrush(Colors.Red);
                            tbl32.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 33:
                            tbl33.Background = new SolidColorBrush(Colors.Red);
                            tbl33.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 34:
                            tbl34.Background = new SolidColorBrush(Colors.Red);
                            tbl34.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 35:
                            tbl35.Background = new SolidColorBrush(Colors.Red);
                            tbl35.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 36:
                            tbl36.Background = new SolidColorBrush(Colors.Red);
                            tbl36.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 37:
                            tbl37.Background = new SolidColorBrush(Colors.Red);
                            tbl37.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 38:
                            tbl38.Background = new SolidColorBrush(Colors.Red);
                            tbl38.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 39:
                            tbl39.Background = new SolidColorBrush(Colors.Red);
                            tbl39.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 40:
                            tbl40.Background = new SolidColorBrush(Colors.Red);
                            tbl40.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 41:
                            tbl41.Background = new SolidColorBrush(Colors.Red);
                            tbl41.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 42:
                            tbl42.Background = new SolidColorBrush(Colors.Red);
                            tbl42.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 43:
                            tbl43.Background = new SolidColorBrush(Colors.Red);
                            tbl43.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 44:
                            tbl44.Background = new SolidColorBrush(Colors.Red);
                            tbl44.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 45:
                            tbl45.Background = new SolidColorBrush(Colors.Red);
                            tbl45.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 46:
                            tbl46.Background = new SolidColorBrush(Colors.Red);
                            tbl46.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 47:
                            tbl47.Background = new SolidColorBrush(Colors.Red);
                            tbl47.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 48:
                            tbl48.Background = new SolidColorBrush(Colors.Red);
                            tbl48.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 49:
                            tbl49.Background = new SolidColorBrush(Colors.Red);
                            tbl49.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 50:
                            tbl50.Background = new SolidColorBrush(Colors.Red);
                            tbl50.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 51:
                            tbl51.Background = new SolidColorBrush(Colors.Red);
                            tbl51.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 52:
                            tbl52.Background = new SolidColorBrush(Colors.Red);
                            tbl52.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 53:
                            tbl53.Background = new SolidColorBrush(Colors.Red);
                            tbl53.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 54:
                            tbl54.Background = new SolidColorBrush(Colors.Red);
                            tbl54.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 55:
                            tbl55.Background = new SolidColorBrush(Colors.Red);
                            tbl55.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 56:
                            tbl56.Background = new SolidColorBrush(Colors.Red);
                            tbl56.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 57:
                            tbl57.Background = new SolidColorBrush(Colors.Red);
                            tbl57.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 58:
                            tbl58.Background = new SolidColorBrush(Colors.Red);
                            tbl58.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 59:
                            tbl59.Background = new SolidColorBrush(Colors.Red);
                            tbl59.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 60:
                            tbl60.Background = new SolidColorBrush(Colors.Red);
                            tbl60.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 61:
                            tbl61.Background = new SolidColorBrush(Colors.Red);
                            tbl61.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 62:
                            tbl62.Background = new SolidColorBrush(Colors.Red);
                            tbl62.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 63:
                            tbl63.Background = new SolidColorBrush(Colors.Red);
                            tbl63.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 64:
                            tbl64.Background = new SolidColorBrush(Colors.Red);
                            tbl64.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 65:
                            tbl65.Background = new SolidColorBrush(Colors.Red);
                            tbl65.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 66:
                            tbl66.Background = new SolidColorBrush(Colors.Red);
                            tbl66.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 67:
                            tbl67.Background = new SolidColorBrush(Colors.Red);
                            tbl67.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 68:
                            tbl68.Background = new SolidColorBrush(Colors.Red);
                            tbl68.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 69:
                            tbl69.Background = new SolidColorBrush(Colors.Red);
                            tbl69.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 70:
                            tbl70.Background = new SolidColorBrush(Colors.Red);
                            tbl70.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 71:
                            tbl71.Background = new SolidColorBrush(Colors.Red);
                            tbl71.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 72:
                            tbl72.Background = new SolidColorBrush(Colors.Red);
                            tbl72.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 73:
                            tbl73.Background = new SolidColorBrush(Colors.Red);
                            tbl73.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 74:
                            tbl74.Background = new SolidColorBrush(Colors.Red);
                            tbl74.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 75:
                            tbl75.Background = new SolidColorBrush(Colors.Red);
                            tbl75.Foreground = new SolidColorBrush(Colors.Yellow);
                            break;
                        default:
                            break;
                    }

                    CalledNumbersCount++;

                    tblNumCalls.Text = "Number of Calls: " + CalledNumbersCount.ToString();

                    TimeLeft = CallTime + 1;
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void cbxTimeValues_Loaded(object sender, RoutedEventArgs e)
        {
            cbxTimeValues.Items.Add(5);
            cbxTimeValues.Items.Add(10);
            cbxTimeValues.Items.Add(15);
            cbxTimeValues.Items.Add(20);
            cbxTimeValues.Items.Add(25);
            cbxTimeValues.Items.Add(30);
        }

        private void cbxTimeValues_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CallTime = Convert.ToInt32(cbxTimeValues.SelectedItem);
            TimeLeft = CallTime;
            tblTimer.Text = TimeLeft.ToString();
            timer.Start();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer.Interval = new TimeSpan(0, 0, 0, 0, 950);
            timer.Tick += timer_Tick;
            tblGameNumber.Text = "Game Number " + GameNumber.ToString();
        }

        private void timer_Tick(object? sender, EventArgs e)
        {
            if (TimeLeft > 0)
            {
                TimeLeft--;
                tblTimer.Text = TimeLeft.ToString();
            }
        }

        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
            Window win = new MainWindow(GameNumber + 1);
            win.Show();
            Close();
        }

        private void ChangeSelectedColor(object sender, TouchEventArgs e)
        {
            System.Windows.Shapes.Rectangle rectangle = (System.Windows.Shapes.Rectangle)sender;
            if (rectangle.Fill == Brushes.White)
            {
                rectangle.Fill = Brushes.Red;
            }
            else
            {
                rectangle.Fill = Brushes.White;
            }
        }
    }
}
