using System;
using System.Collections.Generic;
using CustomFrameWithSkia.ViewModels;
using Xamarin.Forms;

namespace CustomFrameWithSkia.Views
{
    public partial class ImageShadow : ContentPage
    {
        ImageShadowViewModel imageShadowViewModel;
        public ImageShadow()
        {
            imageShadowViewModel = new ImageShadowViewModel();
            InitializeComponent();
            BindingContext = imageShadowViewModel;

        }

        void OffsetXSlider_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            imageShadowViewModel.OffsetX = (float)e.NewValue;
        }

        void OffsetYSlider_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            imageShadowViewModel.OffsetY = (float)e.NewValue;
        }

        void SigmaXSlider_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            imageShadowViewModel.BlurX = (float)e.NewValue;
        }

        void SigmaYSlider_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            imageShadowViewModel.BlurY = (float)e.NewValue;
        }
    }
}
