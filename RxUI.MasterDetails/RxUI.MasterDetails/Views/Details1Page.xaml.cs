using ReactiveUI;
using ReactiveUI.XamForms;
using RxUI.MasterDetails.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RxUI.MasterDetails.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Details1Page : ReactiveContentPage<Details1PageViewModel>
    {
		public Details1Page()
		{
			InitializeComponent ();
            this.WhenActivated(disposables =>
            {
                this.OneWayBind(ViewModel,
                    vm => vm.SomeProp,
                    vw => vw.LblName.Text,
                    p => p)
                .DisposeWith(disposables);
            });
        }
	}
}