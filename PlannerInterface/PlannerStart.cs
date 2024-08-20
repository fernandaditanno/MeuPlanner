using Caliburn.Micro;
using PlannerInterface.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PlannerInterface
{
    public class PlannerStart : BootstrapperBase
    {
        public PlannerStart()
        {
            Initialize();
        }
        protected override async void OnStartup(object sender, StartupEventArgs e)
        {
            await DisplayRootViewForAsync(typeof(HomeViewModel));
        }
    }
}
