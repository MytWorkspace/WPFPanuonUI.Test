using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfUI.PanuonUI.Silver.ViewModel
{
    public class ListBoxWindow1VM : ViewModelBase
    {

        private ObservableCollection<ListBoxParamModel> listBoxParamModels = new ObservableCollection<ListBoxParamModel>();
        public ObservableCollection<ListBoxParamModel> ListBoxParamModels
        {
            get { return listBoxParamModels; }
            set
            {
                listBoxParamModels = value; this.RaisePropertyChanged();
            }
        }

        public ListBoxWindow1VM()
        {

            var listboxParam = new ListBoxParamModel()
            {
                Title = "分公司",
                Person = "个人",
                Phone = "123456",
                Email = "456@qq.com",
            };
            DeptModel dept1 = new DeptModel()
            {
                Id = 1 + "",
                DeptName = "安装部",
            };
            DeptModel dept2 = new DeptModel()
            {
                Id = 1 + "",
                DeptName = "研发部",
            };
            DeptModel dept3 = new DeptModel()
            {
                Id = 1 + "",
                DeptName = "生产部1",
            };
            DeptModel dept4 = new DeptModel()
            {
                Id = 1 + "",
                DeptName = "生产部2",
            };
            DeptModel dept5 = new DeptModel()
            {
                Id = 1 + "",
                DeptName = "生产部3",
            };
            DeptModel dept6 = new DeptModel()
            {
                Id = 1 + "",
                DeptName = "生产部4",
            };
            listboxParam.DeptsModel.Add(dept1);
            listboxParam.DeptsModel.Add(dept2);
            listboxParam.DeptsModel.Add(dept3);
            listboxParam.DeptsModel.Add(dept4);
            listboxParam.DeptsModel.Add(dept5);
            listboxParam.DeptsModel.Add(dept6);

            ListBoxParamModels.Add(listboxParam);



            ListBoxParamModels.Add(new ListBoxParamModel()
            {
                Title = "分公司2",
                Person = "个人",
                Phone = "123456",
                Email = "456@qq.com"
            });
            ListBoxParamModels.Add(new ListBoxParamModel()
            {
                Title = "分公司3",
                Person = "个人",
                Phone = "123456",
                Email = "456@qq.com"
            });
            ListBoxParamModels.Add(new ListBoxParamModel()
            {
                Title = "分公司4",
                Person = "个人",
                Phone = "123456",
                Email = "456@qq.com"
            });

        }

    }


    public class ListBoxParamModel : ViewModelBase
    {

        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                RaisePropertyChanged();
            }
        }


        private string person;
        public string Person
        {
            get { return person; }
            set
            {
                person = value;
                RaisePropertyChanged();
            }
        }

        private string phone;
        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
                RaisePropertyChanged();
            }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<DeptModel> deptes = new ObservableCollection<DeptModel>();
        public ObservableCollection<DeptModel> DeptsModel
        {
            get { return deptes; }
            set
            {
                deptes = value; this.RaisePropertyChanged();
            }
        }
    }

    public class DeptModel : ViewModelBase
    {
        private string id;
        public string Id
        {
            get { return id; }
            set
            {
                id = value;
                RaisePropertyChanged();
            }
        }

        private string deptName;
        public string DeptName
        {
            get { return deptName; }
            set
            {
                deptName = value;
                RaisePropertyChanged();
            }
        }

    }

}
