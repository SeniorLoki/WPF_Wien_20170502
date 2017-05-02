using System.Windows;

namespace DelegatesExample
{
    public delegate string MyDelegate(int zahl, double wert);

    public partial class MainWindow : Window
    {
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyDelegate del = new MyDelegate(MeineMethode);

            MessageBox.Show(del(5, 9.0));
        }

        private string MeineMethode(int i, double d)
        {
            return (i + d).ToString();
        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
