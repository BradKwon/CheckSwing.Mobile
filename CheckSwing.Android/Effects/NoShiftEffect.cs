using Android.Support.Design.BottomNavigation;
using Android.Support.Design.Widget;
using Android.Views;
using CheckSwing.Droid.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("CheckSwing")]
[assembly: ExportEffect(typeof(NoShiftEffect), "NoShiftEffect")]
namespace CheckSwing.Droid.Effects
{
    public class NoShiftEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            if (!(Container.GetChildAt(0) is ViewGroup layout))
                return;

            if (!(layout.GetChildAt(1) is BottomNavigationView bottomNavigationView))
                return;

            bottomNavigationView.LabelVisibilityMode = LabelVisibilityMode.LabelVisibilityUnlabeled;
        }

        protected override void OnDetached()
        {
        }
    }
}
