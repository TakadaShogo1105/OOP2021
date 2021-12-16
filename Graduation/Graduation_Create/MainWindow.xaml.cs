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
using Microsoft.Office.Interop.Excel;

namespace Graduation_Create
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {

        int scount = 0;
        int hcount = 0;
        private NavigationService _navi;    //ナビゲーションサービス
        public MainWindow()
        {
            InitializeComponent();
            _navi = this.myFrame.NavigationService;

        }


        private void myFrame_Loaded(object sender, RoutedEventArgs e)
        {

            _navi.Navigate(_uriList[0]);    //初期ページの表示
        }

        private List<Uri> _uriList = new List<Uri>() {
            new Uri("Page1.xaml",UriKind.Relative),
            new Uri("Page2.xaml",UriKind.Relative),
            new Uri("Page3.xaml",UriKind.Relative),
            new Uri("Page4.xaml",UriKind.Relative),
            new Uri("Page5.xaml",UriKind.Relative),
            new Uri("Page6.xaml",UriKind.Relative),
            new Uri("Page7.xaml",UriKind.Relative),
            new Uri("Page8.xaml",UriKind.Relative),
            new Uri("Page9.xaml",UriKind.Relative),
            new Uri("Page10.xaml",UriKind.Relative),
            new Uri("Page11.xaml",UriKind.Relative),
            new Uri("Page12.xaml",UriKind.Relative),

        };

        private void prevButton_Click(object sender, RoutedEventArgs e)
        {

            int index = _uriList.FindIndex(p => p == _navi.CurrentSource) - 1;
            _navi.Navigate(_uriList[0]);    //ページの移動

        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            if (_navi.CanGoForward)
                _navi.GoForward();
            else
            {
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }

        }

        private void myFrame_Navigated(object sender, NavigationEventArgs e)
        {
            int index = _uriList.IndexOf(_navi.CurrentSource);
            if (index <= 0)
            {
                nextButton.IsEnabled = true;
                prevButton.IsEnabled = false;
                Seikaibt.IsEnabled = false;
                Matigai.IsEnabled = false;
            }
            else if(index == 11){
                nextButton.IsEnabled = false;
                prevButton.IsEnabled = true;
                Seikaibt.IsEnabled = false;
                Matigai.IsEnabled = false;
            }
            else
            {
                nextButton.IsEnabled = false;
                prevButton.IsEnabled = true;
                Seikaibt.IsEnabled = true;
                Matigai.IsEnabled = true;
            }

            //if (index + 1 == _uriList.Count)
            //{
            //    nextButton.IsEnabled = false;
            //}
            //else
            //{
            //    nextButton.IsEnabled = true;
            //}
        }

        private void Seikaibt_Click(object sender, RoutedEventArgs e)
        {
            scount = +1;
           
            if (_navi.CanGoForward)
                _navi.GoForward();
            else
            {
                MessageBox.Show("正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
        }

        private void Matigai_Click(object sender, RoutedEventArgs e)
        {
            hcount = +1;
            if (_navi.CanGoForward)
                _navi.GoForward();
            else
            {
                MessageBox.Show("不正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
        }
    }
}
