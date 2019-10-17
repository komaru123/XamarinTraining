using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamlSamples
{
	public partial class MainPage : MasterDetailPage
	{
		public MainPage()
		{
			InitializeComponent();
            Detail = new NavigationPage(new HomePage());
            IsPresented = false;
            statics.Clicked += Statics_Clicked;
            reference.Clicked += Reference_Clicked;
            array.Clicked += Array_Clicked;
            nulls.Clicked += Nulls_Clicked;
            //hslcolor.Clicked += Hslcolor_Clicked;
            //imgresource.Clicked += Imgresource_Clicked;

        }

        private void Nulls_Clicked(object sender, EventArgs e)
        {
            IsPresented = false;
            Detail = new NavigationPage(new NullDemo());
        }
        //private void Hslcolor_Clicked(object sender, EventArgs e)
        //{
        //    IsPresented = false;
        //    Detail = new NavigationPage(new HslColorDemo());
        //}
        //private void Imgresource_Clicked(object sender, EventArgs e)
        //{
        //    IsPresented = false;
        //    Detail = new NavigationPage(new ImageResourceDemo());
        //}

        private void Array_Clicked(object sender, EventArgs e)
        {
            IsPresented = false;
            Detail = new NavigationPage(new ArrayDemo());
        }
    

        private void Reference_Clicked(object sender, EventArgs e)
        {
            IsPresented = false;
            Detail = new NavigationPage(new ReferenceDemo());
        }

        private void Statics_Clicked(object sender, EventArgs e)
        {
            IsPresented = false;
            Detail = new NavigationPage(new StaticDemo());
        }
    }
}
