using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using System.Net.Http;
using System.Net.Http.Headers;

namespace yaotong
{
    /// <summary>
    /// Interaction logic for testWindow.xaml
    /// </summary>
    public partial class testWindow : MetroWindow
    {
        HttpClient client = new HttpClient();
        

        public testWindow()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("http://202.114.40.141:9100/");
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            //this.ShowMessageAsync("登录成功！", "请继续");

            var response = await client.GetAsync("users");
            response.EnsureSuccessStatusCode(); // Throw on error code（有错误码时报出异常）.

            string products = await response.Content.ReadAsStringAsync();
            
            
        }
    }
}
