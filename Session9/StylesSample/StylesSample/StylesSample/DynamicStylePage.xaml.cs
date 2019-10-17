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
	public partial class DynamicStylePage : ContentPage
	{
        bool originalStyle = true;
        public DynamicStylePage ()
		{
			InitializeComponent ();
            Resources["labelStyle"] = Resources["pinkLabelStyle"];
            Resources["entryStyle"] = Resources["blueEntryStyle"];
        }
        void OnButtonClicked(object sender, EventArgs e)
        {
            if (originalStyle)
            {
                Resources["entryStyle"] = Resources["greenEntryStyle"];
                Resources["labelStyle"] = Resources["blackLabelStyle"];
                originalStyle = false;
            }
            else
            {
                Resources["labelStyle"] = Resources["pinkLabelStyle"];
                Resources["entryStyle"] = Resources["blueEntryStyle"];
                originalStyle = true;
            }
        }
    }
}