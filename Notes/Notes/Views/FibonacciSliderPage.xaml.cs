using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Notes.Views
{
    public partial class FibonacciSliderPage : ContentPage


    {




        public FibonacciSliderPage()
        {

            InitializeComponent();

        }



        
        void FibonacciSlider_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            int Stage = (int)Math.Round(FibonacciSlider.Value);

            labelValue.Text = Stage.ToString();

            int Fibonacci = CalculateLabel(Stage);

            labelFibonacci.Text = Fibonacci.ToString();

            }

        private int CalculateLabel(int Stage)
        {
            if (Stage == 12)
            {
                return 100;
            }
            else
            {
               return Fibonacci(Stage);

            }
        }
            public static int Fibonacci(int n)
            {
                int a = 0;
                int b = 1;
                // In N steps, compute Fibonacci sequence iteratively.
                for (int i = 0; i < n; i++)
                {
                    int temp = a;
                    a = b;
                    b = temp + b;
                }
                return a;
            }
        }
    }

