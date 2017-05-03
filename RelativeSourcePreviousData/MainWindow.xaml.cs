using System.Collections.Generic;
using System.Windows;

namespace RelativeSourcePreviousData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            myChart.ItemsSource = GetData();
        }

        private IEnumerable<Item> GetData()
        {
            return new List<Item>
            {
                new Item { Value = 50 },
                new Item { Value = 68 },
                new Item { Value = 99 },
                new Item { Value = 75 },
                new Item { Value = 74 },
                new Item { Value = 25 },
                new Item { Value = 0 },
                new Item { Value = 60 },
                new Item { Value = 120 },
                new Item { Value = 30 },
                new Item { Value = 40 },
                new Item { Value = 35 },
                new Item { Value = 45 },
                new Item { Value = 45 },
                new Item { Value = 82 },
                new Item { Value = 34 },
                new Item { Value = 8 }
            };
        }
    }
}
