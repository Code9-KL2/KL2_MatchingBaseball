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

        Random random2 = new Random();

        List<int> RandomList2 = new List<int>();
        int a;
        int RandomNum2;
        TextView text;
        string Answer;
        List<string> comparing2;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Side_Layout2);



            for (int i2 = 0; i2 <= 4; i2++)
            {
                RandomNum2 = random2.Next(0, 9);
                RandomList2.Add(RandomNum2);
            }

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
            Button X = FindViewById<Button>(Resource.Id.X);
            text = FindViewById<TextView>(Resource.Id.TextView2);

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
            X.Click += X_Click;
            Enter.Click += Enter_Click;
            comparing2 = new List<string>();



        }

        int Count = 0;
        string User_Input1;
        string User_Input2;
        string User_Input3;
        string User_Input4;

        public void preventtextview2(string a2)
        {
            if (text.Text.Length < 3)
            {

                text.Text = text.Text + a2;
            }
        }
        private void X_Click(object sender, EventArgs e)
        {
            text.Text = ""; 
        }

        void Set_Input(string num)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Set_Input("9");
            preventtextview2("9");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Set_Input("8");
            preventtextview2("8");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Set_Input("7");
            preventtextview2("7");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Set_Input("6");
            preventtextview2("6");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Set_Input("5");
            preventtextview2("5");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Set_Input("4");
            preventtextview2("4");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Set_Input("3");
            preventtextview2("3");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Set_Input("2");
            preventtextview2("2");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Set_Input("1");
            preventtextview2("1");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Set_Input("0");
            preventtextview2("0");
        }
    }

}