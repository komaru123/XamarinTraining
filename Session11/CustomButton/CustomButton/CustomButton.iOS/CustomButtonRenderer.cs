using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomButton;
using CustomButton.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomButtons), typeof(CustomButtonRenderer))]
namespace CustomButton.iOS
{
    class CustomButtonRenderer:ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // do whatever you want to the UITextField here!
                Control.BackgroundColor = UIColor.FromRGB(204, 153, 255);
              
            }
        }
    }
}