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
using WpfUI.PanuonUI.Silver.ViewModel;

namespace WpfUI.PanuonUI.Silver.Windows
{
    /// <summary>
    /// TreeListViewWindow.xaml 的交互逻辑
    /// </summary>
    public partial class TreeListViewWindow : Window
    {

        private TreeListViewWindowVM vm;
        public TreeListViewWindow()
        {
            InitializeComponent();

            DataContext = vm = new TreeListViewWindowVM();
        }
    }
}
