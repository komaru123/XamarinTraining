using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ViewControlsSample
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            rotatingImage.Source = ImageSource.FromResource("ViewControlsSample.embed.ic_map.png");
            
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await MainProgressBar.ProgressTo(0.9, 9000, Easing.Linear);
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;
            rotatingImage.Rotation = value;
            rotationInfo.Text = String.Format("The Slider value is {0}", value);
        }


    }
}
