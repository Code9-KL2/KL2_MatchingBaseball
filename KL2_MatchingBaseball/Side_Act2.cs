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
            int n = random.Next(0, 9);
            int n1 = random.Next(0, 9);
            int n2 = random.Next(0, 9);
            int n3 = random.Next(0, 9);

            string n_string = Convert.ToString(n);
            string n1_string = Convert.ToString(n1);
            string n2_string = Convert.ToString(n2);
            string n3_string = Convert.ToString(n3);

            string Answer = n_string + n1_string + n2_string + n3_string;

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
            Button Enter = FindViewById<Button>(Resource.Id.Enter);

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
            Enter.Click += Enter_Click;



        }
        int Count = 0;
        string User_Input1;
        string User_Input2;
        string User_Input3;
        string User_Input4;

        private void Enter_Click(object sender, EventArgs e)
        {
            string User_Answer = User_Input1 + User_Input2 + User_Input3 + User_Input4;
            if (Answer == )

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (Count == 0)
            {
                User_Input1 = "9";
            }
            else if (Count == 1)
            {
                User_Input2 = "9";
            }
            else if (Count == 2)
            {
                User_Input3 = "9";
            }
            else if (Count == 3)
            {
                User_Input4 = "9";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (Count == 0)
            {
                User_Input1 = "8";
            }
            else if (Count == 1)
            {
                User_Input2 = "8";
            }
            else if (Count == 2)
            {
                User_Input3 = "8";
            }
            else if (Count == 3)
            {
                User_Input4 = "8";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (Count == 0)
            {
                User_Input1 = "7";
            }
            else if (Count == 1)
            {
                User_Input2 = "7";
            }
            else if (Count == 2)
            {
                User_Input3 = "7";
            }
            else if (Count == 3)
            {
                User_Input4 = "7";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (Count == 0)
            {
                User_Input1 = "6";
            }
            else if (Count == 1)
            {
                User_Input2 = "6";
            }
            else if (Count == 2)
            {
                User_Input3 = "6";
            }
            else if (Count == 3)
            {
                User_Input4 = "6";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (Count == 0)
            {
                User_Input1 = "5";
            }
            else if (Count == 1)
            {
                User_Input2 = "5";
            }
            else if (Count == 2)
            {
                User_Input3 = "5";
            }
            else if (Count == 3)
            {
                User_Input4 = "5";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (Count == 0)
            {
                User_Input1 = "4";
            }
            else if (Count == 1)
            {
                User_Input2 = "4";
            }
            else if (Count == 2)
            {
                User_Input3 = "4";
            }
            else if (Count == 3)
            {
                User_Input4 = "4";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (Count == 0)
            {
                User_Input1 = "3";
            }
            else if (Count == 1)
            {
                User_Input2 = "3";
            }
            else if (Count == 2)
            {
                User_Input3 = "3";
            }
            else if (Count == 3)
            {
                User_Input4 = "3";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (Count == 0)
            {
                User_Input1 = "2";
            }
            else if (Count == 1)
            {
                User_Input2 = "2";
            }
            else if (Count == 2)
            {
                User_Input3 = "2";
            }
            else if (Count == 3)
            {
                User_Input4 = "2";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (Count == 0)
            {
                User_Input1 = "1";
            }
            else if (Count == 1)
            {
                User_Input2 = "1";
            }
            else if (Count == 2)
            {
                User_Input3 = "1";
            }
            else if (Count == 3)
            {
                User_Input4 = "1";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (Count == 0)
            {
                User_Input1 = "0";
            }
            else if (Count == 1)
            {
                User_Input2 = "0";
            }
            else if (Count == 2)
            {
                User_Input3 = "0";
            }
            else if (Count == 3)
            {
                User_Input4 = "0";
            }
        }
    }

}   