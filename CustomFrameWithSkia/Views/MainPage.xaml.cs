using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomFrameWithSkia.ViewModels;
using Xamarin.Forms;

namespace CustomFrameWithSkia.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        MainPageViewModel mainPageViewModel;
        public MainPage()
        {
            mainPageViewModel = new MainPageViewModel();
            InitializeComponent();

            BindingContext = mainPageViewModel;
        }

        void OffsetXSlider_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            mainPageViewModel.OffsetX = (float)e.NewValue;
        }

        void OffsetYSlider_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            mainPageViewModel.OffsetY = (float)e.NewValue;
        }

        void SigmaXSlider_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            mainPageViewModel.BlurX = (float)e.NewValue;
        }

        void SigmaYSlider_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            mainPageViewModel.BlurY = (float)e.NewValue;
        }
    }
}
