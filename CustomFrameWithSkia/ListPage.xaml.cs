using System;
using System.Collections.Generic;
using CustomFrameWithSkia.Views;
using Xamarin.Forms;

namespace CustomFrameWithSkia
{
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
        }

        async void ListView_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            if (e.ItemIndex == 0)
            {
                await Navigation.PushAsync(new MainPage()); 
            }else if (e.ItemIndex == 1)
            {
                await Navigation.PushAsync(new ImageShadow());

            }
            else if (e.ItemIndex == 2)
            {
                await Navigation.PushAsync(new ShadowWithGradientBackground());
            }
        }
    }
}
