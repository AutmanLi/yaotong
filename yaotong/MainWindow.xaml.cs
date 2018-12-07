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
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.SimpleChildWindow;

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

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            
            
            if(textBox.Text=="autman" && passwordBox.Password=="admin123")
            {
                testWindow tw = new testWindow();
                Application.Current.MainWindow = tw;
                this.Close();
                tw.Show();
            }
            else
            {
                ChildWindow loginResult = new ChildWindow();
                loginResult.ChildWindowWidth = 200;
                loginResult.ChildWindowHeight = 200;
                loginResult.Title = "登陆失败！";
                loginResult.ShowCloseButton = true;

                Grid re_grid = new Grid();
                TextBlock login_message = new TextBlock();
                login_message.Text = "用户名或密码错误！";
                login_message.HorizontalAlignment = HorizontalAlignment.Center;
                login_message.VerticalAlignment = VerticalAlignment.Center;

                re_grid.Children.Add(login_message);

                loginResult.Content = re_grid;
                await this.ShowChildWindowAsync(loginResult, mainGrid);
            }
        }

        //展示注册子窗体
        private async void show_childWindow(object sender,RoutedEventArgs e)
        {
            ChildWindow registerWindow = new ChildWindow();
            registerWindow.ChildWindowWidth = 450;
            registerWindow.ChildWindowHeight = 400;
            
            registerWindow.Title = "新用户注册";
            registerWindow.ShowCloseButton = true;
           
            Grid childGrid = new Grid();
            TextBlock userBlock = new TextBlock();
            userBlock.Text = "用户名：";
            userBlock.Margin = new Thickness(75, 25, 0, 0);
            userBlock.TextWrapping = TextWrapping.Wrap;
            userBlock.HorizontalAlignment = HorizontalAlignment.Left;
            userBlock.VerticalAlignment = VerticalAlignment.Top;

            TextBlock pswBlock = new TextBlock();
            pswBlock.Text = "密码：";
            pswBlock.Margin = new Thickness(86, 85, 0, 0);
            pswBlock.TextWrapping = TextWrapping.Wrap;
            pswBlock.HorizontalAlignment = HorizontalAlignment.Left;
            pswBlock.VerticalAlignment = VerticalAlignment.Top;

            TextBlock pswAgainBlock = new TextBlock();
            pswAgainBlock.Text = "再次确认密码：";
            pswAgainBlock.Margin = new Thickness(40, 145, 0, 0);
            pswAgainBlock.TextWrapping = TextWrapping.Wrap;
            pswAgainBlock.HorizontalAlignment = HorizontalAlignment.Left;
            pswAgainBlock.VerticalAlignment = VerticalAlignment.Top;

            TextBlock user_valid = new TextBlock();
            user_valid.Visibility = Visibility.Collapsed;
            user_valid.Name = "user_valid";
            user_valid.Text = "用户名已存在!";
            user_valid.Foreground = Brushes.Red;
            user_valid.Margin = new Thickness(140, 55, 0, 0);
            user_valid.TextWrapping = TextWrapping.Wrap;
            user_valid.HorizontalAlignment = HorizontalAlignment.Left;
            user_valid.VerticalAlignment = VerticalAlignment.Top;

            TextBlock psw_valid = new TextBlock();
            psw_valid.Visibility = Visibility.Collapsed;
            psw_valid.Name = "psw_valid";
            psw_valid.Text = "密码必须在6-20位之间!";
            psw_valid.Foreground = Brushes.Red;
            psw_valid.Margin = new Thickness(140, 115, 0, 0);
            psw_valid.TextWrapping = TextWrapping.Wrap;
            psw_valid.HorizontalAlignment = HorizontalAlignment.Left;
            psw_valid.VerticalAlignment = VerticalAlignment.Top;


            TextBlock pswAg_valid = new TextBlock();
            pswAg_valid.Visibility = Visibility.Collapsed;
            pswAg_valid.Name = "pswAg_valid";
            pswAg_valid.Text = "两次输入的密码不同";
            pswAg_valid.Foreground = Brushes.Red;
            pswAg_valid.Margin = new Thickness(140, 175, 0, 0);
            pswAg_valid.TextWrapping = TextWrapping.Wrap;
            pswAg_valid.HorizontalAlignment = HorizontalAlignment.Left;
            pswAg_valid.VerticalAlignment = VerticalAlignment.Top;


            // HorizontalAlignment="Left" Height="23" TextWrapping="Wrap" Text="" VerticalAlignment="Top"
            TextBox userBox = new TextBox();
            userBox.Width = 200;
            userBox.Height = 23;
            userBox.Margin= new Thickness(140, 20, 0, 0);
            userBox.Name = "userna";
            userBox.HorizontalAlignment = HorizontalAlignment.Left;
            userBox.TextWrapping = TextWrapping.Wrap;
            userBox.VerticalAlignment = VerticalAlignment.Top;
            userBox.LostFocus += new RoutedEventHandler(userbox_LostFocus);

            //userBox.Margin= new Thickness(40, 16, 0, 0);

            PasswordBox pswBox = new PasswordBox();
            pswBox.Width = 200;
            pswBox.Height = 23;
            pswBox.Margin = new Thickness(140, 80, 0, 0);
            pswBox.Name = "passw";
            pswBox.HorizontalAlignment = HorizontalAlignment.Left;
            pswBox.VerticalAlignment = VerticalAlignment.Top;
            pswBox.LostFocus += new RoutedEventHandler(pswbox_LostFocus);

            PasswordBox pswAgainBox = new PasswordBox();
            pswAgainBox.Width = 200;
            pswAgainBox.Height = 23;
            pswAgainBox.Margin = new Thickness(140, 140, 0, 0);
            pswAgainBox.Name = "pswAgain";
            pswAgainBox.HorizontalAlignment = HorizontalAlignment.Left;
            pswAgainBox.VerticalAlignment = VerticalAlignment.Top;
            pswAgainBox.LostFocus += new RoutedEventHandler(pswAgbox_LostFocus);

            //<Button x:Name="button" Content="登录" Foreground="White"  Background="Red" Canvas.Left="91" Canvas.Top="170" Width="200" Click="button_Click" />
            Button btn_reg = new Button();
            btn_reg.Content = "注册";
            btn_reg.Name = "btn_reg";
            btn_reg.Foreground = Brushes.White;
            btn_reg.Background = Brushes.Orange;
            btn_reg.Width = 200;
            btn_reg.Height = 30;
            btn_reg.Margin= new Thickness(30, 60, 0, 0);


            childGrid.Children.Add(userBlock);
            childGrid.Children.Add(userBox);
            childGrid.Children.Add(user_valid);
            childGrid.Children.Add(pswBlock);
            childGrid.Children.Add(pswBox);
            childGrid.Children.Add(psw_valid);
            childGrid.Children.Add(pswAgainBlock);
            childGrid.Children.Add(pswAgainBox);
            childGrid.Children.Add(pswAg_valid);
            childGrid.Children.Add(btn_reg);

            registerWindow.Content = childGrid;


            await this.ShowChildWindowAsync(registerWindow ,mainGrid);
        }

        #region 注册验证事件

        //用户名窗口离开时触发用户名验证
        private void userbox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox userBox = mainGrid.FindChild<TextBox>("userna");
            TextBlock user_valid= mainGrid.FindChild<TextBlock>("user_valid");
            //当找不到时，其实就是关闭窗口了，直接中断
            if(userBox==null)
            {
                return;
            }
            userBox.Text = userBox.Text.Trim();
            user_valid.Visibility = Visibility.Collapsed;
            if (userBox.Text.Length<6 ||userBox.Text.Length>20)
            {
                user_valid.Text = "用户名必须在6-20位之间";
                user_valid.Visibility = Visibility.Visible;
            }
        }
        //密码窗口离开时触发用户名验证
        private void pswbox_LostFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox pswBox = mainGrid.FindChild<PasswordBox>("passw");
            TextBlock psw_valid = mainGrid.FindChild<TextBlock>("psw_valid");
            //当找不到时，其实就是关闭窗口了，直接中断
            if (pswBox == null)
            {
                return;
            }
            string password = pswBox.Password.Trim();
            psw_valid.Visibility = Visibility.Collapsed;
            if (password.Length < 6 || password.Length > 20)
            {
                psw_valid.Visibility = Visibility.Visible;
            }
        }
        //再次确认窗口离开时触发用户名验证
        private void pswAgbox_LostFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox pswAgBox = mainGrid.FindChild<PasswordBox>("pswAgain");
            TextBlock pswAg_valid = mainGrid.FindChild<TextBlock>("pswAg_valid");
            PasswordBox pswBox = mainGrid.FindChild<PasswordBox>("passw");
            //当找不到时，其实就是关闭窗口了，直接中断
            if (pswAgBox == null)
            {
                return;
            }
            string password = pswBox.Password.Trim();
            string passwordAgain = pswAgBox.Password.Trim();
            pswAg_valid.Visibility = Visibility.Collapsed;
            if (password!= passwordAgain)
            {
                pswAg_valid.Visibility = Visibility.Visible;
            }
        }

        #endregion

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
