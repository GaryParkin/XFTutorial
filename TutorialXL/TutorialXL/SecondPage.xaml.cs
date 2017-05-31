using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TutorialXL
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SecondPage : ContentPage
	{
		public SecondPage ()
		{
			InitializeComponent ();
		}
        protected override bool OnBackButtonPressed()
        {
            App.Current.MainPage = new MainPage();
            
            // This traps the back button so it won't leave the app
            //  unless it's tapped on the main page.
            return true; // base.OnBackButtonPressed();
        }
    }
}