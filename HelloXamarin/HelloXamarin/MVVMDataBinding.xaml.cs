using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class MVVMDataBinding : ContentPage
    {
        public MVVMDataBinding()
        {
            InitializeComponent();
            BindingContext = new FormViewModel();
        }
    }
}
