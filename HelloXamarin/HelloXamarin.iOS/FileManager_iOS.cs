using System;
using Xamarin.Forms;
using System.IO;
using System.Threading.Tasks;
using Foundation;
using System.Linq;
using HelloXamarin.iOS;

[assembly: Dependency(typeof(FileManager_iOS))]

namespace HelloXamarin.iOS
{
    public class FileManager_iOS : IFileManager
    {

        public async Task SaveAsync(string filename, string text)
        {
            string path = CreatePathToFile(filename);
            using (StreamWriter sw = File.CreateText(path))
                await sw.WriteAsync(text);
        }

        public async Task<string> LoadAsync(string filename)
        {
            string path = CreatePathToFile(filename);
            using (StreamReader sr = File.OpenText(path))
                return await sr.ReadToEndAsync();
        }

        public bool FileExists(string filename)
        {
            return File.Exists(CreatePathToFile(filename));
        }


        // metodo per recuperare il path della cartella in cui salvare e da cui caricare il file di testo 
        public static string DocumentsPath
        {
            get
            {
                var documentsDirUrl = NSFileManager.DefaultManager.GetUrls(NSSearchPathDirectory.DocumentDirectory, NSSearchPathDomain.User).Last();
                return documentsDirUrl.Path;
            }
        }
        static string CreatePathToFile(string fileName)
        {
            return Path.Combine(DocumentsPath, fileName);
        }


    }
}