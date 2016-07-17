using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UIKit;
using Foundation;

namespace HelloXamarin.iOS
{
    //creazione di una nuova Cell ad-hoc per iOS estendendo la classe UITableViewCell che definisce gli attributi e il comportamento
    // di una Cell che compare all'interno di una UITableView.
    public class RecipeiOSCustomCell : UITableViewCell
    {
        UILabel nameLabel, typeLabel;
        UIImageView imageView;

        // costruttore della Cell
        public RecipeiOSCustomCell(NSString cellId) : base (UITableViewCellStyle.Default, cellId)
		{
            // stile della cella selezionata
            SelectionStyle = UITableViewCellSelectionStyle.Default;

            //definizione del background
            ContentView.BackgroundColor = UIColor.FromRGB(255, 255, 255);

            //creazione di un nuovo oggetto di tipo UIImageView che conterrà l'immagine associata alla ricetta
            imageView = new UIImageView();

            // creazione di una nuova label per il nome di cui viene impstato il colore
            nameLabel = new UILabel()
            {
                //Font = UIFont.FromName("Cochin-BoldItalic", 22f),
                TextColor = UIColor.FromRGB(37, 111, 35),
                BackgroundColor = UIColor.Clear
            };

            // creazione di una nuova label per il nome di cui viene impstato il colore
            typeLabel = new UILabel()
            {
                //Font = UIFont.FromName("AmericanTypewriter", 12f),
                TextColor = UIColor.FromRGB(0, 0, 0),
                BackgroundColor = UIColor.Clear
            };

            // i contenuti vengono aggiunti alla 
            ContentView.Add(imageView);
            ContentView.Add(nameLabel);
            ContentView.Add(typeLabel);
        }

        // aggiornamento della cella impiegando i valori delle tre proprietà
        public void UpdateCell(string name, string type, UIImage image)
        {
            imageView.Image = image;
            nameLabel.Text = name;
            typeLabel.Text = type;
        }

        // metodo invocato ogni volta che il frame della vista cambia. 
        // Definisce la posiione degli elementi della Custom Cell l'impostazione delle coordinate
        // impiegando la proprietà CGRect dell'oggetto CoreGraphics.   
        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            imageView.Frame = new CoreGraphics.CGRect(2, 2, 40, 40);
            nameLabel.Frame = new CoreGraphics.CGRect(50, 5, ContentView.Bounds.Width - 38, 20);
            typeLabel.Frame = new CoreGraphics.CGRect(50, 25, ContentView.Bounds.Width - 38, 20);
        }
    }
}