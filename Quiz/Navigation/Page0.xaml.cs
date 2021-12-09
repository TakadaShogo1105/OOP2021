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

namespace Navigation
{
    /// <summary>
    /// Page1.xaml の相互作用ロジック
    /// </summary>
    public partial class Page1 : Page
    {

        private NavigationService _navi;    //ナビゲーションサービス
        public Page1()
        {
            InitializeComponent();
        }

        private List<Uri> _uriList = new List<Uri>() {
            //new Uri("Page1.xaml",UriKind.Relative),
            new Uri("Page2.xaml",UriKind.Relative),
            new Uri("Page3.xaml",UriKind.Relative),
        };

        //private void myFrame_Loaded(object sender, RoutedEventArgs e)
        //{
        //    _navi.Navigate(_uriList[0]);    //初期ページの表示
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_navi.CanGoForward)
                _navi.GoForward();
            else
            {
                //int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[2]);    //ページの移動
            }
        }

        private void myFrame_Navigated(object sender, NavigationEventArgs e)
        {
            int index = _uriList.IndexOf(_navi.CurrentSource);
            if (index + 1 == _uriList.Count)
                MangaButton.IsEnabled = false;
            else
                MangaButton.IsEnabled = true;
           
        }

    }
}
