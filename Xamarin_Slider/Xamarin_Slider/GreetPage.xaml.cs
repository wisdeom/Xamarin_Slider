using System;
using System.Collections.Generic;
using Xamarin.Forms.Xaml;

using Xamarin.Forms;

namespace Xamarin_Slider
{
    //Skip XAML compilation
    [XamlCompilation(XamlCompilationOptions.Skip)]
    public partial class GreetPage : ContentPage
    {
        
        public GreetPage()
        {
            InitializeComponent();
            slider.Value = 0.5;
        }

        void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            label.Text = String.Format("Value is {0:F2}", e.NewValue);
        }

    }
}
