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
    [Activity(Label = "Activity1")]
    public class Side_Act : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Side_Layout);
            Button thirdbutton = FindViewById<Button>(Resource.Id.thirdbutton);
            thirdbutton.Click += thirdbutton_Click;
        }

        private void thirdbutton_Click(object sender, EventArgs e)
        {
            Intent intentthird = new Intent(this, typeof(ThirdActivity));
            StartActivity(intentthird);
        }
    }
}