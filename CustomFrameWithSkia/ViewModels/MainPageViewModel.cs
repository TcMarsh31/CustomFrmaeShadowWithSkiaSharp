using System;
using System.ComponentModel;

namespace CustomFrameWithSkia.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            OffsetX = 0;
            OffsetY = 0;
            BlurX = 0;
            BlurY = 0;
        }

        private float offsetX;

        public float OffsetX
        {
            get => offsetX;
            set
            {
                offsetX = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(OffsetX)));
            }
        }

        private float offsetY;

        public float OffsetY
        {
            get => offsetY;
            set
            {
                offsetY = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(OffsetY)));
            }
        }


        private float blurX;

        public float BlurX
        {
            get => blurX;
            set
            {
                blurX = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(BlurX)));
            }
        }

        private float blurY;

        public float BlurY
        {
            get => blurY;
            set
            {
                blurY = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(BlurY)));
            }
        }








        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(this, eventArgs);
        }
    }
}
