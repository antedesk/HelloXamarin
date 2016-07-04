using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace HelloXamarin
{
    public class RelativeLayoutExample : ContentPage
    {
        public RelativeLayoutExample()
        {

            RelativeLayout rl = new RelativeLayout();
            

            Label cl = new Label
            {
                Text = "Center",
            };
            rl.Children.Add(cl,
                Constraint.RelativeToParent((parent) => {
                    return parent.Width / 2;
                }),
                Constraint.RelativeToParent((parent) => {
                    return parent.Height / 2;
                }));


            Label ul = new Label
            {
                Text = "Up-Left",
            };
            rl.Children.Add(ul,
               Constraint.Constant(0),
                Constraint.Constant(0));


            Label dr = new Label
            {
                Text = "Down-Right",
            };
            rl.Children.Add(dr,
               Constraint.RelativeToParent((parent) => {
                   return parent.Width- 90;
               }),
                Constraint.RelativeToParent((parent) => {
                    return parent.Height- 20;
                }));

            Content = rl;

        }
    }
}
