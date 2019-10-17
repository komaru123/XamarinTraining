using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ViewControlsSample
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();


            //MainPage = new TabbedPage()
            //{
            //    Children =
            //    {
            //        new MapsPage(),
            //        new PinPage(),
            //        new MapsApi()

            //    }
            //};

            MainPage = new ViewControlsSample.MainPage();
            //MainPage = new ViewControlsSample.MapsPage();
           // MainPage = new ViewControlsSample.PinPage();
           // MainPage = new ViewControlsSample.MapsApi();
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
