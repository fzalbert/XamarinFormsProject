﻿using System;
using Xamarin.Forms;
using XamarinProjectSimple.Views;
using Xamarin.Forms.Xaml;
using XamarinProjectSimple.Views.Authorization;
using XamarinProjectSimple.Services.Authorization;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace XamarinProjectSimple
{
	public partial class App : Application
	{
		
		public App ()
		{
			InitializeComponent();

            IAuthService auth = new AuthService();

            if (auth.IsAuthorized) MainPage = new MainPage();

            else MainPage = new AuthPage();
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
