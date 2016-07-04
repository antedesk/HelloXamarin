using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace HelloXamarin
{
    public class StackLayoutViewsExample : ContentPage
    {
        Label sldLabel;
        Label stppLabel;
        public StackLayoutViewsExample()
        {
            Label title = new Label
            {
                Text = "Views Demo",
                TextColor = Color.Green,
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center,
            };

            Button button = new Button
            {
                Text = "Display Alert",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
            };
            button.Clicked += OnButtonClicked;

            StackLayout stckltVertical = new StackLayout
            {
                Spacing = 20,
                VerticalOptions = LayoutOptions.Start,
                Children =
                {
                    new Entry
                    {
                        Keyboard = Keyboard.Text,
                        Placeholder = "Name"
                    },
                    new Entry
                    {
                        Keyboard = Keyboard.Text,
                        Placeholder = "Name"
                    },
                    new Entry
                    {
                        Keyboard = Keyboard.Text,
                        Placeholder = "Name"
                    },
                    new Entry
                    {
                        Keyboard = Keyboard.Text,
                        Placeholder = "Name"
                    },
                    new Entry
                    {
                        Keyboard = Keyboard.Text,
                        Placeholder = "Name"
                    },
                    new Entry
                    {
                        Keyboard = Keyboard.Text,
                        Placeholder = "Name"
                    },
                    new Entry
                    {
                        Keyboard = Keyboard.Text,
                        Placeholder = "Name"
                    },
                    new Entry
                    {
                        Keyboard = Keyboard.Text,
                        Placeholder = "Name"
                    },
                    new Entry
                    {
                        Keyboard = Keyboard.Text,
                        Placeholder = "Name"
                    },
                    new Entry
                    {
                        Keyboard = Keyboard.Text,
                        Placeholder = "Name"
                    },
                    new Entry
                    {
                        Keyboard = Keyboard.Text,
                        Placeholder = "Name"
                    },
                    new Entry
                    {
                        Keyboard = Keyboard.Text,
                        Placeholder = "Name"
                    },
                    new Entry
                    {
                        Keyboard = Keyboard.Text,
                        Placeholder = "Name"
                    },
                    new Entry
                    {
                        Keyboard = Keyboard.Text,
                        Placeholder = "Name"
                    },
                    new Entry
                    {
                        Keyboard = Keyboard.Text,
                        Placeholder = "Name"
                    },
                    new Entry
                    {
                        Keyboard = Keyboard.Text,
                        Placeholder = "Name"
                    },
                    new Entry
                    {
                        Keyboard = Keyboard.Text,
                        Placeholder = "Name"
                    },
                    new Entry
                    {
                        Keyboard = Keyboard.Text,
                        Placeholder = "Name"
                    },


                    new Entry
                    { 
                        Placeholder = "Enter password",
                        IsPassword = true
                    },
                    new DatePicker
                    {
                        Format = "D", 
                        BackgroundColor = Color.Blue      
                    },
                    new Editor
                    { 
                        FontSize = 15,
                        HeightRequest = 100,
                        TextColor = Color.Black,
                        BackgroundColor = Color.Gray   
                    },
               }
                
            };

            stckltVertical.Children.Add(button);

            
            Stepper stepper = new Stepper
            {
                Minimum = 0,
                Maximum = 10,
                Increment = 0.1,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };
            stepper.ValueChanged += OnStepperValueChanged;

            stppLabel = new Label
            {
                Text = "Value = 0 ",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Start
            };
            StackLayout stckltHorz1 = new StackLayout();
            stckltHorz1.Orientation = StackOrientation.Horizontal;
            stckltHorz1.Children.Add(stppLabel);
            stckltHorz1.Children.Add(stepper);


            Slider slider = new Slider
            {
                Minimum = 0,
                Maximum = 100,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            slider.ValueChanged += OnSliderValueChanged;

            sldLabel = new Label
            {
                Text = "Value = 0 ",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.End
            };

            StackLayout stckltHorz2 = new StackLayout();
            stckltHorz2.Orientation = StackOrientation.Horizontal;
            stckltHorz2.Children.Add(sldLabel);
            stckltHorz2.Children.Add(slider);

            Image footer = new Image
            {
                Source = ImageSource.FromUri(new Uri("http://cdn4.www.html.it/wp-content/themes/www.html.it/images/logo.png")),
                VerticalOptions = LayoutOptions.EndAndExpand
            };

            StackLayout f = new StackLayout
            {
                Spacing = 20,
                Children =
                {
                    title,
                    stckltVertical,
                    stckltHorz1,
                    footer,
                }
            };
            Content = new ScrollView
            {
                Content = f
            };
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            String titleAlert = "hello Xamarin!";
            String content = "That's an alert";
            String cancel = "ok";
            DisplayAlert(titleAlert,content,cancel);
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            sldLabel.Text = String.Format("Value = {0:F1}", e.NewValue);
        }

        void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            stppLabel.Text = String.Format("Value = {0:F1}", e.NewValue);
        }

    }
}
