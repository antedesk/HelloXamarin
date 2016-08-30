using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloXamarin
{
    // interfaccia necessaria per l'implementazione di queste operazioni 
    // nei progetti Android, iOS e WindowsPhone
    public interface IFileManager
    {
        // metodo per il salvataggio di un file di testo
        Task SaveAsync(string filename, string text);

        //metodo per il caricamento di un file di testo
        Task<string> LoadAsync(string filename);

        //metodo per verificare l'esistenza di un file di testo
        bool FileExists(string filename);
    }
}
