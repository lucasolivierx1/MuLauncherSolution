using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuLauncher.variants.mubrgames.components
{
    public class TotalProgressBar : LauncherProgressBar
    {
        public override void Build(Form pForm)
        {
            SmoothProgressBar bar = new SmoothProgressBar();
            bar.BackColor = getColorDark();
            bar.ProgressBarColor = getColor();
            
            bar.Size = getSize();
            bar.Location = GetPosition();


            component = bar;
            pForm.Controls.Add(bar);
        }

        public override Color getColor()
        {
            return Color.FromArgb(0,159,223);
        }

        public override Color getColorDark()
        {
            return Color.FromArgb(15,15,15);
        }

        public override Size getSize()
        {
            return new Size(550, 10);
        }

        public override Point GetPosition()
        {
            return new Point(420, 571);
        }
    }
}
