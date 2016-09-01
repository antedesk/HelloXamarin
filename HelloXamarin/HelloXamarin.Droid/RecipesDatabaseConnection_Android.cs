using System;
using Xamarin.Forms;
using HelloXamarin.Droid;
using SQLite;
using System.IO;

[assembly: Dependency(typeof(RecipesDatabaseConnection_Android))]

namespace HelloXamarin.Droid
{
    public class RecipesDatabaseConnection_Android : IRecipesDatabaseConnection
    {

        public RecipesDatabaseConnection_Android() { }

        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "RecipesDB.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}