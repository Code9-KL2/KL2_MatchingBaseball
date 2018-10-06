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

        string Astring;
        int a;
        TextView textview;
        string RandomString;
        int RandomNum;
        string randomtostring;
        int textviewsuport;
        List<int> comparing = new List<int>();
        List<int> test = new List<int>();
        TextView textviewScore;
        List<int> RandomList = new List<int>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SideAct3_Layout);

            Random random = new Random();
            for (int i = 1; i <= 3; i++)
            {

                RandomNum = random.Next(0,9);
                
                RandomList.Add(RandomNum);
            }

            string Randomnum = Convert.ToString(RandomNum);
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
            Button buttonEnter = FindViewById<Button>(Resource.Id.buttonEnter);
            textview = FindViewById<TextView>(Resource.Id.textview);
            textviewScore = FindViewById<TextView>(Resource.Id.textviewScore);
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
            buttonEnter.Click += ButtonEnter_Click;    
            





            // Create your application here

        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {   
            for (int i = 0; i < RandomList.Count; i++)
            {
                for (int j = 0; j < comparing.Count; j++)
                {
                    if (RandomList[i] == comparing[j])
                    {
                        int a = 0;
                        a = a + 1;



                    }
                    
                }
                textviewScore.Text = "S" + a;


            }
            
        }
        


        public void preventtextview(string a)
        {
            if (textview.Text.Length < 3)
            {

                textview.Text = textview.Text + a;
                

            }
        }
        
        
        
        private void ButtonX_Click(object sender, EventArgs e)
        {
            
            textview.Text = "";
            comparing.Clear();
            textviewScore.Text = "";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            preventtextview("9");
            comparing.Add(9);
            textviewScore.Text = "";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            preventtextview("8");
            comparing.Add(8);
            textviewScore.Text = "";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            preventtextview("7");
            comparing.Add(7);
            textviewScore.Text = "";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            preventtextview("6");
            comparing.Add(6);
            textviewScore.Text = "";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            preventtextview("5");
            comparing.Add(5);
            textviewScore.Text = "";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            preventtextview("4");
            comparing.Add(4);
            textviewScore.Text = "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            preventtextview("3");
            comparing.Add(3);
            textviewScore.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            preventtextview("2");
            comparing.Add(2);
            textviewScore.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            preventtextview("1");
            comparing.Add(1);
            textviewScore.Text = "";
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            preventtextview("0");
            comparing.Add(0);
            textviewScore.Text = "";
        }
        
    }
}