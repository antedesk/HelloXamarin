using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class ImageManagmentExample : ContentPage
    {

        string logoUri = "http://www.html.it/wp-content/themes/www.html.it/images/logo.png";
        public ImageManagmentExample()
        {
            InitializeComponent();

            //impostazione dell'immagine lato code-behind per ogni piattaforma
            img_codebehind.Source = Device.OnPlatform(ImageSource.FromFile("logo.png"),
                                                 ImageSource.FromFile("logo.png"),
                                                 ImageSource.FromFile("Images/logo.png"));

            //caricamento di un immagine da URI
            imageDownloaded.Source = ImageSource.FromUri(new Uri(logoUri));

            imgCaching.Source = new UriImageSource
            {
                Uri = new Uri(logoUri),
                CachingEnabled = true,
                CacheValidity = new TimeSpan(5, 0, 0, 0)
            };
        }

        void OnImageTapped(object sender, EventArgs args)
        {
            //cast dell'oggestto sender al tipo Image
            Image image = (Image)sender;

            //impostazione della opacità iniziale dell'immagine
            image.Opacity = 0.75;

            // rende l'immagine opaca per 100 ms
            Device.StartTimer(TimeSpan.FromMilliseconds(2000), () =>
            {
                image.Opacity = 1;
                return false;
            });
        }
    }
}
