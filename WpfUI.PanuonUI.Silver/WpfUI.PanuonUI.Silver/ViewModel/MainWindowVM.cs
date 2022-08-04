using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Threading;

namespace WpfUI.PanuonUI.Silver.ViewModel
{
    public class MainWindowVM : ViewModelBase
    {

        public MainWindowVM()
        {


        }
        private RelayCommand<object> _LoadedEvent;
        /// <summary>
        /// datagridheader全选 
        /// </summary>
        public RelayCommand<object> LoadedEventee
        {
            get
            {
                if (_LoadedEvent == null) _LoadedEvent = new RelayCommand<object>(obj =>
                {


                }, true);
                return _LoadedEvent;
            }
            set { _LoadedEvent = value; }
        }

        private int temp;

        public int Temp
        {

            get
            {

                return temp;
            }
            set
            {
                temp = value;

                Dispatcher.CurrentDispatcher.Invoke(() =>
                {

                });
              
            }

        }



        private RelayCommand<MouseEventArgs> _dataGridHeaderCheckedCommond;
        /// <summary>
        /// datagridheader全选 
        /// </summary>
        public RelayCommand<MouseEventArgs> DataGridHeaderCheckedCommond
        {
            get
            {
                if (_dataGridHeaderCheckedCommond == null) _dataGridHeaderCheckedCommond = new RelayCommand<MouseEventArgs>(obj =>
                {


                }, true);
                return _dataGridHeaderCheckedCommond;
            }
            set { _dataGridHeaderCheckedCommond = value; }
        }


        private RelayCommand<object> leftClickButtonDown;

        public RelayCommand<object> LeftClickButtonDown
        {
            get
            {
                if (leftClickButtonDown == null)
                {
                    leftClickButtonDown = new RelayCommand<object>(obj =>
                    {


                    }, true);
                }
                return leftClickButtonDown;
            }
            set
            {
                leftClickButtonDown = value;
            }
        }
    }
}
