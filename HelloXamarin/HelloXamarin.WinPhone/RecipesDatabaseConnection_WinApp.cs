using HelloXamarin.WinPhone;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;
using Windows.Storage;

[assembly: Dependency(typeof(RecipesDatabaseConnection_WinApp))]

namespace HelloXamarin.WinPhone
{
    public class RecipesDatabaseConnection_WinApp : IRecipesDatabaseConnection
    {

        public RecipesDatabaseConnection_WinApp() { }

        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "RecipesDB.db3";
            string path = Path.Combine(ApplicationData.Current.LocalFolder.Path, sqliteFilename);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}
