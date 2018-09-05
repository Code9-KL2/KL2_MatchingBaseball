using Android.App;
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
            
            Button start = FindViewById<Button>(Resource.Id.start);
            Button help = FindViewById<Button>(Resource.Id.help);

            start.Click += start_Click;
            help.Click += help_Click;
        }

        private void start_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Side_Act));
            StartActivity(intent);
        }
        private void help_Click(object sender1, EventArgs a)
        {
            Intent intent1 = new Intent(this, typeof(Help_Activity));
            StartActivity(intent1);
        }
    }
}

