using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin.DataTemplateTest
{
    public partial class DTListView : ContentPage
    {
        public DTListView()
        {
            InitializeComponent();
            loadData();
        }


        public void loadData()
        {
            list.ItemsSource = Guide.CreateGuides();
        }
    }
}
