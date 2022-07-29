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
using WpfUI.PanuonUI.Silver.Chart;
using WpfUI.PanuonUI.Silver.ViewModel;
using WpfUI.PanuonUI.Silver.Windows;

namespace WpfUI.PanuonUI.Silver
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowVM();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TreeViewWindow treeViewWindow = new TreeViewWindow();
            treeViewWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DataGridWindow treeViewWindow = new DataGridWindow();
            treeViewWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window1 treeViewWindow = new Window1();
            treeViewWindow.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            DataGridTreeWindow dataGridTreeWindow = new DataGridTreeWindow();
            dataGridTreeWindow.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            PieChartWindow pieChartWindow = new PieChartWindow();
            pieChartWindow.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ListBoxWindow1 listBoxWindow1 = new ListBoxWindow1();
            listBoxWindow1.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            TabItemViewWindow tabItemViewWindow = new TabItemViewWindow();
            tabItemViewWindow.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            TextBlockWindow textBlockWindow = new TextBlockWindow();
            textBlockWindow.Show();
        }
    }
}
