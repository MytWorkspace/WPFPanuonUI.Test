using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfUI.PanuonUI.Silver.ViewModel.Chart
{
    public class PieChartWindowVM : ViewModelBase
    {
        private ObservableCollection<double> pieDatas = new ObservableCollection<double>();
        /// <summary>
        /// 数据
        /// </summary>
        public ObservableCollection<double> PieDatas
        {
            get => pieDatas;
            set { pieDatas = value; RaisePropertyChanged(); }
        }
        private ObservableCollection<Color> pieForgrounds = new ObservableCollection<Color>();
        /// <summary>
        /// 颜色
        /// </summary>
        public ObservableCollection<Color> PieForgrounds
        {
            get => pieForgrounds;
            set { pieForgrounds = value; RaisePropertyChanged(); }
        }


        private ObservableCollection<string> pieTitles = new ObservableCollection<string>();
        /// <summary>
        /// 标题
        /// </summary>
        public ObservableCollection<string> PieTitles
        {
            get => pieTitles;
            set { pieTitles = value; RaisePropertyChanged(); }
        }

        private SolidColorBrush borderCorlor;
        /// <summary>
        /// 颜色
        /// </summary>
        public SolidColorBrush BorderCorlor
        {
            get => borderCorlor;
            set { borderCorlor = value; RaisePropertyChanged(); }
        }

        private PieChart2DModel pieChart2DTotalFaultStatistics = new PieChart2DModel();
        public PieChart2DModel PieChart2DTotalFaultStatistics
        {
            get
            {
                return pieChart2DTotalFaultStatistics;
            }
            set
            {
                pieChart2DTotalFaultStatistics = value;
                this.RaisePropertyChanged();
            }
        }


        public PieChartWindowVM()
        {
            PieDatas.Add(1);
            PieDatas.Add(2);
            PieDatas.Add(3);
            PieDatas.Add(7);
            PieDatas.Add(9);
            //PieDatas.Add(100);
            //PieDatas.Add(100);
            //PieDatas.Add(100);
            //PieDatas.Add(100);
            //PieDatas.Add(100);
            PieForgrounds.Add((Color)ColorConverter.ConvertFromString("#007DFF"));
            PieForgrounds.Add((Color)ColorConverter.ConvertFromString("#2ACD01"));
            PieForgrounds.Add((Color)ColorConverter.ConvertFromString("#5F7092"));
            PieForgrounds.Add((Color)ColorConverter.ConvertFromString("#F99100"));
            PieForgrounds.Add((Color)ColorConverter.ConvertFromString("#F24F4B"));

            BorderCorlor = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F24F4B"));

            PieTitles.Add("温度告警 1次(5%)");
            PieTitles.Add("主电故障 2次(9%)");
            PieTitles.Add("光猫电源故障 3次(14%)");
            PieTitles.Add("光纤LOS故障 7次(32%)");
            PieTitles.Add("摄像机网络故障 9次(41%)");

            PieChart2DTotalFaultStatistics.PieDatas = PieDatas;
            //PieChart2DTotalFaultStatistics.PieForgrounds = PieForgrounds;



            PieChart2DTotalFaultStatistics.PieForgrounds = PieChart2DTotalFaultStatistics.GetColor();

            PieChart2DTotalFaultStatistics.PieTitles = pieTitles;

            //初始化 列表数据

            PieChart2DTotalFaultStatistics.InitBottomListBox();
        }

        /// <summary>
        /// 传入string，得到Color
        /// </summary>
        /// <param name="colorStr"></param>
        /// <returns></returns>
        private Color StringToColor(string colorStr)//传入string，得到Color
        {
            Byte[] argb = new Byte[4];
            for (int i = 0; i < 4; i++)
            {
                char[] charArray = colorStr.Substring(i * 2 + 1, 2).ToCharArray();
                //string str = "11";
                Byte b1 = toByte(charArray[0]);
                Byte b2 = toByte(charArray[1]);
                argb[i] = (Byte)(b2 | (b1 << 4));
            }
            return Color.FromArgb(argb[0], argb[1], argb[2], argb[3]);//#FFFFFFFF
        }
        private static byte toByte(char c)
        {
            byte b = (byte)"0123456789ABCDEF".IndexOf(c);
            return b;
        }
    }


    public class PieChart2DModel : ViewModelBase
    {
        private ObservableCollection<double> pieDatas = new ObservableCollection<double>();
        /// <summary>
        /// 数据
        /// </summary>
        public ObservableCollection<double> PieDatas
        {
            get => pieDatas;
            set { pieDatas = value; RaisePropertyChanged(); }
        }
        private ObservableCollection<Color> pieForgrounds = new ObservableCollection<Color>();
        /// <summary>
        /// 颜色
        /// </summary>
        public ObservableCollection<Color> PieForgrounds
        {
            get => pieForgrounds;
            set { pieForgrounds = value; RaisePropertyChanged(); }
        }


        private ObservableCollection<string> pieTitles = new ObservableCollection<string>();
        /// <summary>
        /// 标题
        /// </summary>
        public ObservableCollection<string> PieTitles
        {
            get => pieTitles;
            set { pieTitles = value; RaisePropertyChanged(); }
        }

        public ObservableCollection<Color> GetColor()
        {

            ObservableCollection<Color> colors = new ObservableCollection<Color>();

            colors.Add((Color)System.Windows.Media.ColorConverter.ConvertFromString("#007DFF"));
            colors.Add((Color)System.Windows.Media.ColorConverter.ConvertFromString("#2ACD01"));
            colors.Add((Color)System.Windows.Media.ColorConverter.ConvertFromString("#5F7092"));
            colors.Add((Color)System.Windows.Media.ColorConverter.ConvertFromString("#F99100"));
            colors.Add((Color)System.Windows.Media.ColorConverter.ConvertFromString("#F24F4B"));

            return colors;
        }


        public void InitBottomListBox()
        {
            int i = 0;
            foreach (var item in PieTitles)
            {
                string title = item.Substring(0, item.IndexOf(" "));
                PieBottomDataModel pieBottomDataModel = new PieBottomDataModel();
                pieBottomDataModel.Title = title;

                pieBottomDataModel.Forground = new SolidColorBrush(PieForgrounds[i]);
                i++;
                PieBottomDataModels.Add(pieBottomDataModel);
            }
        }

        public ObservableCollection<PieBottomDataModel> pieBottomDataModels = new ObservableCollection<PieBottomDataModel>();

        public ObservableCollection<PieBottomDataModel> PieBottomDataModels
        {
            get => pieBottomDataModels;
            set { pieBottomDataModels = value; RaisePropertyChanged(); }
        }


    }
    public class PieBottomDataModel : ViewModelBase
    {
        private string title;
        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            get => title;
            set { title = value; RaisePropertyChanged(); }
        }

        private SolidColorBrush forground;
        /// <summary>
        /// 颜色
        /// </summary>
        public SolidColorBrush Forground
        {
            get => forground;
            set { forground = value; RaisePropertyChanged(); }
        }

    }

}
