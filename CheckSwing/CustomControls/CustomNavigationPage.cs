using CheckSwing.Enums.NavigationPage;
using Xamarin.Forms;

namespace CheckSwing.CustomControls
{
    public class CustomNavigationPage : NavigationPage
    {
        public CustomNavigationPage() : base() { }
        public CustomNavigationPage(Page page) : base(page) { }

        public static readonly BindableProperty TitleFontFamilyProperty = BindableProperty.Create("TitleFontFamily", typeof(string), typeof(NavigationPage), default(string));
        public static readonly BindableProperty TitleFontSizeProperty = BindableProperty.Create("TitleFontSize", typeof(float), typeof(NavigationPage), default(float));
        public static readonly BindableProperty TitleHorizontalAlignmentProperty = BindableProperty.Create("TitleHorizontalAlignment", typeof(HorizontalAlignmentEnum), typeof(NavigationPage), default(HorizontalAlignmentEnum));
        public static readonly BindableProperty TitleFontAttributesProperty = BindableProperty.Create("TitleFontAttributes", typeof(FontAttributesEnum), typeof(NavigationPage), default(FontAttributesEnum));

        public HorizontalAlignmentEnum TitleHorizontalAlignment
        {
            get { return (HorizontalAlignmentEnum)GetValue(TitleHorizontalAlignmentProperty); }
            set { SetValue(TitleHorizontalAlignmentProperty, value); }
        }

        public float TitleFontSize
        {
            get { return (float)GetValue(TitleFontSizeProperty); }
            set { SetValue(TitleFontSizeProperty, value); }
        }

        public string TitleFontFamily
        {
            get { return (string)GetValue(TitleFontFamilyProperty); }
            set { SetValue(TitleFontFamilyProperty, value); }
        }

        public FontAttributesEnum TitleFontAttributes
        {
            get { return (FontAttributesEnum)GetValue(TitleFontAttributesProperty); }
            set { SetValue(TitleFontAttributesProperty, value); }
        }
    }
}
