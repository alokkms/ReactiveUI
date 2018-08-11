using ReactiveUI.XamForms;
using RxUI.MasterDetails.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RxUI.MasterDetails.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ReactiveMasterDetailPage<MainPageViewModel>
    {
		public MainPage ()
		{
			InitializeComponent ();
		}
	}
}