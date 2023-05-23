using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Task2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StepperPage : ContentPage
    {
        Label label1;
        public StepperPage()
        {
            InitializeComponent();
        }
        private void CreateUI()
        {
            Label header = new Label
            {
                Text = "Stepper",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            Stepper stepper = new Stepper
            {
                Minimum = 0,
                Maximum = 10,
                Increment = 0.1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            stepper.ValueChanged += OnStepperValueChanged;

            label1 = new Label
            {
                Text = "Stepper value is 0",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // Build the page.
            Title = "Stepper Demo";
            Content = new StackLayout
            {
                Children =
                {
                    header,
                    stepper,
                    label1
                }
            };
        }

        void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            label1.Text = String.Format("Stepper value is {0:F1}", e.NewValue);
        }
    }
}
    
