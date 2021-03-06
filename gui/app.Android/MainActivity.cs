﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

// using Com.Xamarin.Textcounter;

//using Com.Bsgamesdk.android.BSGameSdk;
//using Com.Bsgamesdk.android.callbacklistener.AccountCallBackListener;
//using Com.Bsgamesdk.android.callbacklistener.BSGameSdkError;
//using Com.Bsgamesdk.android.callbacklistener.CallbackListener;
//using Com.Bsgamesdk.android.callbacklistener.ExitCallbackListener;
//using Com.Bsgamesdk.android.callbacklistener.OrderCallbackListener;
//using Com.Bsgamesdk.android.callbacklistener.InitCallbackListener;


namespace app.Droid
{
    [Activity(Label = "app", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = app.Droid.Resource.Layout.Tabbar;
            ToolbarResource = app.Droid.Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());

            //var stream = Android.App.Application.Context.Assets.Open("file/in/assets/path");
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}