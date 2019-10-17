using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StylesSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImplicitStylePage : ContentPage
	{
        bool continueTimer;
        public ImplicitStylePage ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        {
            continueTimer = true;
            Device.StartTimer(TimeSpan.FromSeconds(1),
                () => {
                    Resources["currentDateTime"] = DateTime.Now.ToString();
                    return continueTimer;
                });
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            continueTimer = false;
            base.OnDisappearing();
        }
    }
}