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

namespace Resources
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeColorButton_Click(object sender, RoutedEventArgs e)
        {
            var brush = FindResource("myBackgroundColor") as SolidColorBrush;

            if (brush is null)
                return;

            brush.Color = Colors.DarkKhaki;
        }

        private void ChangeInstanceButton_Click(object sender, RoutedEventArgs e)
        {
            var brush = new SolidColorBrush(Colors.AntiqueWhite);

            Resources["myBackgroundColor"] = brush;

            (myStackPanel.Resources["myBackgroundColor"] as SolidColorBrush).Color = Colors.LightBlue;
        }

        private void ChangeInstanceToOtherTypeButton_Click(object sender, RoutedEventArgs e)
        {
            var brush = new RadialGradientBrush(Colors.PaleVioletRed, Colors.LightBlue);

            Resources["myBackgroundColor"] = brush;
        }
    }
}
