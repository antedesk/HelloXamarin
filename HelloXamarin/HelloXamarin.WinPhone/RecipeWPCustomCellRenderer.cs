using HelloXamarin;
using HelloXamarin.WinPhone;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinRT;


[assembly: ExportRenderer(typeof(RecipeCustomCell), typeof(RecipeWPCustomCellRenderer))]

namespace HelloXamarin.WinPhone
{
    class RecipeWPCustomCellRenderer : ViewCellRenderer
    {
        public override Windows.UI.Xaml.DataTemplate GetTemplate(Cell cell)
        {
            return App.Current.Resources["RecipeListViewItemTemplate"] as Windows.UI.Xaml.DataTemplate;
        }
    }
}
