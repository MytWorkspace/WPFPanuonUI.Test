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
    /// DataGridWindow.xaml 的交互逻辑
    /// </summary>
    public partial class DataGridWindow : Window
    {
        public DataGridWindow()
        {
            InitializeComponent();

            DataContext = new DataGridWindowVM();
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {

        }
    }


}
