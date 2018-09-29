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
        Random random;
        int n;
        int n1;
        int n2;
        int n3;

        string n_string;
        string n1_string;
        string n2_string;
        string n3_string;

        string Answer;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Side_Layout2);

            Random random = new Random();
            n = random.Next(0, 9);
            n1 = random.Next(0, 9);
            n2 = random.Next(0, 9);
            n3 = random.Next(0, 9);

            n_string = Convert.ToString(n);
            n1_string = Convert.ToString(n1);
            n2_string = Convert.ToString(n2);
            n3_string = Convert.ToString(n3);

            Answer = n_string + n1_string + n2_string + n3_string;

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

        void Set_Input(string num)
        {
            if (Count == 0)
            {
                User_Input1 = num;
                Count = 1;
            }
            else if (Count == 1)
            {
                User_Input2 = num;
                Count = 2;
            }
            else if (Count == 2)
            {
                User_Input3 = num;
                Count = 3;
            }
            else if (Count == 3)
            {
                User_Input4 = num;
            }
        }

        private void Enter_Click(object sender, EventArgs e)
        {
        
            string User_Answer = User_Input4 + User_Input3 + User_Input2 + User_Input1;
            while(User_Answer == Answer)
            {
                if(User_Answer == Answer)
                {
                    Console.WriteLine("홈런");
                }
                else if (User_Input1 == n_string || User_Input1 == n1_string || User_Input1 == n2_string || User_Input1 == n3_string || User_Input2 == n_string || User_Input2 == n1_string || User_Input2 == n2_string || User_Input2 == n3_string || User_Input3 == n_string || User_Input3 == n1_string || User_Input3 == n2_string || User_Input3 == n3_string || User_Input4 == n_string || User_Input4 == n1_string || User_Input4 == n2_string || User_Input4 == n3_string)
                {
                    Console.WriteLine("볼");
                }
                else
                {
                    Console.WriteLine("스트라이크");
                }
            }

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Set_Input("9");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Set_Input("8");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Set_Input("7");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Set_Input("6");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Set_Input("5");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Set_Input("4");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Set_Input("3");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Set_Input("2");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Set_Input("1");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Set_Input("0");
        }
    }

}