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
            int[] m_data;
            Side_Act m_Player;
            void NumberBaseBall()
            {
                m_data = new int[3];
                m_Player = new Side_Act();
            }
            void makeData()
            {
                Random rand;
                rand = new Random();

                for (int i = 0; i < m_data.Length; i++)
                {
                    m_data[i] = rand.Next(0, 9);
                    for (int j = 0; j < i; j++)
                    {
                        if (m_data[i] == m_data[j])
                        {
                            i--;
                        }
                    }

                }
            }
            void showMsg(String msg)
            {
                Toast.MakeText(this, msg,ToastLength.Long).Show();
            }
            void showPlay(int[] data)
            {
                Toast.MakeText(this, "스트라이크:" + data[1] + " ,볼:" + data[0],ToastLength.Long).Show();
            }
            void showGameEnd(Boolean win)
            {
                if (true == win)
                {
                    Toast.MakeText(this, "축하합니다", ToastLength.Long).Show();
                }
                Toast.MakeText(this, "컴퓨터의 숫자는?", ToastLength.Long).Show();
                for (int i = 0; i < m_data.Length; i++)
                {
                    Toast.MakeText(this, m_data[i], ToastLength.Long).Show();
                }
            }
            int check(int index, int a)
            {
                int b;

                b = 0;
                for (int i = 0; i < m_data.Length; i++)
                {
                    if (m_data[i] == a)
                    {
                        if (i == index)
                        {
                            b = 2;
                            break;
                        }
                        else
                        {
                            b = 1;
                        }
                    }
                }
                return b;
            }
            void onePlay(int[] result)
            {
                int input;
                int r;
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = 0;
                }
                for (int i = 0; i < 3; i++)
                {
                    input = m_Player.input();
                    r = check(i, input);

                    if (2 == r)
                    {
                        result[1]++;
                    }
                    else if (1 == r)
                    {
                        result[0]++;
                    }
                }
            }
            void run()
            {
                Boolean win;
                int[] result;

                result = new int[2];
                makeData();

                win = false;
                for (int i = 0; i < 10; i++)
                {
                    showMsg((i + 1) + "번째 시도");

                    onePlay(result);
                    showPlay(result);
                }
                showGameEnd(win);
            }
            static void Main(string[] args)
            {
                Program m = new Program();
                m.NumberBaseBall();
                m.run();

            }
        }
    }
}