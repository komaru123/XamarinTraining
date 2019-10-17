using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DeviceOrientationServices
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            orientationButton.Clicked += OrientationButton_Clicked;
		}

        private void OrientationButton_Clicked(object sender, EventArgs e)
        {
            var orientation = DependencyService.Get<IDeviceOrientation>().GetOrientation();
            switch (orientation)
            {
                case DeviceOrientations.Undefined:
                    orient.Text = "Undefined";
                    break;
                case DeviceOrientations.Landscape:
                    orient.Text = "Landscape";
                    break;
                case DeviceOrientations.Portrait:
                    orient.Text = "Portrait";
                    break;
            }
        }
    }
}
