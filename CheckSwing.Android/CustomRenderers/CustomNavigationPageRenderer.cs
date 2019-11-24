using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Android.Content;
using Android.Graphics;
using Android.Runtime;
using Android.Widget;
using CheckSwing.CustomControls;
using CheckSwing.Droid.CustomRenderers;
using CheckSwing.Enums.NavigationPage;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android.AppCompat;
using CompatWidget = Android.Support.V7.Widget;

[assembly: ExportRenderer(typeof(CustomNavigationPage), typeof(CustomNavigationPageRenderer))]
namespace CheckSwing.Droid.CustomRenderers
{
    public class CustomNavigationPageRenderer : NavigationPageRenderer
    {
        #region Properties
        CompatWidget.Toolbar toolbar;
        Page view;
        string FontFamily = string.Empty;
        float TitleFontSize = 0;
        HorizontalAlignmentEnum TitleHorizontalAlignment = HorizontalAlignmentEnum.Left;
        FontAttributesEnum TitleFontAttributes = FontAttributesEnum.Normal;
        #endregion

        public CustomNavigationPageRenderer() : base() { }
        public CustomNavigationPageRenderer(Context context) : base(context) { }
        public CustomNavigationPageRenderer(IntPtr a, JniHandleOwnership b) : base() { }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            var page = sender as CustomNavigationPage;
            FontFamily = page.TitleFontFamily;
            TitleHorizontalAlignment = page.TitleHorizontalAlignment;
            TitleFontAttributes = page.TitleFontAttributes;
            TitleFontSize = page.TitleFontSize;
        }

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            base.OnLayout(changed, l, t, r, b);

            SetTitle();
        }

        protected override Task<bool> OnPushAsync(Page view, bool animated)
        {
            var retVal = base.OnPushAsync(view, animated);
            this.view = view;
            return retVal;
        }

        protected override Task<bool> OnPopToRootAsync(Page page, bool animated)
        {
            var retVal = base.OnPopToRootAsync(page, animated);
            view = page;
            return retVal;
        }

        protected override Task<bool> OnPopViewAsync(Page page, bool animated)
        {
            var retVal = base.OnPopViewAsync(page, animated);
            view = page;
            return retVal;
        }

        CompatWidget.Toolbar GetToolbar()
        {
            if (toolbar == null)
            {
                for (var i = 0; i < this.ChildCount; i++)
                {
                    var child = GetChildAt(i);
                    if (child is CompatWidget.Toolbar childToolbar)
                    {
                        toolbar = childToolbar;
                    }
                }
            }
            return toolbar;
        }

        void SetTitle()
        {
            if (GetToolbar() != null)
            {
                for (var i = 0; i < toolbar.ChildCount; i++)
                {
                    var Title = toolbar.GetChildAt(i);
                    if (Title is TextView title)
                    {
                        if (TitleHorizontalAlignment == HorizontalAlignmentEnum.Center)
                        {
                            float toolbarCenter = toolbar.Width / 2;
                            float titleCenter = title.Width / 2;
                            title.SetX(toolbarCenter - titleCenter);
                        }

                        if (!string.IsNullOrWhiteSpace(FontFamily))
                        {
                            var typeface = Typeface.Create(FontFamily, ConvertFontAttributesToTypefaceStyle(TitleFontAttributes));
                            title.Typeface = typeface;
                        }

                        if (TitleFontSize != 0)
                        {
                            title.TextSize = TitleFontSize;
                        }
                    }
                }
            }
        }

        TypefaceStyle ConvertFontAttributesToTypefaceStyle(FontAttributesEnum fontAttributes)
        {
            if (fontAttributes == FontAttributesEnum.Bold) return TypefaceStyle.Bold;
            if (fontAttributes == FontAttributesEnum.BoldItalic) return TypefaceStyle.BoldItalic;
            if (fontAttributes == FontAttributesEnum.Italic) return TypefaceStyle.Italic;

            return TypefaceStyle.Normal;
        }
    }
}
