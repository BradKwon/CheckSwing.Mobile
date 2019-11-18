﻿using Android.App;
using Android.OS;

namespace CheckSwing.Droid
{
    [Activity(Theme = "@style/splash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            StartActivity(typeof(MainActivity));
        }
    }
}
