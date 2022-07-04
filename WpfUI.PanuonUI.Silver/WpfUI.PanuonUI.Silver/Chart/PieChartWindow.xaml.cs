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
using System.Windows.Shapes;
using WpfUI.PanuonUI.Silver.ViewModel.Chart;

namespace WpfUI.PanuonUI.Silver.Chart
{
    /// <summary>
    /// PieChartWindow.xaml 的交互逻辑
    /// </summary>
    public partial class PieChartWindow : Window
    {
        public PieChartWindow()
        {
            InitializeComponent();

            //DataContext = new PieChartWindowVM();
        }
    }
}
