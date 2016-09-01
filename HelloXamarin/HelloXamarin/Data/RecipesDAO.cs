using HelloXamarin.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloXamarin.Data
{

    public class RecipesDAO
    {
        private SQLiteConnection database;
        private static object collisionLock = new object();

        public RecipesDAO()
        {
            database = DependencyService.Get<IRecipesDatabaseConnection>().GetConnection();
            database.CreateTable<RecipeModel>();
        }


        public IEnumerable<RecipeModel> GetRecipes()
        {
            lock (collisionLock)
            {
                return (from i in database.Table<RecipeModel>() select i).ToList();
            }
        }

        public RecipeModel GetRecipe(int id)
        {
            lock (collisionLock)
            {
                return database.Table<RecipeModel>().FirstOrDefault(x => x.Id == id);
            }
        }

        public int SaveRecipe(RecipeModel recipe)
        {
            lock (collisionLock)
            {
                if (recipe.Id != 0)
                {
                    database.Update(recipe);
                    return recipe.Id;
                }
                else
                {
                    return database.Insert(recipe);
                }
            }
        }

        public int DeleteRecipe(int id)
        {
            lock (collisionLock)
            {
                return database.Delete<RecipeModel>(id);
            }
        }

    }
}
