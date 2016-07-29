using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HelloXamarin
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
  
            MainPage = new WebViewExample();

        }

        protected override void OnStart()
        {
            Debug.WriteLine("HelloXamarin OnStart");
            
        }

        protected override void OnSleep()
        {
            Application.Current.Properties["test"] = "HTML.it";
            //if (Device.OS == TargetPlatform.Android)
            //    Debug.WriteLine("I'm on Android");
            //else if (Device.OS == TargetPlatform.WinPhone)
            //    Debug.WriteLine("I'm on WP");
            Debug.WriteLine("HelloXamarin OnSleep");

        }

        protected override void OnResume()
        {
            if (Application.Current.Properties.ContainsKey("test"))
            {
                string test = Application.Current.Properties["test"] as string;
                
                Debug.WriteLine(test);
                // do something with id
            }
            Debug.WriteLine("HelloXamarin OnResume");
        }

     
    }
    
}
