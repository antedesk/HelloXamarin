using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace HelloXamarin
{
    public class TableViewCellsExample : ContentPage
    {
        public TableViewCellsExample()
        {
            
            TableView tv = new TableView();
            tv.Intent = TableIntent.Form;
            TableRoot tv_root = new TableRoot();
            TableSection tv_section1 = new TableSection("Personal Data");
            TableSection tv_section2 = new TableSection("Settings Section");
            TableSection tv_section3 = new TableSection("Credits");

            
            EntryCell ec_nick = new EntryCell
            {
                Label = "Name",
                Placeholder = "insert here",
                Keyboard = Keyboard.Default,
                HorizontalTextAlignment = TextAlignment.Center,
            };
            EntryCell ec_phone = new EntryCell
            {
                Label = "Phonenumber",
                Placeholder = "+39",
                Keyboard = Keyboard.Telephone,
                HorizontalTextAlignment = TextAlignment.Center,
            };

            TextCell tc_settings = new TextCell()
            {
                Text = "Notifications",
                Detail = "Please enable notification",
                TextColor= Color.Red,
                DetailColor = Color.Gray,
                
            };

            SwitchCell sc_settings = new SwitchCell()
            {
                Text = "Enable:",
                On = false,
            };


            ImageCell imgc_footer = new ImageCell
            {
                ImageSource =
                                 Device.OnPlatform(ImageSource.FromFile("logo.png"),
                                                  ImageSource.FromUri(new Uri("http://cdn4.www.html.it/wp-content/themes/www.html.it/images/logo.png")),//ImageSource.FromFile("logo.png"),
                                                  ImageSource.FromFile("Images/logo.png")),
               
                Text = "HTML.it",
                Detail = "Tutorial powered by Antedesk",
                TextColor = Color.Gray,
                DetailColor = Color.Lime, 
            };

            tv_section1.Add(ec_nick);
            tv_section1.Add(ec_phone);
            tv_section2.Add(tc_settings);
            tv_section2.Add(sc_settings);
            tv_section3.Add(imgc_footer);

            tv_root.Add(tv_section1);
            tv_root.Add(tv_section2);
            tv_root.Add(tv_section3);
            tv.Root = tv_root;
            

            Content = tv;
            
        }
    }
}
