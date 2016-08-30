using System;
using System.Threading.Tasks;
using HelloXamarin.Droid;
using Xamarin.Forms;
using System.IO;

[assembly: Dependency(typeof(FileManager_Android))]

namespace HelloXamarin.Droid
{
    public class FileManager_Android : IFileManager
    {


        public async Task SaveAsync(string filename, string text)
        {
            var path = CreatePathToFile(filename);
            using (StreamWriter sw = File.CreateText(path))
                await sw.WriteAsync(text);
        }

        public async Task<string> LoadAsync(string filename)
        {
            var path = CreatePathToFile(filename);
            using (StreamReader sr = File.OpenText(path))
                return await sr.ReadToEndAsync();
        }

        public bool FileExists(string filename)
        {
            return File.Exists(CreatePathToFile(filename));
        }

        // metodo privato per determinare il percorso in cui salvare e da cui caricare la risorsa testuale.
        string CreatePathToFile(string filename)
        {
            var docsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(docsPath, filename);
        }
    }
}