﻿using System;
using Xamarin.Forms;
using RxUI.MasterDetails.Views;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace RxUI.MasterDetails
{
	public partial class App : Application
	{
		
		public App ()
		{
			InitializeComponent();
            var bs = new AppBootstrapper();
            MainPage = bs.CreateMainPage();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
