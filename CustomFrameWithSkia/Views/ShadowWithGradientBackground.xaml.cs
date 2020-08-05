using System;
using System.Collections.Generic;
using CustomFrameWithSkia.ViewModels;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace CustomFrameWithSkia.Views
{
    public partial class ShadowWithGradientBackground : ContentPage
    {
        ShadowGradientViewModel shadowGradientViewModel;
        public ShadowWithGradientBackground()
        {
            shadowGradientViewModel = new ShadowGradientViewModel();
            InitializeComponent();
            BindingContext = shadowGradientViewModel;
        }

        void OffsetXSlider_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            shadowGradientViewModel.OffsetX = (float)e.NewValue;
        }

        void OffsetYSlider_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            shadowGradientViewModel.OffsetY = (float)e.NewValue;
        }

        void SigmaXSlider_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            shadowGradientViewModel.BlurX = (float)e.NewValue;
        }

        void SigmaYSlider_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            shadowGradientViewModel.BlurY = (float)e.NewValue;
        }

        void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            using (SKPaint paint = new SKPaint())
            {
                // Create gradient for background
                paint.Shader = SKShader.CreateLinearGradient(
                                    new SKPoint(0, 0),
                                    new SKPoint(info.Width, info.Height),
                                    new SKColor[] { new SKColor(0x40, 0x40, 0x40),
                                                    new SKColor(0xC0, 0xC0, 0xC0) },
                                    null,
                                    SKShaderTileMode.Clamp);

                // Draw background
                canvas.DrawRect(info.Rect, paint);

                // Set TextSize to fill 90% of width
                paint.TextSize = 100;
                float width = paint.MeasureText("");
                float scale = 0.9f * info.Width / width;
                paint.TextSize *= scale;

                // Get text bounds
                SKRect textBounds = new SKRect();
                paint.MeasureText("", ref textBounds);

                // Calculate offsets to center the text on the screen
                float xText = info.Width / 2 - textBounds.MidX;
                float yText = info.Height / 2 - textBounds.MidY;

                // Shift textBounds by that amount
                textBounds.Offset(xText, yText);

                // Create gradient for text
                paint.Shader = SKShader.CreateLinearGradient(
                                    new SKPoint(textBounds.Left, textBounds.Top),
                                    new SKPoint(textBounds.Right, textBounds.Bottom),
                                    new SKColor[] { new SKColor(0x40, 0x40, 0x40),
                                                    new SKColor(0xC0, 0xC0, 0xC0) },
                                    null,
                                    SKShaderTileMode.Clamp);

            }
        }
    }
}
