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

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        int number;
        DispatcherTimer _timer;
        TimeSpan _time;
        //private SolidColorBrush selectedButtonColor = new SolidColorBrush(Color.Yellow);
        //private SolidColorBrush hitButtonColor = new SolidColorBrush(Color.Red);

        public MainWindow() {
            InitializeComponent();
            Random random = new Random();
            number = random.Next(1,25);

            _time = TimeSpan.FromSeconds(1);

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                tbTime.Text = _time.ToString("c");
                if (_time == TimeSpan.Zero) _timer.Stop();
                _time = _time.Add(TimeSpan.FromSeconds(1));
            }, Application.Current.Dispatcher);

            _timer.Start();
        }

        
        private void Button_Click(object sender, RoutedEventArgs e) {

            var button = (Button)sender; 
            int numbers = int.Parse(((Button)sender).Content.ToString());

            if (number == numbers) {
                Answer.Text = "正解";
                _timer.Stop();
            }
            else if(number > numbers) {
                Answer.Text = "もっと大きいです";
            } else {
                Answer.Text = "もっと小さいです";
            }
            
        }

        
    }
}
