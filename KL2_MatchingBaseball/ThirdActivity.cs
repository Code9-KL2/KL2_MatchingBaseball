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
        string textview1;
        
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
            Button buttonX = FindViewById<Button>(Resource.Id.buttonX);
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
            buttonX.Click += ButtonX_Click;







            // Create your application here

        }
        public void preventtextview(string a, string b, string c, string d, string e, string f, string g, string h, string i,string j)
        {
            if (textview.Text.Length < 3)
            {
                
               textview.Text = textview.Text + a + b + c + d + e + f + g + h + i + j;


            }






        }
        



        private void ButtonX_Click(object sender, EventArgs e)
        {
            
            textview.Text = "";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            preventtextview("", "", "", "", "", "", "", "", "", "9");

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            preventtextview("", "", "", "", "", "", "", "", "8","");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            preventtextview("", "", "", "", "", "", "", "7", "", "");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            preventtextview("", "", "", "", "", "", "6", "","", "");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            preventtextview("", "", "", "", "", "5", "", "", "", "");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            preventtextview("", "", "", "", "4", "", "", "", "", "");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            preventtextview("", "", "", "3", "", "", "", "", "", "");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            preventtextview("", "", "2", "", "", "", "", "", "", "");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            preventtextview("", "1", "", "", "", "", "", "", "", "");
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            preventtextview("0", "", "", "", "", "", "", "", "", "");
        }
        
    }
}