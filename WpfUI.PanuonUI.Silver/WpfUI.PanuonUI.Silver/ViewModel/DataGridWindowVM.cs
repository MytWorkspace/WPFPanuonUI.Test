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


            MessageModelList = new ObservableCollection<MessageModel>()
            {
                new MessageModel(){ Number="1",Title = "Title1", Type = "Type1", },
                new MessageModel(){ Number="2",Title = "Title2", Type = "Type2", },
                new MessageModel(){ Number="3",Title = "Title3", Type = "Type3",},
                new MessageModel(){ Number="4",Title = "Title4", Type = "Type4",},
                new MessageModel(){ Number="5",Title = "Title5", Type = "Type5",}
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


        private ObservableCollection<MessageModel> messageModelList;
        public ObservableCollection<MessageModel> MessageModelList
        {
            get { return messageModelList; }
            set
            {
                messageModelList = value; this.RaisePropertyChanged();
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
        public string Number { get; set; }

        [DisplayName("标题")]
        public string Title { get; set; }

        [DisplayName("类型")]
        public string Type { get; set; }

        [DisplayName("内容")]
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



    public class MessageModel : ViewModelBase
    {
        private string number;
        /// <summary>
        /// 序号
        /// </summary>
        public string Number
        {
            get { return number; }
            set
            {
                number = value;
                this.RaisePropertyChanged();
            }
        }
        private string title;
        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                this.RaisePropertyChanged();
            }
        }
        private string type;
        /// <summary>
        /// 类型
        /// </summary>
        public string Type
        {
            get { return type; }
            set
            {
                type = value;
                this.RaisePropertyChanged();
            }
        }
        private string message;
        /// <summary>
        /// 内容
        /// </summary>
        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                this.RaisePropertyChanged();
            }
        }

    }
}
