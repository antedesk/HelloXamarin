using HelloXamarin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class SQLiteDatabaseRecipeDetailsExample : ContentPage
    {
        public SQLiteDatabaseRecipeDetailsExample()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true);
        }

        void saveClicked(object sender, EventArgs e)
        {
            var recipe = (RecipeModel)BindingContext;
            App.Database.SaveRecipe(recipe);
            this.Navigation.PopAsync();
        }

        void deleteClicked(object sender, EventArgs e)
        {
            var recipe = (RecipeModel)BindingContext;
            App.Database.DeleteRecipe(recipe.Id);
            this.Navigation.PopAsync();
        }

        void cancelClicked(object sender, EventArgs e)
        {
            var recipe = (RecipeModel)BindingContext;
            this.Navigation.PopAsync();
        }
    }
}
