using Caliburn.Micro;
using PlannerInterface.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerInterface.ViewModels
{
    public class HomeViewModel : Conductor<HomeView>
    {
        public HomeViewModel()
        {
            DisplayName = "Meu Planner";
        }
    }
}
