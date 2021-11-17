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

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        int number;

        public MainWindow() {
            InitializeComponent();
            Random random = new Random();
            number = random.Next(1,25);
        }

        
        private void Button_Click(object sender, RoutedEventArgs e) {

            var button = (Button)sender; 
            int numbers = int.Parse(((Button)sender).Content.ToString());

            if (number == numbers) {
                Answer.Text = "正解";
            }else if(number > numbers) {
                Answer.Text = "もっと大きいです";
            } else {
                Answer.Text = "もっと小さいです";
            }
            
        }

        
    }
}
