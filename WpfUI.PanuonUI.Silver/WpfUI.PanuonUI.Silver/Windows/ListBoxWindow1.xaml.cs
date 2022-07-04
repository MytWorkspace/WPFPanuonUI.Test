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
    /// ListBoxWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class ListBoxWindow1 : Window
    {
        public ListBoxWindow1()
        {
            InitializeComponent();

            DataContext = new ListBoxWindow1VM();
        }
    }
}
