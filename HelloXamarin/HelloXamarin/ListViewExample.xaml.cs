using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class ListViewExample : ContentPage
    { 
        public ListViewExample()
        {

            InitializeComponent();
            recipes.ItemsSource = RecipeDataSource.GetList();

        }
    }
}
