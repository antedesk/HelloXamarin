using System;

using Xamarin.Forms;
using HelloXamarin.iOS;
using SQLite;
using System.IO;

[assembly: Dependency(typeof(RecipesDatabaseConnection_iOS))]

namespace HelloXamarin.iOS
{
    public class RecipesDatabaseConnection_iOS : IRecipesDatabaseConnection
    {

        public RecipesDatabaseConnection_iOS() { }

        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "RecipesDB.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder
            var path = Path.Combine(libraryPath, sqliteFilename);
            // Create the connection
            var conn = new SQLite.SQLiteConnection(path);
            // Return the database connection
            return conn;
        }
    }
}