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
using MahApps.Metro.Controls.Dialogs;

namespace yaotong
{
    /// <summary>
    /// MyDiaglog.xaml 的交互逻辑
    /// </summary>
    public partial class MyDiaglog : UserControl
    {
        // Here we create the viewmodel with the current DialogCoordinator instance 
        //VIEWMODEL vm = new VIEWMODEL(DialogCoordinator.Instance);
        public MyDiaglog()
        {
            InitializeComponent();
          //  DataContext = vm;

        }
    }
}
