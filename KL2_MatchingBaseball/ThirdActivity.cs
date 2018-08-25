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
    [Activity(Label = "ThirdActivity")]
    public class ThirdActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Random random = new Random();
            for (int i = 1; i <= 3; i++)
            {
                int RandomNum = random.Next(0, 9);
            }
            
            FindViewById(Resource.Id.button1);
            FindViewById(Resource.Id.button2);
            FindViewById(Resource.Id.button3);
            FindViewById(Resource.Id.button4);
            FindViewById(Resource.Id.button5);
            FindViewById(Resource.Id.button6);
            FindViewById(Resource.Id.button7);
            FindViewById(Resource.Id.button8);
            FindViewById(Resource.Id.button9);
            FindViewById(Resource.Id.button0);
            FindViewById(Resource.Id.buttonEnter);
            FindViewById(Resource.Id.buttonX);
            Button button1 = FindViewById<Button>(Resource.Id.button1);
            Button button2 = FindViewById<Button>(Resource.Id.button2);
            Button button3 = FindViewById<Button>(Resource.Id.button3);
            Button button4 = FindViewById<Button>(Resource.Id.button4);
            Button button5 = FindViewById<Button>(Resource.Id.button5);
            Button button6 = FindViewById<Button>(Resource.Id.button6);
            Button button7 = FindViewById<Button>(Resource.Id.button7);
            Button button8 = FindViewById<Button>(Resource.Id.button8);
            Button button9 = FindViewById<Button>(Resource.Id.button9);
            Button button0 = FindViewById<Button>(Resource.Id.button0);
            // Create your application here
            SetContentView(Resource.Layout.SideAct3_Layout);

        }
    }
}