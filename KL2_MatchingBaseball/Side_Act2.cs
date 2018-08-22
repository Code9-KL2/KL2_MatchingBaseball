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
    [Activity(Label = "Side_Act2")]
    public class Side_Act2 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Side_Layout2);
            for(int i = 0; i < 3;i++)
            {

            }
            Random random = new Random();
            int n = random.Next(0, 9);
            string number = Convert.ToString(n);
            
            
        }
    }
}