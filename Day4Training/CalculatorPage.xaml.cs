using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Day4Training
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculatorPage : ContentPage
    {
        public CalculatorPage()
        {
            InitializeComponent();
        }
/*
        private void Button_Clicked(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(Num1.Text);
            int num2 =  Convert.ToInt32(Num2.Text);
            int c = num1+ num2;
            result.Text = c.ToString();

        }
        */
    }
}