using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloXamarin
{
    public class RecipeDataSource
    {

        public string Name { get; set; }
        public string Type { get; set; }
        public string ImagePath { get; set; }

        public RecipeDataSource(string name, string type, string imagePath)
        {
            Name = name;
            Type = type;
            ImagePath = imagePath;
        }

        public static List<RecipeDataSource> GetList()
        {
            var recipeList = new List<RecipeDataSource>();
            recipeList.Add(new RecipeDataSource("Matriciana", "Primo", "fakeIMG.png"));
            recipeList.Add(new RecipeDataSource("Carbonara", "Primo", "fakeIMG.png"));
            recipeList.Add(new RecipeDataSource("Risotto ai funghi", "Primo", "fakeIMG.png"));
            recipeList.Add(new RecipeDataSource("Gricia", "Primo", "fakeIMG.png"));
            recipeList.Add(new RecipeDataSource("Pollo al forno", "Secondo", "fakeIMG.png"));
            recipeList.Add(new RecipeDataSource("Cotoletta", "Secondo", "fakeIMG.png"));
            recipeList.Add(new RecipeDataSource("Veggie Burger", "Secondo", "fakeIMG.png"));
            recipeList.Add(new RecipeDataSource("Arrosto di maiale", "Secondo", "fakeIMG.png"));
            recipeList.Add(new RecipeDataSource("Tortino al cioccola", "Dolce", "fakeIMG.png"));
            recipeList.Add(new RecipeDataSource("Sorbetto al limone", "Dolce", "fakeIMG.png"));
            recipeList.Add(new RecipeDataSource("Sacher", "Dolce", "fakeIMG.png"));
            recipeList.Add(new RecipeDataSource("Crostata di Amarene", "Dolce", "fakeIMG.png"));
            return recipeList;
        }
    }
}
