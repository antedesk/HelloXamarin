using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;
using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class XMLFileLoaderExample : ContentPage
    {
        public XMLFileLoaderExample()
        {
            var assembly = typeof(XMLFileLoaderExample).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("HelloXamarin.recipes.xml");

            ObservableCollection<Recipe> recipes;
            using (var reader = new StreamReader(stream))
            {
                var serializer = new XmlSerializer(typeof(ObservableCollection<Recipe>));
                recipes = (ObservableCollection<Recipe>)serializer.Deserialize(reader);
            }


            InitializeComponent();

            list.ItemsSource = recipes;
        }
    }
}
