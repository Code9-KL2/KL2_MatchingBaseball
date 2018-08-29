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

            Random random = new Random();
            int n = random.Next(0,  9);
            int n1 = random.Next(0, 9);
            int n2 = random.Next(0, 9);
            string number = Convert.ToString(n);
            string number1 = Convert.ToString(n1);
            string number2 = Convert.ToString(n2);

            string main_number = number + number1 + number2;

            Button btn0 = FindViewById<Button>(Resource.Id.btn0);
            Button btn1 = FindViewById<Button>(Resource.Id.btn1);
            Button btn2 = FindViewById<Button>(Resource.Id.btn2);
            Button btn3 = FindViewById<Button>(Resource.Id.btn3);
            Button btn4 = FindViewById<Button>(Resource.Id.btn4);
            Button btn5 = FindViewById<Button>(Resource.Id.btn5);
            Button btn6 = FindViewById<Button>(Resource.Id.btn6);
            Button btn7 = FindViewById<Button>(Resource.Id.btn7);
            Button btn8 = FindViewById<Button>(Resource.Id.btn8);
            Button btn9 = FindViewById<Button>(Resource.Id.btn9);

            btn0.Click += btn0_Click;
            btn1.Click += btn1_Click;
            btn2.Click += btn2_Click;
            btn3.Click += btn3_Click;
            btn4.Click += btn4_Click;
            btn5.Click += btn5_Click;
            btn6.Click += btn6_Click;
            btn7.Click += btn7_Click;
            btn8.Click += btn8_Click;
            btn9.Click += btn9_Click;



        }

        int Count = 0;

        int User_Input;
        int Number_F;
        int Number_M;
        int Number_L;

        private void btn9_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {
 
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {   
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
 
        }

        private void btn0_Click(object sender, EventArgs e)
        {

        }
    }
}