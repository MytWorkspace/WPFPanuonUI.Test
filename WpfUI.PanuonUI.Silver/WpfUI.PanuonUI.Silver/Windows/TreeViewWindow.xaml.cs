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
    /// TreeViewWindow.xaml 的交互逻辑
    /// </summary>
    public partial class TreeViewWindow : Window
    {
        TreeViewWindowVM vm;
        public TreeViewWindow()
        {
            InitializeComponent();

            DataContext = vm = new TreeViewWindowVM();

        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            string id = checkBox.Tag as string;

           // SetCheckedById(id);
        }

        /// <summary>
        /// 设置对应Id的项为选中状态
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int SetCheckedById(string id)
        {
            foreach (var tree in vm.RoleTreeItems)
            {
                if (tree.Id.Equals(id))
                {
                    tree.IsSelected = true;
                    return 1;
                }
                if (SetCheckedById(id, tree.Children) == 1)
                {
                    return 1;
                }
            }
            return 0;
        }

        /// <summary>
        /// 设置对应Id的项为选中状态
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int SetCheckedById(string id, IList<TreeViewItemModel> treeList)
        {
            foreach (var tree in treeList)
            {
                if (tree.Id.Equals(id))
                {
                    tree.IsSelected = true;
                    return 1;
                }
                if (SetCheckedById(id, tree.Children) == 1)
                {
                    return 1;
                }
            }

            return 0;
        }
    }
}
