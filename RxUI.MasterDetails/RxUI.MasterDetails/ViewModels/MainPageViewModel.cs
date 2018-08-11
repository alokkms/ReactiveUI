using ReactiveUI;
using Splat;
using System;
using System.Collections.Generic;
using System.Text;

namespace RxUI.MasterDetails.ViewModels
{
    public class MainPageViewModel : ReactiveObject, IRoutableViewModel
    {
        public string UrlPathSegment
        {
            get;
            protected set;
        }

        public IScreen HostScreen
        {
            get;
            protected set;
        }

        public MainPageViewModel()
        {
            HostScreen = Locator.Current.GetService<IScreen>();
        }
    }
}
