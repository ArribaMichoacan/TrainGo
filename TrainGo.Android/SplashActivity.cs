﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainGo.Droid
{
    [Activity(Label = "TrainGo", Theme = "@style/SplashTheme",
        MainLauncher = true, NoHistory = true, ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //iniciar actividad, desplegar splashScreen

            //StartActivity(new Intent(Application.Context, typeof(MainActivity)));

            // Create your application here
        }

        protected override async void OnResume()
        {
            base.OnResume();
            await SimulateStartUp();
        }

        private async Task SimulateStartUp()
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }


    }
}