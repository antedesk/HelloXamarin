/////////////////////////////////////////////////////////////////////////////////////////////////
/////                  This Class was commented and replaced by its XMAL defition           /////
/////                 to create and apply ControlTemplate to the application itself         /////
/////         If you want to use this class, please comment (or delete) the App.xaml file.  /////
/////                                Thanks! Antonio                                        /////                  
/////////////////////////////////////////////////////////////////////////////////////////////////

//using HelloXamarin.Data;
//using HelloXamarin.Maps;
//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;

//using Xamarin.Forms;

//namespace HelloXamarin
//{
//    public class App : Application
//    {
//        static RecipesDAO database;


//        public App()
//        {
//            // The root page of your application


//            //Resources = new ResourceDictionary();
//            //Resources.Add("primaryGreen", Color.FromHex("197519"));

//            //var nav = new NavigationPage(new SQLiteDatabaseExample());
//            //nav.BarBackgroundColor = (Color)App.Current.Resources["primaryGreen"];
//            //nav.BarTextColor = Color.White;


//            MainPage = new MapStyleExample();
//        }


//        public static RecipesDAO Database
//        {
//            get
//            {
//                if (database == null)
//                {
//                    database = new RecipesDAO();
//                }
//                return database;
//            }
//        }

//        protected override void OnStart()
//        {
//            Debug.WriteLine("HelloXamarin OnStart");
//            var path_db = App.Database;
//        }

//        protected override void OnSleep()
//        {
//            Application.Current.Properties["test"] = "HTML.it";
//            //if (Device.OS == TargetPlatform.Android)
//            //    Debug.WriteLine("I'm on Android");
//            //else if (Device.OS == TargetPlatform.WinPhone)
//            //    Debug.WriteLine("I'm on WP");
//            Debug.WriteLine("HelloXamarin OnSleep");

//        }

//        protected override void OnResume()
//        {
//            if (Application.Current.Properties.ContainsKey("test"))
//            {
//                string test = Application.Current.Properties["test"] as string;

//                Debug.WriteLine(test);
//                // do something with id
//            }
//            Debug.WriteLine("HelloXamarin OnResume");
//        }


//    }

//}
