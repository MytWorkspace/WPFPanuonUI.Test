using GalaSoft.MvvmLight;
using Panuon.UI.Silver.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfUI.PanuonUI.Silver.ViewModel
{
    public class DataGridTreeWindowVM : ViewModelBase
    {

        private ObservableCollection<TreeViewDataGridItemModel> _CompanyNames = new ObservableCollection<TreeViewDataGridItemModel>();
        public ObservableCollection<TreeViewDataGridItemModel> CompanyNames
        {
            get { return _CompanyNames; }
            set
            {
                _CompanyNames = value; this.RaisePropertyChanged();
            }
        }


        public DataGridTreeWindowVM()
        {

            TreeViewDataGridItemModel treeViewDataGridItem = new TreeViewDataGridItemModel();
            treeViewDataGridItem.Id = "1";
            treeViewDataGridItem.Header = new ObservableCollection<MessageViewDataTreeModel>()
            {
                new MessageViewDataTreeModel(){

                 Number=1+"",
                  CompanyNames="总公司",
                }
            };
            treeViewDataGridItem.Children = new ObservableCollection<TreeViewDataGridItemModel>()
            {
                new TreeViewDataGridItemModel()
                {
                     Id="4",
                     Header= new ObservableCollection<MessageViewDataTreeModel>()
                     {
                              new MessageViewDataTreeModel()
                              {
                                   Number="2",
                                   CompanyNames="分公司1"
                              }
                     }
                }
            };

            CompanyNames.Add(treeViewDataGridItem);
        }

    }

    public class TreeViewDataGridItemModel : ViewModelBase
    {

        public string Icon { get; set; }

        public string Id { set; get; }

        private ObservableCollection<MessageViewDataTreeModel> _header;

        public ObservableCollection<MessageViewDataTreeModel> Header
        {
            get => _header;
            set { _header = value; this.RaisePropertyChanged(); }
        }

        public object Tag { get; set; }


        public bool IsExpanded
        {
            get => _isExpanded;
            set { _isExpanded = value; RaisePropertyChanged(); }
        }
        private bool _isExpanded = false;

        public ObservableCollection<TreeViewDataGridItemModel> Children
        {
            get => _children;
            set { _children = value; RaisePropertyChanged(); }
        }
        private ObservableCollection<TreeViewDataGridItemModel> _children;

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
            foreach (TreeViewDataGridItemModel child in Children)
            {
                child.IsSelected = isChecked;
                child.SetChildrenChecked(isChecked);
            }
        }
    }



    public class MessageViewDataTreeModel : ObservableObject
    {
        [IgnoreColumn]
        public Action IsSelectedClickAction { get; set; }
        private bool _isSelected;
        [IgnoreColumn]
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value; this.RaisePropertyChanged();
                IsSelectedClickAction?.Invoke();
            }
        }

        [DisplayName("序号")]
        [ColumnWidth]
        [ReadOnlyColumn]
        public string Number { get; set; }

        [DisplayName("发布公司")]
        [ColumnWidth]
        [ReadOnlyColumn]
        public string CompanyNames { set; get; }

        [DisplayName("标题")]
        [ColumnWidth]
        [ReadOnlyColumn]
        public string Title { get; set; }

        [DisplayName("类型")]
        [ColumnWidth]
        [ReadOnlyColumn]
        public string Type { get; set; }

        [DisplayName("添加时间")]
        [ColumnWidth("172")]
        [ReadOnlyColumn]
        public string AddTime { get; set; }

        [DisplayName("启用状态")]
        [ColumnWidth("80")]
        [IgnoreColumn]
        [ReadOnlyColumn]
        public string Status { get; set; }

        [DisplayName("是否已读")]
        [ColumnWidth("80")]
        [IgnoreColumn]
        [ReadOnlyColumn]
        public string IsRead { get; set; }


        [IgnoreColumn]
        public object Tag { get; set; }
    }
}
