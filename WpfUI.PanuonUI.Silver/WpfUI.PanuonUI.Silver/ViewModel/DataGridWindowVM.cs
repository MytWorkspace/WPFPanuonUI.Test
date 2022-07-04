using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Panuon.UI.Silver.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfUI.PanuonUI.Silver.ViewModel
{
    public class DataGridWindowVM : ViewModelBase
    {
        public DataGridWindowVM()
        {

            MessageViewDataList = new ObservableCollection<MessageViewDataModel>()
            {
                new MessageViewDataModel(){ Number="1",Title = "Title", Type = "Type",  CompanyName = "CompanyName", IsRead = "IsRead",Status="Status", AddTime = "AddTime" },
                new MessageViewDataModel(){ Number="2",Title = "Title", Type = "Type",  CompanyName = "CompanyName", IsRead = "IsRead",Status="Status", AddTime = "AddTime" },
                new MessageViewDataModel(){ Number="3",Title = "Title", Type = "Type", CompanyName = "CompanyName", IsRead = "IsRead",Status="Status", AddTime = "AddTime" },
                new MessageViewDataModel(){ Number="4",Title = "Title", Type = "Type", CompanyName = "CompanyName", IsRead = "IsRead",Status="Status", AddTime = "AddTime" },
                new MessageViewDataModel(){ Number="5",Title = "Title", Type = "Type", CompanyName = "CompanyName", IsRead = "IsRead",Status="Status", AddTime = "AddTime" }
            };
        }

        private ObservableCollection<MessageViewDataModel> _messageViewDataList;
        public ObservableCollection<MessageViewDataModel> MessageViewDataList
        {
            get { return _messageViewDataList; }
            set
            {
                _messageViewDataList = value; this.RaisePropertyChanged();
            }
        }


        private bool _isFullSelected;

        public bool IsFullSelected
        {
            get { return _isFullSelected; }
            set
            {
                _isFullSelected = value; this.RaisePropertyChanged();
            }
        }


        private RelayCommand<RoutedEventArgs> _dataGridHeaderCheckedCommond;
        /// <summary>
        /// datagridheader全选 
        /// </summary>
        public RelayCommand<RoutedEventArgs> DataGridHeaderCheckedCommond
        {
            get
            {
                if (_dataGridHeaderCheckedCommond == null) _dataGridHeaderCheckedCommond = new RelayCommand<RoutedEventArgs>(obj =>
                {

                }, true);
                return _dataGridHeaderCheckedCommond;
            }
            set { _dataGridHeaderCheckedCommond = value; }
        }
    }

    public class MessageViewDataModel : ObservableObject
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

        [DisplayName("标题")]
        [ColumnWidth]
        [ReadOnlyColumn]
        public string Title { get; set; }

        [DisplayName("类型")]
        [ColumnWidth]
        [ReadOnlyColumn]
        public string Type { get; set; }

        [DisplayName("内容")]
        [ColumnWidth("*")]
        [ReadOnlyColumn]
        public string Message { get; set; }

        [DisplayName("添加时间")]
        [ColumnWidth("172")]
        [ReadOnlyColumn]
        public string AddTime { get; set; }

        [DisplayName("启用状态")]
        [ColumnWidth("80")]
        [IgnoreColumn]
        [ReadOnlyColumn]
        public string Status { get; set; }

        [DisplayName("发布公司")]
        [ColumnWidth("253")]
        [ReadOnlyColumn]
        public string CompanyName { get; set; }

        [DisplayName("是否已读")]
        [ColumnWidth("80")]
        [IgnoreColumn]
        [ReadOnlyColumn]
        public string IsRead { get; set; }


        [IgnoreColumn]
        public object Tag { get; set; }
    }
}
