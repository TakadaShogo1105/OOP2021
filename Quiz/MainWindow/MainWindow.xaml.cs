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

namespace MainWindow
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
        };

        private void myFrame_Loaded(object sender, RoutedEventArgs e)
        {
            _navi.Navigate(_uriList[0]);    //初期ページの表示
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
