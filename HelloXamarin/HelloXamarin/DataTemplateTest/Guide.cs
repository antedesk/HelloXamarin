using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloXamarin.DataTemplateTest
{
    public class Guide
    {

        public string Title { get; set; }
        public string Author { get; set; }
        public int Lessons { get; set; }

        public Guide(string title, string author, int lessons)
        {
            this.Title = title;
            this.Author = author;
            this.Lessons = lessons;
        }

        public static List<Guide> CreateGuides()
        {
            Guide Java = new Guide("Java", "F. Tosi", 1039);
            Guide MySQL = new Guide("MySQL", "G. Maggi", 45);
            Guide Python = new Guide("Python", "S. Riccio", 24);
            Guide HTML = new Guide("HMTL", "A. Marzilli", 83);
            Guide Android = new Guide("Android", "G. Maggi", 50);
            Guide Xamarin = new Guide("Xamarin.Forms", "A. Tedeschi", 22);

            List<Guide> list = new List<Guide>()
            {
                 Java,
                 MySQL,
                 Python,
                 HTML,
                 Android,
                 Xamarin
            };

            return list;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
