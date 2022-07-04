using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfUI.PanuonUI.Silver.ViewModel.Chart;

namespace WpfUI.PanuonUI.Silver.ViewModel
{
    public class ViewModelLocator
    {

        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<PieChartWindowVM>();

        }

        public PieChartWindowVM PieChartWindowVM => SimpleIoc.Default.GetInstanceWithoutCaching<PieChartWindowVM>();

    }
}
