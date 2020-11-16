using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuLauncher.variants.mubrgames.components
{
    public class BrWebView : WebViewComponent
    {
        public override void Build(Form pForm)
        {
            WebBrowser web = new WebBrowser();

            web.Size = getSize();
            web.Location = GetPosition();

            this.component = web;

            pForm.Controls.Add(this.component);
        }

        public override Size getSize()
        {
            return new Size(960, 370);
        }

        public override Point GetPosition()
        {
            return new Point(35, 145);
        }

     
    }
}
