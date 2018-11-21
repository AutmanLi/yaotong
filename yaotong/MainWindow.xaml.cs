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
using MahApps.Metro.Controls;

namespace yaotong
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ImageBrush b = new ImageBrush();
            b.ImageSource = new BitmapImage(new Uri("pack://siteoforigin:,,,/image/background.jpg"));
            b.Stretch = Stretch.Fill;
            this.Background = b;
        }

        private void MetroWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.DragMove();
            }
            catch { }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            testWindow tw = new testWindow();
            Application.Current.MainWindow = tw;
            this.Close();
            tw.Show();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {

        }
        #region 自定义标题栏
        /// <summary>
        /// 窗口关闭
        /// </summary>
        private void button_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 窗口最小化
        /// </summary>
        private void button_min_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized; //设置窗口最小化
        }
        #endregion
    }
}
