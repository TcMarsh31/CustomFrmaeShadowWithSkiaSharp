using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CustomFrameWithSkia.CustomRenderer
{
    public partial class ShadowFrame : Grid
    {
        public ShadowFrame()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty OffsetXProperty =BindableProperty.Create("OffsetX", typeof(float), typeof(ShadowFrame), 0f, propertyChanged: OnOffsetXChanged);

        public static void OnOffsetXChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // Property changed implementation goes here
            var control = bindable as ShadowFrame;
            control.skiacontent.OffsetX = (float)newValue;
        }

        public float OffsetX
        {
            get { return (float)GetValue(OffsetXProperty); }
            set { SetValue(OffsetXProperty, value); }
        }

        //----------------------------------------------------------------------
        public static readonly BindableProperty OffsetYProperty = BindableProperty.Create("OffsetY", typeof(float), typeof(ShadowFrame), 0f, propertyChanged: OnOffsetYChanged);

        public static void OnOffsetYChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // Property changed implementation goes here
            var control = bindable as ShadowFrame;
            control.skiacontent.OffsetY = (float)newValue;
        }

        public float OffsetY
        {
            get { return (float)GetValue(OffsetYProperty); }
            set { SetValue(OffsetYProperty, value); }
        }


        //----------------------------------------------------------------------
        public static readonly BindableProperty BlurXProperty = BindableProperty.Create("BlurX", typeof(float), typeof(ShadowFrame), 0f, propertyChanged: OnBlurXChanged);

        public static void OnBlurXChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // Property changed implementation goes here
            var control = bindable as ShadowFrame;
            control.skiacontent.BlurX = (float)newValue;
        }

        public float BlurX
        {
            get { return (float)GetValue(BlurXProperty); }
            set { SetValue(BlurXProperty, value); }
        }

        //----------------------------------------------------------------------
        public static readonly BindableProperty BlurYProperty = BindableProperty.Create("BlurY", typeof(float), typeof(ShadowFrame), 0f, propertyChanged: OnBlurYChanged);

        public static void OnBlurYChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // Property changed implementation goes here
            var control = bindable as ShadowFrame;
            control.skiacontent.BlurY = (float)newValue;
        }

        public float BlurY
        {
            get { return (float)GetValue(BlurYProperty); }
            set { SetValue(BlurYProperty, value); }
        }



        //----------------------------------------------------------------------
        public static readonly BindableProperty RadiusProperty = BindableProperty.Create("Radius", typeof(int), typeof(ShadowFrame), 0,BindingMode.TwoWay, propertyChanged: OnRadiusChanged);

        public static void OnRadiusChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // Property changed implementation goes here
            var control = bindable as ShadowFrame;
            control.skiacontent.Radius = (int)newValue;
        }

        public int Radius
        {
            get { return (int)GetValue(RadiusProperty); }
            set { SetValue(RadiusProperty, value); }
        }

        //----------------------------------------------------------------------
        public static readonly BindableProperty ShadowColorProperty = BindableProperty.Create("ShadowColor", typeof(Color), typeof(ShadowFrame),null, BindingMode.TwoWay, propertyChanged: OnShadowColorChanged);

        public static void OnShadowColorChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // Property changed implementation goes here
            var control = bindable as ShadowFrame;
            control.skiacontent.ShadowColor = (Color)newValue;
        }

        public Color ShadowColor
        {
            get { return (Color)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }

        //----------------------------------------------------------------------
        public static readonly BindableProperty BackgroundRectColorProperty = BindableProperty.Create("BackGroundRectColor", typeof(Color), typeof(ShadowFrame), null, BindingMode.TwoWay, propertyChanged: OnBackgroundRectColorChanged);

        public static void OnBackgroundRectColorChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // Property changed implementation goes here
        }

        public Color BackGroundRectColor
        {
            get { return (Color)GetValue(BackgroundRectColorProperty); }
            set { SetValue(BackgroundRectColorProperty, value); }
        }


        //----------------------------------------------------------------------
        public static readonly BindableProperty ContentProperty = BindableProperty.Create("Content", typeof(View), typeof(ShadowFrame), null, BindingMode.TwoWay, propertyChanged: OnContentChanged);

        public static void OnContentChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // Property changed implementation goes here
            var control = bindable as ShadowFrame;
            control.content.Content = (View)newValue;
        }

        public View Content
        {
            get { return (View)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }


    }
}
