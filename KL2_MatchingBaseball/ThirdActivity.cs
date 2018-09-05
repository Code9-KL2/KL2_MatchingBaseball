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
        TextView textview;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SideAct3_Layout);

            Random random = new Random();
            for (int i = 1; i <= 3; i++)
            {
                int RandomNum = random.Next(0, 9);
            }


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
            textview = FindViewById<TextView>(Resource.Id.textview);
            button0.Click += Button0_Click;
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
            button4.Click += Button4_Click;
            button5.Click += Button5_Click;
            button6.Click += Button6_Click;
            button7.Click += Button7_Click;
            button8.Click += Button8_Click;
            button9.Click += Button9_Click;












            // Create your application here

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textview.Text = "9";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textview.Text = "8";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textview.Text = "7";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textview.Text = "6";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textview.Text = "5";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textview.Text = "4";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textview.Text = "3";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textview.Text = "2";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textview.Text = "1";
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            textview.Text = "0";
        }
        
    }
}