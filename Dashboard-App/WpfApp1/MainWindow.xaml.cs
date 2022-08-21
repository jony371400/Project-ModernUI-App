//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;

using System.Windows;
using System.Windows.Input;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void ControlBtn_Click(object sender, RoutedEventArgs e)
        {
            PageDashBoard.Visibility = Visibility.Hidden;
            PageListing.Visibility = Visibility.Hidden;
            PageMessage.Visibility = Visibility.Hidden;
            PageOrders.Visibility = Visibility.Hidden;
            PageStatistics.Visibility = Visibility.Hidden;
            PageRevenue.Visibility = Visibility.Hidden;
            PagePromete.Visibility = Visibility.Hidden;
            PageSetting.Visibility = Visibility.Hidden;

            BtnDashBoard.Style = (Style)Application.Current.Resources["menuButton"];
            BtnListing.Style = (Style)Application.Current.Resources["menuButton"];
            BtnMessage.Style = (Style)Application.Current.Resources["menuButton"];
            BtnOrders.Style = (Style)Application.Current.Resources["menuButton"];
            BtnStatistics.Style = (Style)Application.Current.Resources["menuButton"];
            BtnRevenue.Style = (Style)Application.Current.Resources["menuButton"];
            BtnPromote.Style = (Style)Application.Current.Resources["menuButton"];
            BtnSetting.Style = (Style)Application.Current.Resources["menuButton"];

            if (sender == BtnDashBoard)
            {
                PageDashBoard.Visibility = Visibility.Visible;
                BtnDashBoard.Style = (Style)Application.Current.Resources["menuButtonActive"];
            }
            else if (sender == BtnListing)
            {
                PageListing.Visibility = Visibility.Visible;
                BtnListing.Style = (Style)Application.Current.Resources["menuButtonActive"];
            }
            else if (sender == BtnMessage)
            {
                PageMessage.Visibility = Visibility.Visible;
                BtnMessage.Style = (Style)Application.Current.Resources["menuButtonActive"];
            }
            else if (sender == BtnOrders)
            {
                PageOrders.Visibility = Visibility.Visible;
                BtnOrders.Style = (Style)Application.Current.Resources["menuButtonActive"];
            }
            else if (sender == BtnStatistics)
            {
                PageStatistics.Visibility = Visibility.Visible;
                BtnStatistics.Style = (Style)Application.Current.Resources["menuButtonActive"];
            }
            else if (sender == BtnRevenue)
            {
                PageRevenue.Visibility = Visibility.Visible;
                BtnRevenue.Style = (Style)Application.Current.Resources["menuButtonActive"];
            }
            else if (sender == BtnPromote)
            {
                PagePromete.Visibility = Visibility.Visible;
                BtnPromote.Style = (Style)Application.Current.Resources["menuButtonActive"];
            }
            else if (sender == BtnSetting)
            {
                PageSetting.Visibility = Visibility.Visible;
                BtnSetting.Style = (Style)Application.Current.Resources["menuButtonActive"];
            }
            else if (sender == BtnPower)
            {
                Application.Current.Shutdown();
            }
        }
    }
}