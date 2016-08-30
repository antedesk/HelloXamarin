using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class SaverLoaderTextExample : ContentPage
    {
        // nome del file che verrà salvato e caricato nella memoria locale del dispositivo.
        const string fileName = "PersonalFile.txt";

        public SaverLoaderTextExample()
        {

            var fileService = DependencyService.Get<IFileManager>();


            InitializeComponent();

            saveButton.Clicked += async (sender, e) => {
                loadButton.IsEnabled = saveButton.IsEnabled = false;

                await fileService.SaveAsync(fileName, input.Text);
                loadButton.IsEnabled = saveButton.IsEnabled = true;
            };
            
            loadButton.Clicked += async (sender, e) => {
                loadButton.IsEnabled = saveButton.IsEnabled = false;
                output.Text = await fileService.LoadAsync(fileName);
                loadButton.IsEnabled = saveButton.IsEnabled = true;
            };

            loadButton.IsEnabled = fileService.FileExists(fileName);

           
        }
    }
}
