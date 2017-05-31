using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace TutorialXL
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void BtnSecond_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new SecondPage();
        }

        protected override void OnAppearing()
        {
            DisplayAlert("Hello", "This is my main page", "Ok");
            base.OnAppearing();
        }
    }
}
