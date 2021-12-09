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

namespace NavigationServiceSample
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private NavigationService _navi;    //ナビゲーションサービス
        public MainWindow()
        {
            InitializeComponent();
            _navi = this.myFrame.NavigationService;
        }

        private List<Uri> _uriList = new List<Uri>() {
            new Uri("Page1.xaml",UriKind.Relative),
            new Uri("Page2.xaml",UriKind.Relative),
            new Uri("Page3.xaml",UriKind.Relative),
        };

        private void myFrame_Loaded(object sender, RoutedEventArgs e)
        {
            _navi.Navigate(_uriList[0]);    //初期ページの表示
        }

        private void prevButton_Click(object sender, RoutedEventArgs e)
        {

            int index = _uriList.FindIndex(p => p == _navi.CurrentSource) - 1;
            _navi.Navigate(_uriList[0]);    //ページの移動

        }

        private void btManga_Click(object sender, RoutedEventArgs e)
        {
            if (_navi.CanGoForward)
                _navi.GoForward();
            else
            {
                //int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[1]);    //ページの移動
            }
        }

        private void myFrame_Navigated(object sender, NavigationEventArgs e)
        {
            int index = _uriList.IndexOf(_navi.CurrentSource);
            if (index <= 0)
                prevButton.IsEnabled = false;
            else
                prevButton.IsEnabled = true;
            if (index + 1 == _uriList.Count)
                btManga.IsEnabled = false;
            else
                btManga.IsEnabled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}