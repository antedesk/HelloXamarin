using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using HelloXamarin;
using HelloXamarin.iOS;
using Foundation;
using UIKit;

[assembly: ExportRenderer(typeof(RecipeCustomCell), typeof(RecipeiOSCustomCellRenderer))]
namespace HelloXamarin.iOS
{
    class RecipeiOSCustomCellRenderer : ViewCellRenderer
    {
        static NSString rid = new NSString("RecipeCustomCell");

        // Questo metodo ritorna per ogni RecipeCustomCell ina RecipeiOSCustomCell uniformata con gli altri sistemi 
        // che viene renderizzata usando il renderer specifico per iOS
        public override UITableViewCell GetCell(Xamarin.Forms.Cell item, UITableViewCell reusableCell, UITableView tv)
        {

            // converto l'item di tipo Cell al tipo specifico che si desidera
            var customcell = (RecipeCustomCell)item;


            RecipeiOSCustomCell reus_cell = reusableCell as RecipeiOSCustomCell;

            if (reus_cell == null)
            {
                reus_cell = new RecipeiOSCustomCell(rid);
            }

            // caricamento dell'immagine se esiste ed è definita utilizzanto un oggetto UIImage
            // che conterrà tale informazione
            UIImage i = null;
            if (!String.IsNullOrWhiteSpace(customcell.ImagePath))
            {
                // recupero del percorso in cui è salvata l'immagine
                i = UIImage.FromFile("Images/" + customcell.ImagePath);
            }

            // aggiornamento della cella con le informazioni su nome, tipo e immagine
            reus_cell.UpdateCell(customcell.Name, customcell.Type, i);

            return reus_cell;
        }
    }
}