using ReactiveUI;
using ReactiveUI.XamForms;
using RxUI.MasterDetails.ViewModels;
using RxUI.MasterDetails.Views;
using Splat;
using System;
using Xamarin.Forms;
namespace RxUI.MasterDetails
{
    public class AppBootstrapper : ReactiveObject, IScreen
    {
        public RoutingState Router { get; protected set; }

        public AppBootstrapper()
        {
            Router = new RoutingState();
            Locator.CurrentMutable.RegisterConstant(this, typeof(IScreen));

            RegisterViewModels();

            this.Router.NavigateAndReset.Execute(new MainPageViewModel()).Subscribe();
        }

        private void RegisterViewModels()
        {
            Locator.CurrentMutable.Register(
                () => new MainPage(), typeof(IViewFor<MainPageViewModel>));
            Locator.CurrentMutable.Register(
                () => new Details1Page(), typeof(IViewFor<Details1PageViewModel>));
            Locator.CurrentMutable.Register(
                () => new Details1Page(), typeof(IViewFor<Details2PageViewModel>));
        }

        public Page CreateMainPage()
        {
            return new RoutedViewHost();
        }
    }
}
