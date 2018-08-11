using ReactiveUI.XamForms;
using RxUI.MasterDetails.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RxUI.MasterDetails.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Details2Page : ReactiveContentPage<Details2PageViewModel>
    {
		public Details2Page()
		{
			InitializeComponent ();
		}
	}
}