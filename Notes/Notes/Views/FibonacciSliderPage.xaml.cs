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
           
            
            }
    }
}
