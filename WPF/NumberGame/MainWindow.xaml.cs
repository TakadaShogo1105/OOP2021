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
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {


           
            
            if ((int)num.Text == 1) {

                Answer.Text = "正解";

            } else if ((int)Answer. == 2) {
                Answer.Text = "もっと小さいです";
            } else if ((int)num.Content == 0) {
                Answer.Text = "もっと大きいです";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {

        }
    }
}
