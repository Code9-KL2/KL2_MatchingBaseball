using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace KL2_MatchingBaseball
{
    [Activity(Label = "Side_Act")]
    public class Side_Act : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Side_Layout);
            Button Three_Number = FindViewById<Button>(Resource.Id.thirdbutton);
            Button Four_Number = FindViewById<Button>(Resource.Id.button3);

            Four_Number.Click += Four_Number_Click;
            Three_Number.Click += Three_Number_Click;
        }

        private void Three_Number_Click(object sender, EventArgs e)
        {
            Intent intent3 = new Intent(this, typeof(ThirdActivity));
            StartActivity(intent3);
        }

        private void Four_Number_Click(object sender, EventArgs e)
        {
            Intent intent2 = new Intent(this, typeof(Side_Act2));
            StartActivity(intent2);
        }
    }
}