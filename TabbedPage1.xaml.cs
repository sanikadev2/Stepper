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
    public partial class TabbedPage1 : TabbedPage
    {
        Label label1;
        
      
        public TabbedPage1()
        {
            InitializeComponent();
        }
        

        void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            label1.Text = String.Format("Stepper value is {0:F1}", e.NewValue);
        }

        
    }
}

