using System;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace CustomFrameWithSkia.CustomRenderer
{
    public class CustomFrame : SKCanvasView
    {
        public static readonly BindableProperty OffsetXProperty = BindableProperty.Create("OffsetX", typeof(float), typeof(CustomFrame), 0f, propertyChanged: OnOffsetXChanged);

        public static void OnOffsetXChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // Property changed implementation goes here
            var control = bindable as CustomFrame;
            control?.InvalidateSurface();
        }

        public float OffsetX
        {
            get { return (float)GetValue(OffsetXProperty); }
            set { SetValue(OffsetXProperty, value); }
        }

        //----------------------------------------------------------------------
        public static readonly BindableProperty OffsetYProperty = BindableProperty.Create("OffsetY", typeof(float), typeof(CustomFrame), 0f, propertyChanged: OnOffsetYChanged);

        public static void OnOffsetYChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // Property changed implementation goes here
            var control = bindable as CustomFrame;
            control?.InvalidateSurface();
        }

        public float OffsetY
        {
            get { return (float)GetValue(OffsetYProperty); }
            set { SetValue(OffsetYProperty, value); }
        }


        //----------------------------------------------------------------------
        public static readonly BindableProperty BlurXProperty = BindableProperty.Create("BlurX", typeof(float), typeof(CustomFrame), 0f, propertyChanged: OnBlurXChanged);

        public static void OnBlurXChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // Property changed implementation goes here
            var control = bindable as CustomFrame;
            control?.InvalidateSurface();
        }

        public float BlurX
        {
            get { return (float)GetValue(BlurXProperty); }
            set { SetValue(BlurXProperty, value); }
        }

        //----------------------------------------------------------------------
        public static readonly BindableProperty BlurYProperty = BindableProperty.Create("BlurY", typeof(float), typeof(CustomFrame), 0f, propertyChanged: OnBlurYChanged);

        public static void OnBlurYChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // Property changed implementation goes here
            var control = bindable as CustomFrame;
            control?.InvalidateSurface();
        }

        public float BlurY
        {
            get { return (float)GetValue(BlurYProperty); }
            set { SetValue(BlurYProperty, value); }
        }



        //----------------------------------------------------------------------
        public static readonly BindableProperty RadiusProperty = BindableProperty.Create("Radius", typeof(int), typeof(CustomFrame), 0, BindingMode.TwoWay, propertyChanged: OnRadiusChanged);

        public static void OnRadiusChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // Property changed implementation goes here
            var control = bindable as CustomFrame;
            control?.InvalidateSurface();
        }

        public int Radius
        {
            get { return (int)GetValue(RadiusProperty); }
            set { SetValue(RadiusProperty, value); }
        }

        //----------------------------------------------------------------------
        public static readonly BindableProperty ShadowColorProperty = BindableProperty.Create("ShadowColor", typeof(Color), typeof(ShadowFrame), null, BindingMode.TwoWay, propertyChanged: OnShadowColorChanged);

        public static void OnShadowColorChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // Property changed implementation goes here
            var control = bindable as CustomFrame;
            control?.InvalidateSurface();
        }

        public Color ShadowColor
        {
            get { return (Color)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }

        protected override void OnPaintSurface(SKPaintSurfaceEventArgs args)
        {
            base.OnPaintSurface(args);

            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();
            canvas.Save();
            
            using (SKPaint paint = new SKPaint())
            {
                // Set SKPaint properties
                paint.Color = SKColors.White;
                paint.ImageFilter = SKImageFilter.CreateDropShadow(
                                        OffsetX,
                                        OffsetY,
                                        BlurX,
                                        BlurY,
                                        ShadowColor.ToSKColor(),
                                        SKDropShadowImageFilterShadowMode.DrawShadowAndForeground);

                canvas.DrawRoundRect(new SKRect(20f, 20f, info.Width-20 , info.Height-20),Radius,Radius, paint);

                canvas.Restore();
            }
        }
    }

}