using System;

using Xamarin.Forms;

namespace WAHtton
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void OnButtonClicked(object sender, EventArgs args)
        {
            DependencyService.Get<IButtonClick>().ButtonClicked();
            //btnWah.Text = "Clicked WAH!";      
        }
    }
}
