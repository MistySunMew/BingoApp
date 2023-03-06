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
                        tbl1.Foreground= new SolidColorBrush(Colors.Yellow);
                        break;
                    case 2:
                        tbl2.Background = new SolidColorBrush(Colors.Red);
                        tbl2.Foreground= new SolidColorBrush(Colors.Yellow);
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
                        break;
                    case 9:
                        tbl9.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 10:
                        tbl10.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 11:
                        tbl11.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 12:
                        tbl12.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 13:
                        tbl13.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 14:
                        tbl14.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 15:
                        tbl15.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 16:
                        tbl16.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 17:
                        tbl17.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 18:
                        tbl18.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 19:
                        tbl19.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 20:
                        tbl20.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 21:
                        tbl21.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 22:
                        tbl22.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 23:
                        tbl23.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 24:
                        tbl24.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 25:
                        tbl25.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 26:
                        tbl26.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 27:
                        tbl27.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 28:
                        tbl28.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 29:
                        tbl29.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 30:
                        tbl30.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 31:
                        tbl31.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 32:
                        tbl32.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 33:
                        tbl33.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 34:
                        tbl34.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 35:
                        tbl35.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 36:
                        tbl36.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 37:
                        tbl37.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 38:
                        tbl38.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 39:
                        tbl39.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 40:
                        tbl40.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 41:
                        tbl41.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 42:
                        tbl42.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 43:
                        tbl43.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 44:
                        tbl44.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 45:
                        tbl45.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 46:
                        tbl46.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 47:
                        tbl47.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 48:
                        tbl48.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 49:
                        tbl49.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 50:
                        tbl50.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 51:
                        tbl51.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 52:
                        tbl52.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 53:
                        tbl53.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 54:
                        tbl54.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 55:
                        tbl55.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 56:
                        tbl56.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 57:
                        tbl57.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 58:
                        tbl58.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 59:
                        tbl59.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 60:
                        tbl60.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 61:
                        tbl61.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 62:
                        tbl62.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 63:
                        tbl63.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 64:
                        tbl64.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 65:
                        tbl65.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 66:
                        tbl66.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 67:
                        tbl67.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 68:
                        tbl68.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 69:
                        tbl69.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 70:
                        tbl70.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 71:
                        tbl71.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 72:
                        tbl72.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 73:
                        tbl73.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 74:
                        tbl74.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 75:
                        tbl75.Background = new SolidColorBrush(Colors.Red);
                        break;
                    default:
                        break;
                }

                CalledNumbersCount++;
                   
                tblNumCalls.Text = "Number of Calls: " + CalledNumbersCount.ToString();

                TimeLeft = CallTime + 1;
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
            timer.Interval = new TimeSpan(0, 0, 0, 1);
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
    }
}
