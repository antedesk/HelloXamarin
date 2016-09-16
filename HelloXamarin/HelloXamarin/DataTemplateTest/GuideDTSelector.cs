using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloXamarin.DataTemplateTest
{
    public class GuideDTSelector : DataTemplateSelector
    {
        public DataTemplate ShortGuideTemplate { get; set; }
        public DataTemplate MediumGuideTemplate { get; set; }
        public DataTemplate LongGuideTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            int lessons = ((Guide)item).Lessons;
            return lessons <= 30 ? ShortGuideTemplate : lessons<=100 ? MediumGuideTemplate : LongGuideTemplate;
        }
    }
}
