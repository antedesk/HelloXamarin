using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using HelloXamarin;
using HelloXamarin.Droid;
using Android.Graphics.Drawables;
using System.Threading.Tasks;

[assembly: ExportRenderer(typeof(RecipeCustomCell), typeof(RecipeAndroidCustomCellRender))]
namespace HelloXamarin.Droid
{
    public class RecipeAndroidCustomCellRender : ViewCellRenderer
    {
        protected override Android.Views.View GetCellCore(Xamarin.Forms.Cell item, Android.Views.View convertView, ViewGroup parent, Context context)
        {
            var customcell = (RecipeCustomCell)item;

            var view = convertView;

            // no view to re-use, create new
            if (view == null)
            {
                view = (context as Activity).LayoutInflater.Inflate(Resource.Layout.RecipeCustomCell, null);
            }

            view.FindViewById<TextView>(Resource.Id.name).Text = customcell.Name;
            view.FindViewById<TextView>(Resource.Id.type).Text = customcell.Type;

            // grab the old image and dispose of it
            if (view.FindViewById<ImageView>(Resource.Id.Image).Drawable != null)
            {
                using (var image = view.FindViewById<ImageView>(Resource.Id.Image).Drawable as BitmapDrawable)
                {
                    if (image != null)
                    {
                        if (image.Bitmap != null)
                        {
                            image.Bitmap.Dispose();
                        }
                    }
                }
            }

            // If a new image is required, display it
            if (!String.IsNullOrWhiteSpace(customcell.ImagePath))
            {
                context.Resources.GetBitmapAsync(customcell.ImagePath).ContinueWith((t) => {
                    var bitmap = t.Result;
                    if (bitmap != null)
                    {
                        view.FindViewById<ImageView>(Resource.Id.Image).SetImageBitmap(bitmap);
                        bitmap.Dispose();
                    }
                }, TaskScheduler.FromCurrentSynchronizationContext());

            }
            else
            {
                // clear the image
                view.FindViewById<ImageView>(Resource.Id.Image).SetImageBitmap(null);
            }

            return view;
        }
    }
}