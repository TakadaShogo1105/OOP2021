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
using Microsoft.Office.Interop.Excel;

namespace Graduation_Create
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {

        private NavigationService _navi;    //ナビゲーションサービス
        DispatcherTimer _timer;
        TimeSpan _time;
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
            new Uri("Page13.xaml",UriKind.Relative),
            new Uri("Page14.xaml",UriKind.Relative),
            new Uri("Page15.xaml",UriKind.Relative),
            new Uri("Page16.xaml",UriKind.Relative),
            new Uri("Page17.xaml",UriKind.Relative),
            new Uri("Page18.xaml",UriKind.Relative),
            new Uri("Page19.xaml",UriKind.Relative),
            new Uri("Page20.xaml",UriKind.Relative),
            new Uri("Page21.xaml",UriKind.Relative),
            new Uri("Page22.xaml",UriKind.Relative),

        };

        private void prevButton_Click(object sender, RoutedEventArgs e)
        {

            int index = _uriList.FindIndex(p => p == _navi.CurrentSource) - 1;
            _navi.Navigate(_uriList[0]);    //ページの移動
            _timer.Stop();
            tbTime.Text = "00:00:00";

        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            _time = TimeSpan.FromSeconds(1);

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                tbTime.Text = _time.ToString("c");
                if (_time == TimeSpan.Zero) _timer.Stop();
                _time = _time.Add(TimeSpan.FromSeconds(1));
            }, System.Windows.Application.Current.Dispatcher);

            _timer.Start();
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
            else if(index == 21){
                nextButton.IsEnabled = false;
                prevButton.IsEnabled = true;
                Seikaibt.IsEnabled = false;
                Matigai.IsEnabled = false;
                _timer.Stop();
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

            int indexs = _uriList.IndexOf(_navi.CurrentSource);
            if (indexs == 1)
            {
                MessageBox.Show("正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
              
            }
            else if (indexs == 2)
            {
               
                MessageBox.Show("不正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
              
            }
            else if (indexs == 3)
            {
                MessageBox.Show("正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs ==4)
            {
                MessageBox.Show("正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 5)
            {
                MessageBox.Show("不正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs ==6)
            {
                MessageBox.Show("不正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 7)
            {
                MessageBox.Show("正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 8)
            {
                MessageBox.Show("正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 9)
            {
                MessageBox.Show("正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 10)
            {
                MessageBox.Show("不正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 11)
            {
                MessageBox.Show("正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 12)
            {
                MessageBox.Show("不正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 13)
            {
                MessageBox.Show("正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 14)
            {
                MessageBox.Show("不正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 15)
            {
                MessageBox.Show("正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 16)
            {
                MessageBox.Show("正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 17)
            {
                MessageBox.Show("不正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 18)
            {
                MessageBox.Show("正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 19)
            {
                MessageBox.Show("正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 20)
            {
                MessageBox.Show("正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            //if (_navi.CanGoForward)
            //    _navi.GoForward();
            //else
            //{
            //    MessageBox.Show("正解！", "答え");
            //    int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
            //    _navi.Navigate(_uriList[index]);    //ページの移動
            //}
        }

        private void Matigai_Click(object sender, RoutedEventArgs e)
        {
            int indexs = _uriList.IndexOf(_navi.CurrentSource);
            if (indexs == 1)
            {
                MessageBox.Show("不正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動

            }
            else if (indexs == 2)
            {

                MessageBox.Show("正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
                
            }
            else if (indexs == 3)
            {
                MessageBox.Show("不正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 4)
            {
                MessageBox.Show("不正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 5)
            {
                MessageBox.Show("正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 6)
            {
                MessageBox.Show("正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 7)
            {
                MessageBox.Show("不正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 8)
            {
                MessageBox.Show("不正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 9)
            {
                MessageBox.Show("不正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 10)
            {
                MessageBox.Show("正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 11)
            {
                MessageBox.Show("不正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 12)
            {
                MessageBox.Show("正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 13)
            {
                MessageBox.Show("不正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 14)
            {
                MessageBox.Show("正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 15)
            {
                MessageBox.Show("不正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 16)
            {
                MessageBox.Show("不正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 17)
            {
                MessageBox.Show("正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 18)
            {
                MessageBox.Show("不正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 19)
            {
                MessageBox.Show("不正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            else if (indexs == 20)
            {
                MessageBox.Show("不正解！", "答え");
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }
            //if (_navi.CanGoForward)
            //    _navi.GoForward();
            //else
            //{
            //    MessageBox.Show("不正解！", "答え");
            //    int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
            //    _navi.Navigate(_uriList[index]);    //ページの移動
            //}
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
