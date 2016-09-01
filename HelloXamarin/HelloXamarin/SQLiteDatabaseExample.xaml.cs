using HelloXamarin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class SQLiteDatabaseExample : ContentPage
    {
        public SQLiteDatabaseExample()
        {
            InitializeComponent();

            #region toolbar
            ToolbarItem tbi = null;
            if (Device.OS == TargetPlatform.iOS)
            {
                tbi = new ToolbarItem("+", null, () =>
                {
                    var recipe = new RecipeModel();
                    var recipeDetails = new SQLiteDatabaseRecipeDetailsExample();
                    recipeDetails.BindingContext = recipe;
                    Navigation.PushAsync(recipeDetails);
                }, 0, 0);
            }
            if (Device.OS == TargetPlatform.Android)
            { // BUG: Android doesn't support the icon being null
                tbi = new ToolbarItem("+", "plus", () =>
                {
                    var recipe = new RecipeModel();
                    var recipeDetails = new SQLiteDatabaseRecipeDetailsExample();
                    recipeDetails.BindingContext = recipe;
                    Navigation.PushAsync(recipeDetails);
                }, 0, 0);
            }
            if (Device.OS == TargetPlatform.WinPhone || Device.OS == TargetPlatform.Windows)
            {
                tbi = new ToolbarItem("Add", "add.png", () =>
                {
                    var recipe = new RecipeModel();
                    var recipeDetails = new SQLiteDatabaseRecipeDetailsExample();
                    recipeDetails.BindingContext = recipe;
                    Navigation.PushAsync(recipeDetails);
                }, 0, 0);
            }

            ToolbarItems.Add(tbi);
            #endregion
        }

        // Metodo per definire il comportamento dell'app quando la pagina sta per essere mostrata
        // in questo caso viene caricato dal db la lista di ricette disponibili
        protected override void OnAppearing()
        {
            base.OnAppearing();
            recipesList.ItemsSource = App.Database.GetRecipes();
        }

        // medoto per definire cosa accade quando una ricetta viene selezionata dalla lista
        // in questo caso verrà preso l'elemento selezionato e si rimanderà l'utente alla pagina di dettagli
        // in cui sarà possibile compiere determinate operazioni CRUD
        void listItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var recipe = (RecipeModel)e.SelectedItem;
            var recipeDetails = new SQLiteDatabaseRecipeDetailsExample();
            recipeDetails.BindingContext = recipe;
            

            Navigation.PushAsync(recipeDetails);
        }

    }


}
