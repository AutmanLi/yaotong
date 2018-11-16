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

namespace yaotong
{
    /// <summary>
    /// Interaction logic for ImageButton.xaml
    /// </summary>
    public partial class ImageButton : Button
    {
        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource",
            typeof(ImageSource), typeof(ImageButton), new PropertyMetadata(null));
        public ImageSource ImageSource
        {
            get { return (ImageSource)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }


        public static readonly DependencyProperty ImageSourceHoverProperty =
            DependencyProperty.Register("ImageSourceHover",
            typeof(ImageSource), typeof(ImageButton), new PropertyMetadata(ImageSourceHoverCallback));
        public ImageSource ImageSourceHover
        {
            get { return (ImageSource)GetValue(ImageSourceHoverProperty); }
            set { SetValue(ImageSourceHoverProperty, value); }
        }

        private static void ImageSourceHoverCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((ImageButton)d).IsImageSourceHoverExist = e.NewValue != null;
        }

        public static readonly DependencyProperty IsImageSourceHoverExistProperty =
            DependencyProperty.Register("IsImageSourceHoverExist",
            typeof(bool), typeof(ImageButton), new PropertyMetadata(null));
        public bool IsImageSourceHoverExist
        {
            get { return (bool)GetValue(IsImageSourceHoverExistProperty); }
            set { SetValue(IsImageSourceHoverExistProperty, value); }
        }


        public ImageButton()
        {
            this.InitializeComponent();
        }


        protected override void OnMouseEnter(MouseEventArgs e)
        {
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(MouseEventArgs e)
        {
            base.OnMouseLeave(e);
        }
    }
}