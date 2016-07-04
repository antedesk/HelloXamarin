using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class XAMLPageXample : ContentPage
    {
        public XAMLPageXample()
        {
            InitializeComponent();
            welcomeLabel.Text = "XAML Example";
        }

        void OnAlertClicked(object sender, EventArgs args)
        {
            if(entryText.Text!=null)
                DisplayAlert("Alert", entryText.Text, "Cancel");
            else
                DisplayAlert("Alert", "Please, Insert a text!", "Cancel");
        }
    }
}
