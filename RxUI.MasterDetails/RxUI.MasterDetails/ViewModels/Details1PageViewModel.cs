using ReactiveUI;
using ReactiveUI.XamForms;

using System;
using System.Collections.Generic;
using System.Reactive.Disposables;
using System.Reactive.Subjects;
using System.Text;
namespace RxUI.MasterDetails.ViewModels
{
    public class Details1PageViewModel : ReactiveObject, ISupportsActivation
    {
        ObservableAsPropertyHelper<string> _someProp;
        public string SomeProp => _someProp.Value;

        public ViewModelActivator Activator { get; } = new ViewModelActivator();

        public Details1PageViewModel()
        {
            var sub = new Subject<string>();
            this.WhenActivated((disposables) =>
            {
                _someProp = sub
                    .ToProperty(this, x => x.SomeProp).DisposeWith(disposables);

                sub.OnNext("Test from details 1 View model");
            });
        }
    }
}
