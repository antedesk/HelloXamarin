using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class WebViewExample : ContentPage
    {
        public WebViewExample()
        {
            InitializeComponent();
            webv.Source = "http://www.html.it/";

            //var htmlSource = new HtmlWebViewSource();
            //htmlSource.Html = @"<html><body>
            //                        <h1>WebView con Xamarin.Forms</h1>
            //                        <p>Esempio di una WebView con contenuti inseriti dall'utente</p>
            //                    </body></html>";
            //webv.Source = htmlSource;

            //var x = App.Database;

        }

        void OnURLCompleted(object sender, EventArgs args)
        {
            string site = ((Entry)sender).Text;
            if (site.Contains("https://"))
                webv.Source = site;
            else
            {
                string uri = "https://" + site;
                webv.Source = uri;
                urlEntry.Text = uri;

            }
        }

        void OnGoBackClicked(object sender, EventArgs args)
        {
            webv.GoBack();
        }

        void OnGoForwardClicked(object sender, EventArgs args)
        {
            webv.GoForward();
        }

        void webOnNavigating(object sender, WebNavigatingEventArgs e)
        {
            loadinglbl.IsVisible = true;
        }

        void webOnEndNavigating(object sender, WebNavigatedEventArgs e)
        {
            loadinglbl.IsVisible = false;
        }


    }
}
