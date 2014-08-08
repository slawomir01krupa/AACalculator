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

namespace AACalculator.Core
{
    /// <summary>
    /// Interaction logic for SmallButton.xaml
    /// </summary>
    public partial class SmallButton : Button
    {
        public SmallButton()
        {
            InitializeComponent();
        }


        // Summary:
        //     Identifies the Image dependency property.
        public static readonly DependencyProperty ImageProperty = DependencyProperty.Register(
           "Image", typeof(ImageSource), typeof(SmallButton), new PropertyMetadata(null));

        // Summary:
        //     Identifies the Image dependency property.
        public static readonly DependencyProperty ImageOnHoverProperty = DependencyProperty.Register(
           "ImageOnHover", typeof(ImageSource), typeof(SmallButton), new PropertyMetadata(null));

        // Summary:
        //     Identifies the Text dependency property.
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
           "Text", typeof(string), typeof(SmallButton), new PropertyMetadata(String.Empty));

        public ImageSource ImageOnHover
        {
            get { return (ImageSource)GetValue(ImageOnHoverProperty); }
            set { SetValue(ImageOnHoverProperty, value); }
        }
        // Summary:
        //     Gets or sets the header for the PanoramaItem.
        //
        // Returns:
        //     Returns System.Object .
        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        // Summary:
        //     Gets or sets the header for the PanoramaItem.
        //
        // Returns:
        //     Returns System.Object .
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
    }
}
