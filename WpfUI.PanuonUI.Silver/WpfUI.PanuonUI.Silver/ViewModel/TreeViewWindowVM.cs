using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfUI.PanuonUI.Silver.ViewModel
{
    public class TreeViewWindowVM : ViewModelBase
    {

        public ObservableCollection<TreeViewItemModel> RoleTreeItems { get; set; } = new ObservableCollection<TreeViewItemModel>();

        public TreeViewWindowVM()
        {
            TreeViewItemModel treeViewItemModel = new TreeViewItemModel("运维中心", "", 1 + "");

            TreeViewItemModel treeViewItemModelChild = new TreeViewItemModel("运维中心", "", 2 + "");

            TreeViewItemModel treeViewItemModelChildChild1 = new TreeViewItemModel("查询", "", 3 + "");
            TreeViewItemModel treeViewItemModelChildChild2 = new TreeViewItemModel("增加", "", 4 + "");
            TreeViewItemModel treeViewItemModelChildChild3 = new TreeViewItemModel("修改", "", 5 + "");

            TreeViewItemModel treeViewItemModelChildChild4 = new TreeViewItemModel("删除", "", 6 + "");

            treeViewItemModelChild.Children.Add(treeViewItemModelChildChild1);
            treeViewItemModelChild.Children.Add(treeViewItemModelChildChild2);
            treeViewItemModelChild.Children.Add(treeViewItemModelChildChild3);
            treeViewItemModelChild.Children.Add(treeViewItemModelChildChild4);


            TreeViewItemModel treeViewItemModelChild_2 = new TreeViewItemModel("设备报警", "", 7 + "");

            TreeViewItemModel treeViewItemModelChildChild1_2 = new TreeViewItemModel("查询", "", 8 + "");
            TreeViewItemModel treeViewItemModelChildChild2_2 = new TreeViewItemModel("增加", "", 9 + "");
            TreeViewItemModel treeViewItemModelChildChild3_2 = new TreeViewItemModel("修改", "", 10 + "");
            TreeViewItemModel treeViewItemModelChildChild4_2 = new TreeViewItemModel("删除", "", 11 + "");

            treeViewItemModelChild_2.Children.Add(treeViewItemModelChildChild1_2);
            treeViewItemModelChild_2.Children.Add(treeViewItemModelChildChild2_2);
            treeViewItemModelChild_2.Children.Add(treeViewItemModelChildChild3_2);
            treeViewItemModelChild_2.Children.Add(treeViewItemModelChildChild4_2);

            treeViewItemModel.Children.Add(treeViewItemModelChild);
            treeViewItemModel.Children.Add(treeViewItemModelChild_2);

            RoleTreeItems.Add(treeViewItemModel);
        }
    }


    public class TreeViewItemModel : ViewModelBase
    {

        public TreeViewItemModel(string header, object tag, string id, string icon = null)
        {
            Header = header;
            Tag = tag;
            Icon = icon;
            Id = id;
            Children = new ObservableCollection<TreeViewItemModel>();
        }

        public string Icon { get; set; }

        public string Id { set; get; }

        private string _header;

        public string Header
        {
            get => _header;
            set { _header = value; this.RaisePropertyChanged(); }
        }

        public object Tag { get; set; }

        public Visibility Visibility
        {
            get => _visibility;
            set { _visibility = value; RaisePropertyChanged(); }
        }
        private Visibility _visibility = Visibility.Visible;

        public bool IsExpanded
        {
            get => _isExpanded;
            set { _isExpanded = value; RaisePropertyChanged(); }
        }
        private bool _isExpanded = false;

        public ObservableCollection<TreeViewItemModel> Children
        {
            get => _children;
            set { _children = value; RaisePropertyChanged(); }
        }
        private ObservableCollection<TreeViewItemModel> _children;

        public Visibility HasChildren => Children.Count > 0 ? Visibility.Visible : Visibility.Collapsed;

        private bool _isSelected;

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                this.RaisePropertyChanged();

                SetChildrenChecked(_isSelected);
            }
        }

        /// <summary>
        /// 设置所有子项的选中状态
        /// </summary>
        /// <param name="isChecked"></param>
        public void SetChildrenChecked(bool isChecked)
        {
            foreach (TreeViewItemModel child in Children)
            {
                child.IsSelected = isChecked;
                child.SetChildrenChecked(isChecked);
            }
        }
    }
}
