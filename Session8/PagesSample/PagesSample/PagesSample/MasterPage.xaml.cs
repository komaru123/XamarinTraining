using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PagesSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterPage : MasterDetailPage
    {
        public MasterPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new HomePage());
            IsPresented = false;
            add.Clicked += Add_Clicked;
            controltemplate.Clicked += ControlTemplate_Clicked;
            carouselpg.Clicked += Carousel_Clicked;
            tabbed.Clicked += Tabbed_Clicked;
        }

        private void Tabbed_Clicked(object sender, EventArgs e)
        {

            Detail = new NavigationPage(new Tabbed());
            IsPresented = false;
        }

        private void Carousel_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new CarouselPages());
            IsPresented = false;
        }

        private void ControlTemplate_Clicked(object sender, EventArgs e)
        {

            Detail = new NavigationPage(new ControlTemplatePages());
            IsPresented = false;
        }

        private void Add_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AddEmployee());
            IsPresented = false;
        }

       
    }
}
