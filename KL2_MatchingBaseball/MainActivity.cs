﻿using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using System;
using Android.Content;

namespace KL2_MatchingBaseball
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            
            Button btn1 = FindViewById<Button>(Resource.Id.btn1);

            btn1.Click += Btn1_Click;
            Button btn2 = FindViewById<Button>(Resource.Id.btn2);
            btn2.Click += Btn2_Click;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Side_Act));
            StartActivity(intent);
        }
        private void Btn2_Click(object sender1, EventArgs a)
        {
            Intent intent1 = new Intent(this, typeof(Help_Activity));
            StartActivity(intent1);
        }
    }
}

