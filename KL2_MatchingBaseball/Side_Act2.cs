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
        int RandomNum2;
        TextView text;
        string Answer;
        List<int> comparing2;
        int Out_Count2;
        int Ball_Count2;
        int Strike_Count2;
        int All_Out2;
        TextView textviewScore2;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Side_Layout2);



            for (int i2 = 0; i2 < 4; i2++)
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
            textviewScore2 = FindViewById<TextView>(Resource.Id.textView2_Score);

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
            comparing2 = new List<int>();



        }

        int Count = 0;
        string User_Input1;
        string User_Input2;
        string User_Input3;
        string User_Input4;

        private void X_Click(object sender, EventArgs e)
        {
            text.Text = "";
            textviewScore2.Text = "";

            Strike_Count2 = 0;
            Ball_Count2 = 0;
            Out_Count2 = 0;
            All_Out2 = 0;
            text.Text = "";
        }


        private void Enter_Click(object sender, EventArgs e)
        {
            for (int i2 = 0; i2 < RandomList2.Count; i2++)
            {
                for (int k2 = 0; k2 < comparing2.Count; k2++)
                {
                    int value_i2 = RandomList2[i2];
                    int value_k2 = comparing2[k2];
                    if (value_i2 == value_k2)
                    {
                        if (i2 == k2)
                        {
                            Strike_Count2++;
                        }
                        else
                        {
                            Ball_Count2++;
                        }
                    }
                    else
                    {
                        Out_Count2++;
                    }
                }
                if (Out_Count2 == 4)
                {
                    Out_Count2 = 0;
                    All_Out2++;
                }
            }

            if (All_Out2 == 4)
            {
                textviewScore2.Text = "전부아웃입니닼";

                Strike_Count2 = 0;
                Ball_Count2 = 0;
                Out_Count2 = 0;
                All_Out2 = 0;
            }

            else
            {
                textviewScore2.Text = Strike_Count2 + "S " + Ball_Count2 + "B" + "입니닼";

                Strike_Count2 = 0;
                Ball_Count2 = 0;
                Out_Count2 = 0;
                All_Out2 = 0;
            }
            text.Text = "";
        }


        private void btn9_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + "9";
            textviewScore2.Text = "";
            comparing2.Add(9);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + "8";
            textviewScore2.Text = "";
            comparing2.Add(8);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + "7";
            textviewScore2.Text = "";
            comparing2.Add(7);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + "6";
            textviewScore2.Text = "";
            comparing2.Add(6);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + "5";
            textviewScore2.Text = "";
            comparing2.Add(5);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + "4";
            textviewScore2.Text = "";
            comparing2.Add(4);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + "3";
            textviewScore2.Text = "";
            comparing2.Add(3);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + "2";
            textviewScore2.Text = "";
            comparing2.Add(2);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + "1";
            textviewScore2.Text = "";
            comparing2.Add(1);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + "0";
            textviewScore2.Text = "";
            comparing2.Add(0);
        }
    }

}